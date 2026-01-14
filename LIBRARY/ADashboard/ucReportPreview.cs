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
        public void SetData(DataSet ds, string period, string reportType)
        {
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                richTextBox1.Clear();
                richTextBox1.Text = "No data available for the selected period.";
                return;
            }

            richTextBox1.Clear();

            if (reportType == "MonthlyCirculation")
            {
                DisplayMonthlyCirculation(ds, period);
            }
            else if (reportType == "Overdue")
            {
                DisplayOverdueReport(ds, period);
            }
            else if (reportType == "MembersActivity")
            {
                DisplayMembersActivity(ds, period);
            }
            else if (reportType == "InventoryStatus")
            {
                DisplayInventoryStatus(ds);
            }

        }

        private void DisplayMonthlyCirculation(DataSet ds, string period)
        {
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

        private void DisplayOverdueReport(DataSet ds, string period)
        {
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                richTextBox1.Text = "No overdue records found for the selected period.";
                return;
            }

            DataRow row = ds.Tables[0].Rows[0];

            if (row["FormattedReport"] == DBNull.Value)
            {
                richTextBox1.Text = "No overdue records found for the selected period.";
                return;
            }

            richTextBox1.Clear();

            AppendBoldText("OVERDUE BOOKS REPORT\n");
            AppendNormalText($"Period: {period}\n");
            AppendBoldText($"TOTAL ITEMS: {row["TotalCount"]}\n");
            AppendNormalText("==========================================\n\n");

            AppendNormalText(row["FormattedReport"].ToString());

            AppendNormalText("\n\n==========================================\n");
            AppendNormalText("End of Report");

        }

        private void DisplayMembersActivity(DataSet ds, string period)
        {
            if (ds.Tables.Count < 2) return;

            AppendBoldText("MEMBERS ACTIVITY REPORT\n");
            AppendNormalText($"Generated: {DateTime.Now:MM/dd/yyyy}\n");
            AppendNormalText($"Period: {period}\n\n");

            AppendBoldText("MEMBER TYPE BREAKDOWN:\n");
            foreach (DataRow row in ds.Tables[1].Rows)
            {
                AppendBoldText($"{row["MemberType"]}:\n");
                AppendNormalText($" - Active borrowers: {row["ActiveBorrowers"]}\n");
                AppendNormalText($" - Books checked out: {row["BooksCheckedOut"]}\n");
                AppendNormalText($" - Average per member: {row["AvgPerMember"]}\n\n");
            }

            DataRow metrics = ds.Tables[0].Rows[0];
            AppendNormalText($"NEW MEMBERS: {metrics["NewMembers"]}\n");
            AppendNormalText($"EXPIRED MEMBERSHIPS: {metrics["ExpiredMemberships"]}\n");
            AppendNormalText($"SUSPENDED ACCOUNTS: {metrics["SuspendedAccounts"]}\n\n");
        }

        private void DisplayInventoryStatus(DataSet ds)
        {
            if (ds.Tables.Count < 5) return;

            richTextBox1.Clear();
            AppendBoldText("INVENTORY STATUS REPORT\n");
            AppendNormalText($"Generated: {DateTime.Now:MM/dd/yyyy}\n\n");

            DataRow totals = ds.Tables[0].Rows[0];
            AppendBoldText($"TOTAL BOOKS: {totals["TotalBooks"]:N0}\n");
            AppendNormalText($"Total Available: {totals["TotalAvailable"]:N0}\n");
            AppendNormalText($"Total Checked Out: {totals["TotalCheckedOut"]:N0}\n");
            AppendNormalText($"Total Reserved: {totals["TotalReserved"]:N0}\n");
            AppendNormalText($"Under Maintenance: {totals["UnderMaintenance"]:N0}\n\n");
            AppendNormalText($"Lost Books : {totals["Lost"]:N0}\n");
            AppendNormalText($"Damaged Books : {totals["Damaged"]:N0}\n\n");

            AppendBoldText("STOCK ALERTS:\n");
            AppendBoldText("LOW STOCK (< 20%):\n");
            foreach (DataRow row in ds.Tables[1].Rows)
            {
                AppendNormalText($"- {row["Title"]}: {row["Available"]}/{row["TotalCopies"]} available\n");
            }
            AppendNormalText("\n");

            AppendBoldText("HIGH DEMAND ITEMS:\n");
            int rank = 1;
            foreach (DataRow row in ds.Tables[2].Rows)
            {
                AppendNormalText($"{rank}. {row["Title"]} ({row["Utilization"]}% utilization)\n");
                rank++;
            }
            AppendNormalText("\n");

            AppendBoldText("CATEGORY DISTRIBUTION:\n");
            foreach (DataRow row in ds.Tables[3].Rows)
            {
                AppendNormalText($"{row["CategoryName"]}: {row["BookCount"]} books ({row["Percentage"]}%)\n");
            }
            AppendNormalText("\n");

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
