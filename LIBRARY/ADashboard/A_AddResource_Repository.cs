using LIBRARY.Class;
using LIBRARY.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace LIBRARY.ADashboard
{
    internal class A_AddResource_Repository
    {
        public string AddNewResource(Resource resource, int categoryId, string resourceType, int Copies)
        {
            string accessionbase = string.Empty;
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_AddResource", conn)) 
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_ISBN", resource.ISBN);
                    cmd.Parameters.AddWithValue("p_Title", resource.Title);
                    cmd.Parameters.AddWithValue("p_Author", resource.Author); 
                    cmd.Parameters.AddWithValue("p_CategoryId", categoryId); 
                    cmd.Parameters.AddWithValue("p_PublisherName", resource.PublisherId); 
                    cmd.Parameters.AddWithValue("p_PubYear", resource.PublicationYear);
                    cmd.Parameters.AddWithValue("p_Edition", resource.Edition);
                    cmd.Parameters.AddWithValue("p_Language", resource.Language);
                    cmd.Parameters.AddWithValue("p_Pages", resource.Pages);
                    cmd.Parameters.AddWithValue("p_ResourceType", resourceType);
                    cmd.Parameters.AddWithValue("p_TotalCopies", Copies);

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            accessionbase = reader["AccessionBase"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Database Error: " + ex.Message);
            }

            return accessionbase;
        }

        public DataTable GetCategories()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_GetAllCategories", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    using (MySqlDataAdapter adapt = new MySqlDataAdapter(cmd))
                    {
                        adapt.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }

        public List<string> GetResourceType(String tablename, string columnname)
        {
            List<string> values = new List<string>();
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_GetResourceType", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_Resource", tablename);
                    cmd.Parameters.AddWithValue("p_ResourceType", columnname);

                    conn.Open();
                    string result = cmd.ExecuteScalar()?.ToString();

                    if (!String.IsNullOrEmpty(result))
                    {
                        result = result.Replace("enum(", "").Replace(")", "").Replace("'", "");
                        values.AddRange(result.Split(','));
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
            }
            return values;
        }
    }
}
