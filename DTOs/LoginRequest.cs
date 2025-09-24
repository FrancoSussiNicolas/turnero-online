using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class LoginRequest
    {
        public string Mail { get; set; } = string.Empty; 
        public string Password { get; set; } = string.Empty;

        public LoginRequest(string mail, string password)
        {
            Mail = mail;
            Password = password;
        }
    }
}
