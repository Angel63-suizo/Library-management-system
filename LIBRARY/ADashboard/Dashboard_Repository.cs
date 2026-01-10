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
    internal class Dashboard_Repository
    {
            public DataTable GetMonthlyTrends()
            {
                DataTable dt = new DataTable();
                using (var conn = Database.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand("sp_GetMonthlyTrends", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        new MySqlDataAdapter(cmd).Fill(dt);
                    }
                }
                return dt;
            }

            public DataTable GetCategoryStats()
            {
                DataTable dt = new DataTable();
                using (var conn = Database.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand("sp_GetBooksByCategory", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        new MySqlDataAdapter(cmd).Fill(dt);
                    }
                }
                return dt;
            }
        }
}
