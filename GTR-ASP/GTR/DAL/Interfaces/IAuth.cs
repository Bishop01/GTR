using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAuth
    {
        public Task<bool> Authenticate(string email, string password);
        public Task<dynamic> GetAccessToken(string email, string accTokenSecKey, string refTokenSecKey);
        public Task<string> RefreshAccessToken(string email, string refAccToken, string accTokenSecKey);
    }
}
