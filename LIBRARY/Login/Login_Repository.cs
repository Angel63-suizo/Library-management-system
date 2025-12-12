using LIBRARY.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.Login
{
    internal class Login_Repository
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        public static User Login(string username, string password)
        {
            string passwordHash = HashPassword(password);

            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_user_login", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_username", username);
                

                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read())
                    {
                        return null;
                    }

                    string role = r["Role"].ToString();

                    if (role == "Admin") return new Admin(r);
                    if (role == "Librarian") return new Librarian(r);
                    if (role == "Member") return new Member(r);

                    return null;
                }
            }

        }
    }
}
