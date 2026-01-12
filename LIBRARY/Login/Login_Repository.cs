using LIBRARY.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static LIBRARY.Class.Database;

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
        public static User Login(string user, string pass, string role)
        {
            using (var conn = Database.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_login_user", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_Username", user);
                    cmd.Parameters.AddWithValue("p_Password", HashPassword(pass)); 

                    if (conn.State != ConnectionState.Open) conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string dbRole = reader["Role"].ToString();

                            if (dbRole != role) return null;

                            if (dbRole == "Member")
                            {
                                return new MemberType
                                {
                                    UserId = Convert.ToInt32(reader["UserId"]),
                                    MemberId = Convert.ToInt32(reader["MemberId"]),
                                    Firstname = reader["FirstName"].ToString(),
                                    Lastname = reader["LastName"].ToString(),
                                    Username = reader["Username"].ToString(),
                                };
                            }
                            else
                            {
                                return new libraryStaff
                                {
                                    UserId = Convert.ToInt32(reader["UserId"]),
                                    Firstname = reader["FirstName"].ToString(),
                                    Lastname = reader["LastName"].ToString(),
                                    Role = dbRole
                                };
                            }
                        }
                    }
                }
            }
            return null;
        }
    }
}
