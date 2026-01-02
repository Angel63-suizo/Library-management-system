using LIBRARY.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static LIBRARY.Class.Database;

namespace LIBRARY.ADashboard
{
    internal class A_AddMember_Repository
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        public string AddNewMember(Member member, string memberTypeName, string status)
        {
            string cardNum = string.Empty;
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_AddNewMember", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_FirstName", member.Firstname);
                    cmd.Parameters.AddWithValue("p_LastName", member.Lastname);
                    cmd.Parameters.AddWithValue("p_Email", member.Email);
                    cmd.Parameters.AddWithValue("p_MemberTypeName", memberTypeName);
                    cmd.Parameters.AddWithValue("p_Address", member.Address);
                    cmd.Parameters.AddWithValue("p_Status", status);
                    cmd.Parameters.AddWithValue("p_Password", HashPassword(member.Password));

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cardNum = reader["CardNumber"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Database Error: " + ex.Message);
            }

            return cardNum;
        }

       public DataTable GetMemberType()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_GetMemberTypes", conn))
                {
                   cmd.CommandType = CommandType.StoredProcedure;
                   conn.Open();

                   using (MySqlDataAdapter adapt = new MySqlDataAdapter(cmd))
                   {
                      adapt.Fill(dt);
                   }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }

        public List<string> GetStatus(String tablename, string columnname )
        {
            List<string> values = new List<string>();
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_GetStatus", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_Member", tablename);
                    cmd.Parameters.AddWithValue("p_Status", columnname);

                    conn.Open();
                    string result = cmd.ExecuteScalar()?.ToString();

                    if (!String.IsNullOrEmpty(result))
                    {
                        result = result.Replace("enum(", "").Replace(")", "").Replace("'", "");
                        values.AddRange(result.Split(','));
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
            }
            return values;
        }
    }
}
