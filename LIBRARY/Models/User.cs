using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.Class
{
    public class User
    {
        private int userId;
        private string username;
        private string password;
        private string firstname;
        private string lastname;
        private string email;
        private string phone;
        private string role;
        private DateTime createdAt;

        public int UserId { get => userId; set => userId = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Role { get => role; set => role = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public bool Login (string username, string password)
        {
            //add logic to checlk credentials
            return false;
        }

        public void Logout()
        {
            Console.WriteLine("User Logged out.");
        }
    }

}
