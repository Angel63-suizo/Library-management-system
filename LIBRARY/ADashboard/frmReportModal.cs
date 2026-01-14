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
        public frmReportModal()
        {
            InitializeComponent();
        }

        private void ucReportPreview1_Load(object sender, EventArgs e)
        {

        }

        private void frmReportModal_Load(object sender, EventArgs e)
        {

        }

        public void DisplayReport(DataSet ds, string period)
        {
            ucReportPreview1.LoadData(ds, period);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
