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
    internal class A_GetMemberDetails_Repository
    {
        public DataRow GetMemberDetails(string cardNumber)
        {
            DataTable dt = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_GetMemberDetails", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_CardNumber", cardNumber);

                conn.Open();
                new MySqlDataAdapter(cmd).Fill(dt);

            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

       /* public DataTable GetMemberTransactionHistory(string memberId)
        {
            DataTable dt = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_GetMemberTransactionHistory", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_MemberId", memberId);

                conn.Open();
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }*/
    }
}
