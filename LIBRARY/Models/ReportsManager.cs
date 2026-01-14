using LIBRARY.Class;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using ClosedXML.Excel;
using ClosedXML.Graphics;

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
    }
}
