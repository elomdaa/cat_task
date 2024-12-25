using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Authentication
    {
        private List<User> users = new();
       public void Register()
        {
            Console.Write("Enter username:");
            string username = Console.ReadLine();
            Console.Write("Enter email:");
            string email = Console.ReadLine();
            Console.Write("Enter password:");
            string password = Console.ReadLine();

            if (users.Exists(u => u.Email == email))
            {
                Console.WriteLine("this email is exist");
                return;
            }

            users.Add(new User(username, email, password));

            Console.WriteLine("thank you for registration");
        }

        public void Login()
        {
            Console.Write("Enter email:");
            string email = Console.ReadLine();
            Console.Write("Enter password:");
            string password = Console.ReadLine();
            User user = users.Find(u => u.Email == email);
            if (user != null)
            {
                if (password == user.Password)
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Invalid password. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Email not found");
            }
        }
    }
}
