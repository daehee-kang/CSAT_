using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSAT.App_Code
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }

        public User(int id, string login, string password, string email, string type)
        {
            Id = id;
            Login = login;
            Password = password;
            Email = email;
            Type = type;
        }

        public User(string login, string password, string email, string type)
        {
            Login = login;
            Password = password;
            Email = email;
            Type = type;
        }
    }
}