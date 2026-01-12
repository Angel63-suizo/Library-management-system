using LIBRARY.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.MDashboard
{
    internal class MyBooks_Repository
    {
        public DataTable GetMemberBorrowedBooks(int memberId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Database.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand("sp_GetMemberBorrows", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_MemberId", memberId);

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
    }
}
