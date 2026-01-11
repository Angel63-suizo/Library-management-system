using LIBRARY.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.LDashboard
{
    internal class BookSearch_Repository
    {

        public DataRow GetBookInfo(string accessionBase)
        {
            DataTable dt = new DataTable();
            using (var conn = Database.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_GetBook", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_AccessionBase", accessionBase);
                    new MySqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public DataTable GetCopyStatuses(int resourceId)
        {
            DataTable dt = new DataTable();
            using (var conn = Database.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_GetCopyStatus", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_ResourceId", resourceId);
                    new MySqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;
        }


    }
}
