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
    internal class A_MemberGrid_Repository
    {
        public DataTable GetMemberGrid(string search, string type, string status)
        {
            DataTable dt = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_GetMemberGridData", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_Search", search);
                cmd.Parameters.AddWithValue("p_MemberType", type);
                cmd.Parameters.AddWithValue("p_Status", status);

                conn.Open();
                new MySqlDataAdapter(cmd).Fill(dt);

            }
            return dt;
        }

    }
}
