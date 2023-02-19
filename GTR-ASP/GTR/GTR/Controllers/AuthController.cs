using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace GTR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration Configuration;
        
        public AuthController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [Route("Login")]
        [HttpPost]
        public async Task<IActionResult> Login(UserDTO user)
        {
            var result = await AuthService.Authenticate(user.Email, user.Password);
            if (!result)
                return NotFound();

            var obj = await AuthService.GetAccessToken(user.Email, Configuration["Jwt:Key"], Configuration["Jwt:RefreshKey"]);
            return Ok(obj);
        }

        [Route("Refresh")]
        [HttpPost]
        public async Task<IActionResult> Refresh(UserDTO user)
        {
            var token = Request.Headers.Authorization.ToString();
            if (token.IsNullOrEmpty())
                return Unauthorized(new {Status=401, Message="No token provided!"});

            var obj = await AuthService.RefreshAccessToken(user.Email, token, Configuration["Jwt:Key"]);
            return Ok(obj);
        }
    }
}
