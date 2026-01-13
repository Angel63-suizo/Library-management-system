using LIBRARY.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.MDashboard
{
    internal class BorrowingHistory_Repository
    {
        public DataTable GetMemberBorrowingHistory(int memberId, string statusFilter, string searchText)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Database.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand("sp_GetBorrowingHistory", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_MemberId", memberId);
                        cmd.Parameters.AddWithValue("p_StatusFilter", statusFilter);
                        cmd.Parameters.AddWithValue("p_SearchText", searchText);

                        if (conn.State != ConnectionState.Open) conn.Open();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }

        public DataTable GetBorrowingStats(int memberId)
        {
            DataTable dt = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_GetBorrowingHistoryStats", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_MemberId", memberId);
                conn.Open();
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }
    }
}

