using Azure.Core;
using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GTR.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    [EnableCors("CorsPolicy")]
    public class Logged
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration configuration;

        public Logged(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            this.configuration = configuration;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var token = httpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (token == null)
            {
                httpContext.Response.StatusCode = 401; //UnAuthorized
                return;
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(configuration["Jwt:Key"]);
                try
                {
                    tokenHandler.ValidateToken(token, new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                        ClockSkew = TimeSpan.Zero
                    }, out SecurityToken validatedToken);

                    var jwtToken = (JwtSecurityToken)validatedToken;
                    Claim claim = jwtToken.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email);
                    string email = claim == null ? null : claim.Value;
                    

                    // return user id from JWT token if validation successful
                    await _next(httpContext);
                    return;
                }
                catch(Exception e)
                {
                    // return null if validation fails
                    httpContext.Response.StatusCode = 403; //Restricted
                    return;
                }
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class LoggedExtensions
    {
        public static IApplicationBuilder UseLogged(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Logged>();
        }
    }
}
