using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }

        public override string ToString()
        {
            return $"Username: {Username}, Email: {Email}";
        }
    }
}
