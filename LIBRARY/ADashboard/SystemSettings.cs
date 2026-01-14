using LIBRARY.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.ADashboard
{
    internal class SystemSettings
    {
        public bool UpdateMemberTypeLimits(int typeId, int maxBooks, int period)
        {
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_UpdateMemberTypeLimits", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_MemberTypeID", typeId);
                    cmd.Parameters.AddWithValue("p_MaxBooks", maxBooks);
                    cmd.Parameters.AddWithValue("p_BorrowingPeriod", period);

                    if (conn.State != ConnectionState.Open) conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error updating member limits: " + ex.Message);
                return false;
            }
        }

        public DataTable FetchCurrentLimits()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_GetMemberTypeLimits", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error fetching current limits: " + ex.Message);
            }
            return dt;
        }

        public bool AddCategory(string categoryName)
        {
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_AddCategory", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_CategoryName", categoryName);

                    if (conn.State != ConnectionState.Open) conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error adding category: " + ex.Message);
                return false;
            }
        }
    }
}
