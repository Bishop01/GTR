using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class LoginDTO: UserDTO
    {
        public string AccessToken { get; set; } = string.Empty;
    }
}
