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
                modal.DisplayReport(ds, period);

                modal.ShowDialog();
            }
            else
            {
                MessageBox.Show("No data found for the selected period.", "Report Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {

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
                sfd.FileName = $"Library_Report_{DateTime.Now:yyyyMMdd}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    reports.ExportToExcel(ds, sfd.FileName);
                    MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
