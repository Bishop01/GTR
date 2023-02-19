using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30, MinimumLength =4)]
        public string Name { get; set; }
        [MinLength(8)]
        //USE REGEX FOR VALIDATION
        public string Password { get; set; }
        //USE REGEX FOR VALIDATION
        public string Email { get; set; }
    }
}
