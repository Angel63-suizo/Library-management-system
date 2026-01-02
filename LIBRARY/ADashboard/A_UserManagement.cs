using LIBRARY.Class;
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
    public partial class A_UserManagement : UserControl
    {

        public A_UserManagement()
        {
            InitializeComponent();
        }

        private void A_UserManagement_Load(object sender, EventArgs e)
        {
            PopulateFilters();
            PopulateMemberType();
            RefreshGrid();
            
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            A_AddMember add = new A_AddMember();
            Control parentpanel = this.Parent;

            if(parentpanel != null)
            {
                parentpanel.Controls.Add(add);
                add.BringToFront();
                add .Left = (parentpanel.Width - add.Width) / 2;
                add.Top = (parentpanel.Height - add.Height) / 2;

                this.Enabled = false;
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLibraryStaff_Click(object sender, EventArgs e)
        {
            A_AddLibraryStaff add = new A_AddLibraryStaff();
            Control parentpanel = this.Parent;

            if (parentpanel != null)
            {
                parentpanel.Controls.Add(add);
                add.BringToFront();
                add.Left = (parentpanel.Width - add.Width) / 2;
                add.Top = (parentpanel.Height - add.Height) / 2;

                this.Enabled = false;
            }
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

        private void RefreshGrid()
        {
            A_MemberGrid_Repository repo = new A_MemberGrid_Repository();
            DataTable dt = repo.GetMemberGrid(txtSearch.Text, cmbMemberType.Text, cmbStatus.Text);
            dgvMemberGrid.AutoGenerateColumns = false;

            dgvMemberGrid.DataSource = dt;

        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbMemberType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void PopulateFilters()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("All Status");
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Suspended");
            cmbStatus.Items.Add("Expired");
            cmbStatus.SelectedIndex = 0;
        }

        private void PopulateMemberType()
        {
            A_AddMember_Repository repo = new A_AddMember_Repository();
            DataTable types = repo.GetMemberType();
            cmbMemberType.Items.Clear();
            cmbMemberType.Items.Add("All Types");
            
            if (types != null)
            {
               foreach (DataRow row in types.Rows)
                {
                    cmbMemberType.Items.Add(row["NameType"].ToString());
                }
            }
            cmbMemberType.SelectedIndex = 0;
        }
    }
}
