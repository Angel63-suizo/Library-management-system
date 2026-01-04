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
    internal class A_GetResourceGrid_Repository
    {
        public DataTable GetResourceGrid(string search, string category)
        {
            DataTable dt = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_GetResourceGrid", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_SearchText", search);
                cmd.Parameters.AddWithValue("p_CategoryName", category);

                conn.Open();
                new MySqlDataAdapter(cmd).Fill(dt);

            }
            return dt;
        }
    }
}
