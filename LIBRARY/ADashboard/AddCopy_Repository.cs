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
    internal class AddCopy_Repository
    {
        public class Copy_Repository
        {
            public bool BulkAddCopies(string title, int count)
            {
                try
                {
                    using (var conn = Database.GetConnection())
                    using (var cmd = new MySqlCommand("sp_AddBookCopy", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_Title", title);
                        cmd.Parameters.AddWithValue("p_NumCopies", count);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error adding copies: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
