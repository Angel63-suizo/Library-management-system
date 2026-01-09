using LIBRARY.Class;
using LIBRARY.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.LDashboard
{
    internal class BorrowingTransaction_Repository
    {
        public bool SaveBorrowingTransaction(string cardNumber, List<BorrowingTransaction> items)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        foreach (var item in items)
                        {
                            using (MySqlCommand cmd = new MySqlCommand("sp_SaveBorrowTransaction", conn, trans))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("p_CardNumber", cardNumber);
                                cmd.Parameters.AddWithValue("p_CopyId", item.CopyId);
                                cmd.Parameters.AddWithValue("p_DueDate", item.DueDate);

                                cmd.ExecuteNonQuery();
                            }
                        }
                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public bool ReturnBooksTransaction(List<BorrowingTransaction> items)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        foreach (var item in items)
                        {
                            using (MySqlCommand cmd = new MySqlCommand("sp_ReturnBook", conn, trans))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                               
                                cmd.Parameters.AddWithValue("p_CopyId", item.CopyId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw ex;
                    }
                }
            }
        }
    }
}
