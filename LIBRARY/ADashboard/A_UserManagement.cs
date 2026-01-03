using LIBRARY.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace LIBRARY.ADashboard
{
    public partial class A_UserManagement : UserControl
    {

        public A_UserManagement()
        {
            InitializeComponent();
        }

        private void A_UserManagement_Load(object sender, EventArgs e)
        {
            A_GridViewMember myGrid = new A_GridViewMember();
            myGrid.Dock = DockStyle.Fill;

            pnlGridContainer.Controls.Add(myGrid);

            UpdateDashboardLabels();
            Timer refreshTimer = new Timer();
            refreshTimer.Interval = 5000; 
            refreshTimer.Tick += (s, args) => UpdateDashboardLabels();
            refreshTimer.Start();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDashboardLabels()
        {
            A_StatsBox_Repository repo = new A_StatsBox_Repository();
            DataTable dt = repo.GetMemberStats();

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblTotalMembers.Text = row["Total"].ToString();
                lblActive.Text = row["Active"].ToString();
                lblSuspended.Text = row["Suspended"].ToString();
                lblNew.Text = row["NewMonth"].ToString();
            }
        }



        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; 
                return cp;
            }
        }
    }

}
