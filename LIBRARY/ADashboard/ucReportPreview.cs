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
        public void LoadData(DataSet ds, string period)
        {
            richTextBox1.Clear();
            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return;

            DataRow summary = ds.Tables[0].Rows[0];

            AppendBoldText("MONTHLY CIRCULATION REPORT\n");
            AppendNormalText($"Generated: {DateTime.Now:M/d/yyyy}\n");
            AppendNormalText($"Period: {period}\n\n");

            AppendBoldText("SUMMARY:\n");
            AppendNormalText($"Total Checkouts: {summary["TotalCheckouts"]:N0}\n");
            AppendNormalText($"Total Returns: {summary["TotalReturns"]:N0}\n");
            AppendNormalText($"Active Reservations: {summary["ActiveReservations"]:N0}\n");
            AppendNormalText($"Overdue Items: {summary["OverdueItems"]:N0}\n\n");

            AppendBoldText("CATEGORY BREAKDOWN:\n");
            foreach (DataRow row in ds.Tables[1].Rows)
            {
                AppendNormalText($"{row["Name"]}: {row["Percentage"]}%\n");
            }

        }

        private void AppendBoldText(string text)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText(text);
        }

        private void AppendNormalText(string text)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            richTextBox1.AppendText(text);
        }
    }
}
