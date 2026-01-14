using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.ADashboard
{
    public partial class ucReportPreview : UserControl
    {
        public ucReportPreview()
        {
            InitializeComponent();
        }

        private void ucReportPreview_Load(object sender, EventArgs e)
        {

        }
        public void SetData(DataSet ds, string period)
        {
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                richTextBox1.Text = "No data available for this report.";
                return;
            }

            richTextBox1.Clear();
            DataRow summary = ds.Tables[0].Rows[0];

            AppendBoldText("MONTHLY CIRCULATION REPORT\n");
            AppendNormalText($"Generated: {DateTime.Now:MM/dd/yyyy}\n");
            AppendNormalText($"Period: {period}\n\n");

            AppendBoldText("SUMMARY:\n");

            AppendNormalText($"Total Checkouts: {Convert.ToInt32(summary["TotalCheckouts"]):N0}\n");
            AppendNormalText($"Total Returns: {Convert.ToInt32(summary["TotalReturns"]):N0}\n");
            AppendNormalText($"Active Reservations: {Convert.ToInt32(summary["ActiveReservations"]):N0}\n");
            AppendNormalText($"Overdue Items: {Convert.ToInt32(summary["OverdueItems"]):N0}\n\n");

            if (ds.Tables.Count > 1)
            {
                AppendBoldText("CATEGORY BREAKDOWN:\n");
                foreach (DataRow row in ds.Tables[1].Rows)
                {
                    double pct = Convert.ToDouble(row["Percentage"]);
                    AppendNormalText($"{row["Name"]}: {pct:F1}%\n");
                }
            }
        }

        private void AppendBoldText(string text)
        {
            Font currentFont = richTextBox1.Font ?? new Font("Segoe UI", 10);
            using (Font boldFont = new Font(currentFont, FontStyle.Bold))
            {
                richTextBox1.SelectionFont = boldFont;
                richTextBox1.AppendText(text);
            }
        }

        private void AppendNormalText(string text)
        {
            Font currentFont = richTextBox1.Font ?? new Font("Segoe UI", 10);
            using (Font regularFont = new Font(currentFont, FontStyle.Regular))
            {
                richTextBox1.SelectionFont = regularFont;
                richTextBox1.AppendText(text);
            }
        }
    }
}
