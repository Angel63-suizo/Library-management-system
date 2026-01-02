using LIBRARY.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace LIBRARY.ADashboard
{
    internal class A_AddLibraryStaff_Repository
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        public string AddStaff(libraryStaff libstaff)
        {
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_AddNewLibrarian", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_PasswordHash", HashPassword(libstaff.Password));
                    cmd.Parameters.AddWithValue("p_FirstName", libstaff.Firstname);
                    cmd.Parameters.AddWithValue("p_LastName", libstaff.Lastname);
                    cmd.Parameters.AddWithValue("p_Email", libstaff.Email);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Database Error: " + ex.Message);
                return null;
            }
        }
    }
}
