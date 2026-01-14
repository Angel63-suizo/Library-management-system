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
    public partial class frmReportModal : Form
    {
        private ucReportPreview ucReportPreviewControl;
        public frmReportModal()
        {
            InitializeComponent();
            InitializeManualControls();
        }

        private void ucReportPreview1_Load(object sender, EventArgs e)
        {

        }

        private void frmReportModal_Load(object sender, EventArgs e)
        {

        }

        public void DisplayReport(DataSet ds, string period, string reportType)
        {
            if (ucReportPreviewControl != null)
            {
                ucReportPreviewControl.SetData(ds, period, reportType);
                ucReportPreviewControl.Invalidate(); 
                this.Refresh();
            }
        }

        private void InitializeManualControls()
        {
            ucReportPreviewControl = new ucReportPreview();

            ucReportPreviewControl.Dock = DockStyle.Fill;

            if (this.pnlContainer != null)
            {
                this.pnlContainer.Controls.Clear(); 
                this.pnlContainer.Controls.Add(ucReportPreviewControl);

                ucReportPreviewControl.Visible = true;
                ucReportPreviewControl.BringToFront();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
