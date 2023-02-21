using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    internal class AuthRepo : IAuth
    {
        private GTRDbContext DbContext { get; }
        public AuthRepo()
        {
            DbContext = new GTRDbContext();
        }

        public async Task<bool> Authenticate(string email, string password)
        {
            User? User = await DbContext.Users.FirstOrDefaultAsync(user=>user.Email == email);

            if (User == null || !BCrypt.Net.BCrypt.Verify(password, User.Password))
                return false;

            return true;
        }

        public async Task<dynamic> GetAccessToken(string email, string accTokenSecKey, string refTokenSecKey)
        {
            User user = await DbContext.Users.FirstOrDefaultAsync(u=>u.Email.Equals(email));
            string accessToken = GenerateAccessToken(user, accTokenSecKey);

            User newUser = new User()
            {
                Id = user.Id,
                Email = user.Email,
                Name = user.Name
            };

            string refreshToken = await GenerateRefreshToken(user, refTokenSecKey);

            return (new {User = newUser, AccessToken=accessToken, RefreshToken= refreshToken });
        }

        private string GenerateAccessToken(User user, string accTokenSecKey, int refreshDay = 1)
        {
            List<Claim> Claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Email, user.Email)
            };
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(accTokenSecKey));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
            var token = new JwtSecurityToken(
                claims: Claims,
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: cred
            );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        private async Task<string> GenerateRefreshToken(User user, string refTokenSecKey)
        {
            Token token = await DbContext.Tokens.FirstOrDefaultAsync(t => t.UserId == user.Id && t.ExpiresAt > DateTime.Now);
            if(token==null)
            {
                var tk = GenerateAccessToken(user, refTokenSecKey, 30);
                Token t = new Token()
                {
                    RefreshToken = tk,
                    ExpiresAt = DateTime.Now.AddDays(30),
                    UserId = user.Id
                };
                await DbContext.Tokens.AddAsync(t);
                await DbContext.SaveChangesAsync();
                token = t;
            }
            return token.RefreshToken;
        }

        public async Task<string> RefreshAccessToken(string email, string refAccToken, string accTokenSecKey)
        {
            Token token = await DbContext.Tokens.FirstOrDefaultAsync(t => t.User.Email.Equals(email) && t.RefreshToken.Equals(refAccToken) && t.ExpiresAt > DateTime.Now);
            if (token == null)
                return "";

            User user = await DbContext.Users.FirstOrDefaultAsync(u => u.Email.Equals(email));

            return GenerateAccessToken(user, accTokenSecKey);
        }
    }
}
