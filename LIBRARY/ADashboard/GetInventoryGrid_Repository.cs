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
    internal class GetInventoryGrid_Repository
    {
        public DataTable GetInventoryGrid(string search, string category, string status)
        {
            DataTable dt = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_GetInventoryGrid", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_SearchText", search ?? "");
                cmd.Parameters.AddWithValue("p_CategoryName", category ?? "All Categories");
                cmd.Parameters.AddWithValue("p_Status", status ?? "All Status");

                conn.Open();
                new MySqlDataAdapter(cmd).Fill(dt);

            }
            return dt;
        }
    }
}
