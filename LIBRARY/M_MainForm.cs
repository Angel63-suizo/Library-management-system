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

namespace LIBRARY
{
    public partial class M_MainForm : Form
    {
        private Member CurrentUser; // Add this field to hold the current member

        public M_MainForm(Member user) // Update constructor to accept a Member
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void M_MainForm_Load(object sender, EventArgs e)
        {
            MDashboard.M_dashboard dashboard = new MDashboard.M_dashboard(CurrentUser);
            this.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;

            if (CurrentUser.AccessLevel == 0)  // Visitor
            {
                btnBorrow.Visible = false;
                btnReserve.Visible = false;
            }

            if (CurrentUser.AccessLevel < 2) // students
            {
                btnReserve.Visible = false;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MDashboard.M_Profile profile = new MDashboard.M_Profile(CurrentUser);
            this.Controls.Add(profile);
            profile.Dock = DockStyle.Fill;
            profile.Show();
            profile.BringToFront();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to logout?", "Question", MessageBoxButtons.YesNo);
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MDashboard.M_dashboard dashboard = new MDashboard.M_dashboard(CurrentUser);
            this.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;
            dashboard.BringToFront();
        }
    }
}
