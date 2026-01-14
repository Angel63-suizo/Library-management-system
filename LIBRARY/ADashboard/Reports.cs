using DocumentFormat.OpenXml.Bibliography;
using LIBRARY.Class;
using LIBRARY.Models;
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
    public partial class Reports : UserControl
    {
        private Admin LoggedInAdmin;
        public Reports(Admin admin)
        {
            InitializeComponent();
            LoggedInAdmin = admin;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            ReportsManager reports = new ReportsManager();
            DataSet ds = reports.GenerateReportData(startDate, endDate);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                frmReportModal modal = new frmReportModal();

                string period = $"{dtpStartDate.Value:yyyy-MM-dd} to {dtpEndDate.Value:yyyy-MM-dd}";
                modal.DisplayReport(ds, period, "MonthlyCirculation");

                modal.ShowDialog();
            }
            else
            {
                MessageBox.Show("No data found for the selected period.", "Report Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            SetupCharts();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ReportsManager reports = new ReportsManager();
            DataSet ds = reports.GenerateReportData(dtpStartDate.Value, dtpEndDate.Value);

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No data found to export for the selected period.", "Export Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.FileName = $"Monthly_Circulation_Report{DateTime.Now:yyyyMMdd}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    reports.ExportToExcel(ds, sfd.FileName);
                    MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportsManager reports = new ReportsManager();
            DataSet ds = reports.OverdueReport(dtpStartDate.Value, dtpEndDate.Value);

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No data found to export for the selected period.", "Export Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.FileName = $"Overdue_Book_Report{DateTime.Now:yyyyMMdd}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    reports.ExportOverdueToExcel(ds, sfd.FileName);
                    MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            ReportsManager reports = new ReportsManager();
            DataSet ds = reports.OverdueReport(startDate, endDate);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                frmReportModal modal = new frmReportModal();

                string period = $"{dtpStartDate.Value:yyyy-MM-dd} to {dtpEndDate.Value:yyyy-MM-dd}";
                modal.DisplayReport(ds, period, "Overdue");

                modal.ShowDialog();
            }
            else
            {
                MessageBox.Show("No data found for the selected period.", "Report Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            ReportsManager reports = new ReportsManager();
            DataSet ds = reports.MembersActivityData(startDate, endDate);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                frmReportModal modal = new frmReportModal();

                string period = $"{dtpStartDate.Value:yyyy-MM-dd} to {dtpEndDate.Value:yyyy-MM-dd}";
                modal.DisplayReport(ds, period, "MembersActivity");

                modal.ShowDialog();
            }
            else
            {
                MessageBox.Show("No data found for the selected period.", "Report Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportsManager reports = new ReportsManager();
            DataSet ds = reports.MembersActivityData(dtpStartDate.Value, dtpEndDate.Value);

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No data found to export for the selected period.", "Export Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.FileName = $"Members_Activity_Report{DateTime.Now:yyyyMMdd}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    reports.MembersActivityToExcel(ds, sfd.FileName);
                    MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            ReportsManager reports = new ReportsManager();
            DataSet ds = reports.InventoryStatusData();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                frmReportModal modal = new frmReportModal();

                string period = $"{dtpStartDate.Value:yyyy-MM-dd} to {dtpEndDate.Value:yyyy-MM-dd}";
                modal.DisplayReport(ds, period, "InventoryStatus");

                modal.ShowDialog();
            }
            else
            {
                MessageBox.Show("No data found for the selected period.", "Report Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportsManager reports = new ReportsManager();
            DataSet ds = reports.InventoryStatusData();

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No data found to export for the selected period.", "Export Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.FileName = $"Inventory_Status_Report{DateTime.Now:yyyyMMdd}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    reports.ExportInventoryToExcel(ds, sfd.FileName);
                    MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            
        }

        private void SetupCharts()
        {
            DateTime start = dtpStartDate.Value;
            DateTime end = dtpEndDate.Value;

            ReportsManager repo = new ReportsManager();
            DataTable trendsData = repo.GetCirculationTrends(start, end);

            foreach (var series in chartCirculationTrends.Series)
            {
                series.Points.Clear();
            }

            foreach (DataRow row in trendsData.Rows)
            {
                string month = row["MonthName"].ToString();

                chartCirculationTrends.Series["Checkouts"].Points.AddXY(month, row["Checkouts"]);
                chartCirculationTrends.Series["Returns"].Points.AddXY(month, row["Returns"]);
                chartCirculationTrends.Series["Reservations"].Points.AddXY(month, row["Reservations"]);
            }

            DataTable dt = repo.GetMemberActivityTrends(start, end);

            foreach (var series in chartMemberActivity.Series)
            {
                series.Points.Clear();
            }

            foreach (DataRow row in dt.Rows)
            {
                string month = row["MonthName"].ToString();

                chartMemberActivity.Series["Student"].Points.AddXY(month, row["Students"]);
                chartMemberActivity.Series["Faculty"].Points.AddXY(month, row["Faculty"]);
                chartMemberActivity.Series["Staff"].Points.AddXY(month, row["Staff"]);
            }

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            SetupCharts();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            SetupCharts();
        }
    }
}
