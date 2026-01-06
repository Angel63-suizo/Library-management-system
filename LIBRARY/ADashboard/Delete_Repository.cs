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
    internal class Delete_Repository
    {
        public (bool success, string message) DeleteMemberFull(string cardNumber)
        {
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_DeleteMember", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_CardNumber", cardNumber);

                    cmd.Parameters.Add(new MySqlParameter("p_Success", MySqlDbType.Byte) { Direction = ParameterDirection.Output });
                    cmd.Parameters.Add(new MySqlParameter("p_Message", MySqlDbType.VarChar, 255) { Direction = ParameterDirection.Output });

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    bool success = Convert.ToBoolean(cmd.Parameters["p_Success"].Value);
                    string message = cmd.Parameters["p_Message"].Value.ToString();

                    return (success, message);
                }
            }
            catch (Exception ex)
            {
                return (false, "Database Error: " + ex.Message);
            }
        }
    }
}
