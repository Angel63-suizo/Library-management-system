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
    internal class MemberLookup_Repository
    {

        public DataRow GetMemberProfile(string cardNumber)
        {
            DataTable dt = new DataTable();
            using (var conn = Database.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_GetMemberProfile", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_CardNumber", cardNumber);
                    new MySqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public DataTable GetBorrowedBooks(string cardNumber)
        {
            DataTable dt = new DataTable();
            using (var conn = Database.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_GetMemberBorrowedBooks", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_CardNumber", cardNumber);
                    new MySqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;
        }
    }
}
