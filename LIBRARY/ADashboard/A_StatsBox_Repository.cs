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
    internal class A_StatsBox_Repository
    {
        public DataTable GetMemberStats()
        {
            DataTable dt = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_GetMemberStats", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }
    }
}
