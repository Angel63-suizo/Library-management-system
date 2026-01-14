using ClosedXML.Excel;
using ClosedXML.Graphics;
using LIBRARY.Class;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;
using System.Windows.Forms;

namespace LIBRARY.Models
{
    internal class ReportsManager
    {
        public DataSet GenerateReportData(DateTime start, DateTime end)
        {
            DataSet ds = new DataSet();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_GetLibraryManagementReport", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_StartDate", start);
                cmd.Parameters.AddWithValue("p_EndDate", end);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            return ds;
        }

        public void ExportToExcel(DataSet data, string filePath)
        {
            try
            {
                LoadOptions.DefaultGraphicEngine = new DefaultGraphicEngine("Arial");
                using (var workbook = new XLWorkbook())
                {
                    var summarySheet = workbook.Worksheets.Add("Summary");
                    summarySheet.Cell(1, 1).Value = "Monthly Circulation Report Summary";
                    summarySheet.Cell(1, 1).Style.Font.Bold = true;

                    summarySheet.Cell(3, 1).InsertTable(data.Tables[0]);
                    summarySheet.Columns().AdjustToContents();

                    if (data.Tables.Count > 1)
                    {
                        var categorySheet = workbook.Worksheets.Add("Category Breakdown");
                        categorySheet.Cell(1, 1).InsertTable(data.Tables[1]);
                        categorySheet.Columns().AdjustToContents();
                    }

                    workbook.SaveAs(filePath);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Export Error: " + ex.Message);
            }
        }

        public DataSet OverdueReport(DateTime start, DateTime end)
        {
            DataSet ds = new DataSet();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_GetOverdueReport", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_StartDate", start);
                cmd.Parameters.AddWithValue("p_EndDate", end);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            return ds;
        }

        public void ExportOverdueToExcel(DataSet data, string filePath)
        {
            try
            {
                if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0)
                {
                    System.Windows.Forms.MessageBox.Show("No data available to export.");
                    return;
                }

                using (var workbook = new XLWorkbook())
                {
                    var sheet = workbook.Worksheets.Add("Overdue Report");

                    sheet.Cell(1, 1).Value = "OVERDUE BOOKS REPORT";
                    sheet.Cell(1, 1).Style.Font.Bold = true;
                    sheet.Cell(2, 1).Value = $"Generated: {DateTime.Now:yyyy-MM-dd}";

                    if (data.Tables[0].Columns.Contains("FormattedReport"))
                    {
                        sheet.Cell(4, 1).Value = "Summary of Overdue Items";
                        sheet.Cell(5, 1).Value = data.Tables[0].Rows[0]["FormattedReport"].ToString();
                        sheet.Cell(5, 1).Style.Alignment.WrapText = true;
                        sheet.Column(1).Width = 100;
                    }
                    else
                    {
                        var table = sheet.Cell(4, 1).InsertTable(data.Tables[0]);
                        table.Theme = XLTableTheme.TableStyleLight8;
                        sheet.Columns().AdjustToContents();
                    }

                    workbook.SaveAs(filePath);
                }
                System.Windows.Forms.MessageBox.Show("Excel report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Export Error: " + ex.Message);
            }
        }

        public DataSet MembersActivityData(DateTime start, DateTime end)
        {
            DataSet ds = new DataSet();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_GetMembersActivityReport", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_StartDate", start);
                cmd.Parameters.AddWithValue("p_EndDate", end);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            return ds;
        }

        public void MembersActivityToExcel(DataSet data, string filePath)
        {
            try
            {
                LoadOptions.DefaultGraphicEngine = new DefaultGraphicEngine("Arial");
                using (var workbook = new XLWorkbook())
                {
                    var sheet = workbook.Worksheets.Add("Members Activity");

                    var title = sheet.Cell(1, 1);
                    title.Value = "MEMBERS ACTIVITY REPORT";
                    title.Style.Font.Bold = true;
                    title.Style.Font.FontSize = 14;

                    if (data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0)
                    {
                        var row = data.Tables[0].Rows[0];
                        sheet.Cell(3, 1).Value = "SUMMARY STATISTICS";
                        sheet.Cell(3, 1).Style.Font.Bold = true;
                        sheet.Cell(4, 1).Value = $"New Members: {row["NewMembers"]}";
                        sheet.Cell(5, 1).Value = $"Expired Memberships: {row["ExpiredMemberships"]}";
                        sheet.Cell(6, 1).Value = $"Suspended Accounts: {row["SuspendedAccounts"]}";
                    }

                    if (data.Tables.Count > 1)
                    {
                        sheet.Cell(8, 1).Value = "MEMBER TYPE BREAKDOWN";
                        sheet.Cell(8, 1).Style.Font.Bold = true;
                        sheet.Cell(9, 1).InsertTable(data.Tables[1]);
                    }

                    sheet.Columns().AdjustToContents();
                    workbook.SaveAs(filePath);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Export Error: " + ex.Message);
            }
        }

        public DataSet InventoryStatusData()
        {
            DataSet ds = new DataSet();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_GetInventoryStatusReport", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            return ds;
        }

        public void ExportInventoryToExcel(DataSet data, string filePath)
        {
            try
            {
                LoadOptions.DefaultGraphicEngine = new DefaultGraphicEngine("Arial");
                using (var workbook = new XLWorkbook())
                {
                    var sheet = workbook.Worksheets.Add("Inventory Status");

                    sheet.Cell(1, 1).Value = "INVENTORY STATUS REPORT";
                    sheet.Cell(1, 1).Style.Font.Bold = true;
                    sheet.Cell(2, 1).Value = $"Generated: {DateTime.Now:MM/dd/yyyy}";

                    var totals = data.Tables[0].Rows[0];
                    sheet.Cell(4, 1).Value = "TOTAL BOOKS: " + totals["TotalBooks"];
                    sheet.Cell(5, 1).Value = "Total Available: " + totals["TotalAvailable"];
                    sheet.Cell(6, 1).Value = "Total Checked Out: " + totals["TotalCheckedOut"];
                    sheet.Cell(7, 1).Value = "Total Reserved: " + totals["TotalReserved"];
                    sheet.Cell(8, 1).Value = "For Repair: " + totals["UnderMaintenance"];
                    sheet.Cell(9, 1).Value = "Lost Books: " + totals["Lost"];
                    sheet.Cell(10, 1).Value = "Damaged Books: " + totals["Damaged"];

                    sheet.Cell(12, 1).Value = "CATEGORY DISTRIBUTION";
                    sheet.Cell(12, 1).Style.Font.Bold = true;
                    sheet.Cell(13, 1).InsertTable(data.Tables[3]);

                    sheet.Columns().AdjustToContents();
                    workbook.SaveAs(filePath);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Export Error: " + ex.Message);
            }
        }

        public DataTable GetCirculationTrends(DateTime start, DateTime end)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_GetCirculationTrends", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_StartDate", start);
                    cmd.Parameters.AddWithValue("p_EndDate", end);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error fetching filtered trends: " + ex.Message);
            }
            return dt;
        }

        public DataTable GetMemberActivityTrends(DateTime start, DateTime end)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("sp_GetMemberActivityChart", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_StartDate", start);
                    cmd.Parameters.AddWithValue("p_EndDate", end);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error fetching member trends: " + ex.Message);
            }
            return dt;
        }
    }
}
