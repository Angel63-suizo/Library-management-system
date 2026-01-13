using LIBRARY.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.MDashboard
{
    internal class Profile_Repository
    {
        public DataRow GetMemberProfile(int memberId)
        {
            DataTable dt = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_MemberProfile", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_MemberId", memberId);

                conn.Open();
                new MySqlDataAdapter(cmd).Fill(dt);

            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
    

        public bool UpdateProfile(int memberId, string firstname, string lastname, string email, string phone, string address)
        {
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_UpdateProfile", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_MemberId", memberId);
                    cmd.Parameters.AddWithValue("p_FirstName", firstname);
                    cmd.Parameters.AddWithValue("p_LastName", lastname);
                    cmd.Parameters.AddWithValue("p_Email", email);
                    cmd.Parameters.AddWithValue("p_Phone", phone);
                    cmd.Parameters.AddWithValue("p_Address", address);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Update Error: " + ex.Message);
                return false;
            }
        }

        public DataTable GetFineHistory(int memberId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_GetFineHistory", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_MemberId", memberId);

                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error fetching fine history: " + ex.Message);
            }
            return dt;
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        public int ChangePassword(int memberId, string currentPwd, string newPwd)
        {
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_ChangeUserPassword", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_MemberId", memberId);
                    cmd.Parameters.AddWithValue("p_CurrentPassword", HashPassword(currentPwd));
                    cmd.Parameters.AddWithValue("p_NewPassword", HashPassword(newPwd));

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error updating password: " + ex.Message);
                return -1;
            }
        }
    }
}
