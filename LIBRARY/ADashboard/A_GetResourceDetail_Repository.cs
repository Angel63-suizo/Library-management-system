using LIBRARY.Class;
using LIBRARY.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace LIBRARY.ADashboard
{
    internal class A_GetResourceDetail_Repository
    {
        public DataRow GetResourceDetails (string BookId)
        {
            DataTable dt = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_GetResourceDetails", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_BookID", BookId);

                conn.Open();
                new MySqlDataAdapter(cmd).Fill(dt);

            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public bool UpdateResource(Resource resource, int categoryId, string bookId, string description)
        {
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_UpdateResource", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_BookID", bookId);
                    cmd.Parameters.AddWithValue("p_ISBN", resource.ISBN);
                    cmd.Parameters.AddWithValue("p_Title", resource.Title);
                    cmd.Parameters.AddWithValue("p_Author", resource.Author);
                    cmd.Parameters.AddWithValue("p_PublisherName", resource.PublisherId);
                    cmd.Parameters.AddWithValue("p_PubYear", resource.PublicationYear);
                    cmd.Parameters.AddWithValue("p_CategoryId", categoryId);
                    cmd.Parameters.AddWithValue("p_Description", description);  

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
