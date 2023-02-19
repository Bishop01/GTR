using BLL.DTOs;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        public static async Task<bool> Authenticate(string email, string password)
        {
            return await DataAccessFactory.AuthDataAccess().Authenticate(email, password);
        }

        public static dynamic GetAccessToken(string email, string accTokenSecKey, string refAccTokenSecKey)
        {
            return DataAccessFactory.AuthDataAccess().GetAccessToken(email, accTokenSecKey, refAccTokenSecKey);
        }

        public static async Task<string> RefreshAccessToken(string email, string refAccToken, string accTokenSecKey)
        {
            return await DataAccessFactory.AuthDataAccess().RefreshAccessToken(email, refAccToken, accTokenSecKey);
        }
    }
}
