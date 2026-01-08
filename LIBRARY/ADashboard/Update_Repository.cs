using LIBRARY.Class;
using LIBRARY.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

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

        public bool UpdateResource(Resource res)
        {
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_UpdateResources", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Mapping parameters - Double check these names match your SQL IN parameters
                    cmd.Parameters.AddWithValue("p_AccessionBase", res.AccessionBase);
                    cmd.Parameters.AddWithValue("p_ISBN", res.ISBN);
                    cmd.Parameters.AddWithValue("p_Title", res.Title);
                    cmd.Parameters.AddWithValue("p_Author", res.Author);
                    cmd.Parameters.AddWithValue("p_PublisherName", res.PublisherName);
                    cmd.Parameters.AddWithValue("p_PublicationYear", res.PublicationYear);
                    cmd.Parameters.AddWithValue("p_Description", res.Description);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Update failed: No record found with ID " + res.AccessionBase);
                        return false;
                    }

                    return true;
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show($"MySQL Error ({ex.Number}): {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("General Error: " + ex.Message);
                return false;
            }
        }

        public DataRow GetResourceDetails2(string AccessionBase)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_GetResourceDetails2", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_AccessionBase", AccessionBase);
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
