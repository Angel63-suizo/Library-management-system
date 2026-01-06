using LIBRARY.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LIBRARY.ADashboard
{
    internal class Update_Repository
    {
        public bool UpdateMember(Models.Member member, string typeName, string status)
        {
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_UpdateMember", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameters correctly mapped to your stored procedure
                    cmd.Parameters.AddWithValue("p_CardNumber", member.Cardnumber);
                    cmd.Parameters.AddWithValue("p_FirstName", member.Firstname);
                    cmd.Parameters.AddWithValue("p_LastName", member.Lastname);
                    cmd.Parameters.AddWithValue("p_Email", member.Email);
                    cmd.Parameters.AddWithValue("p_Phone", member.Phone);
                    cmd.Parameters.AddWithValue("p_Address", member.Address);
                    cmd.Parameters.AddWithValue("p_MemberTypeName", typeName);
                    cmd.Parameters.AddWithValue("p_Status", status);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update Error: " + ex.Message);
                return false;
            }
        }

        public DataRow GetMemberDetails2(string cardNumber)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_GetMemberDetails2", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_CardNumber", cardNumber);
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Fetch Error: " + ex.Message);
            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
    }
}
