using LIBRARY.Class;
using LIBRARY.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LIBRARY.MDashboard
{
    internal class Catalog_Repository
    {
        public List<Resource> GetCatalogItems(string searchTerm = null, string category = "All Categories")
        {
            List<Resource> resourceList = new List<Resource>();
            using (var conn = Database.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_GetCatalogItems", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_SearchTerm", string.IsNullOrEmpty(searchTerm) ? (object)DBNull.Value : searchTerm);
                    cmd.Parameters.AddWithValue("p_CategoryName", category);

                    if (conn.State != ConnectionState.Open) conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            resourceList.Add(new Resource
                            {
                                ResourceId = Convert.ToInt32(reader["ResourceId"]),
                                Title = reader["Title"].ToString(),
                                Author = reader["Author"].ToString(),
                                ResourceType = reader["Categories"].ToString(),

                                TotalCopies = Convert.ToInt32(reader["TotalCopies"]),
                                AvailableCopies = Convert.ToInt32(reader["AvailableCopies"])
                            });
                        }
                    }
                }
            }
            return resourceList;
        }

        public Resource GetResourceDetails(int resourceId)
        {
            Resource book = null;
            using (var conn = Database.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_GetResourceById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_ResourceId", resourceId);

                    if (conn.State != ConnectionState.Open) conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            book = new Resource
                            {
                                ResourceId = Convert.ToInt32(reader["ResourceId"]),
                                Title = reader["Title"].ToString(),
                                Author = reader["Author"].ToString(),
                                ISBN = reader["ISBN"].ToString(),
                                PublicationYear = Convert.ToInt32(reader["PublicationYear"]),
                                Description = reader["Description"].ToString(),
                                CoverImagePath = reader["CoverImagePath"].ToString(),
                                ResourceType = reader["Categories"].ToString(),
                                TotalCopies = Convert.ToInt32(reader["TotalCopies"]),
                                AvailableCopies = Convert.ToInt32(reader["AvailableCopies"])
                            };
                        }
                    }
                }
            }
            return book;
        }

        public bool ReserveBook(int memberId, int resourceId)
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand("sp_ReserveResource", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_MemberId", memberId);
                    cmd.Parameters.AddWithValue("p_ResourceId", resourceId);

                    MySqlParameter successParam = new MySqlParameter("p_Success", MySqlDbType.Byte)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(successParam);

                    if (conn.State != ConnectionState.Open) conn.Open();
                    cmd.ExecuteNonQuery();

                    return Convert.ToBoolean(cmd.Parameters["p_Success"].Value);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Database Error: " + ex.Message);
                return false;
            }
        }
    }
}
