using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace login_MVC.DAL
{
    public class Usuario
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public Usuario() { }
        public Usuario(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}