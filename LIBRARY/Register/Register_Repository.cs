using LIBRARY.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.Register
{
    public class Register_Repository
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        public static bool RegisterMember(Member m, string password)
        {
            if (string.IsNullOrWhiteSpace(m.Username))
            {
                MessageBox.Show("Username is required.");
                return false;
            }

            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_register_member", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_username", m.Username);
                cmd.Parameters.AddWithValue("@p_passwordHash", HashPassword(password));
                cmd.Parameters.AddWithValue("@p_firstName", m.FirstName);
                cmd.Parameters.AddWithValue("@p_lastName", m.LastName);
                cmd.Parameters.AddWithValue("@p_email", m.Email);
                cmd.Parameters.AddWithValue("@p_memberTypeId", m.MemberTypeId);
                cmd.Parameters.AddWithValue("@p_cardNumber", m.CardNumber);

                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public static DataTable GetMemberTypes()
        {
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_get_member_types", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public static bool RegisterAdmin(Admin admin, string password)
        {
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_register_admin", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_username", admin.Username);
                cmd.Parameters.AddWithValue("@p_passwordHash", HashPassword(password));
                cmd.Parameters.AddWithValue("@p_firstName", admin.FirstName);
                cmd.Parameters.AddWithValue("@p_lastName", admin.LastName);
                cmd.Parameters.AddWithValue("@p_email", admin.Email);

                conn.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
        }
        public static bool RegisterLibrarian(Librarian librarian, string password)
        {
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_register_librarian", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_username", librarian.Username);
                cmd.Parameters.AddWithValue("@p_passwordHash", HashPassword(password));
                cmd.Parameters.AddWithValue("@p_firstName", librarian.FirstName);
                cmd.Parameters.AddWithValue("@p_lastName", librarian.LastName);
                cmd.Parameters.AddWithValue("@p_email", librarian.Email);

                conn.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
        }


    }
}
