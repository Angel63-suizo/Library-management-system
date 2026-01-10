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
    internal class GetBook_Repository
    {
        public DataRow GetBookCopy (string accessionNum)
        {
            DataTable dt = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_GetBookCopy", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_AccessionNumber", accessionNum);

                conn.Open();
                new MySqlDataAdapter(cmd).Fill(dt);

            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
    }
}
