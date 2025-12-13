using LIBRARY.Class;
using LIBRARY.MDashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
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
            LoadUserControl(new M_dashboard(CurrentUser));

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
            LoadUserControl(new M_Profile(CurrentUser));

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure you want to logout?", "Question", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    this.Hide();
                    new Login.Login().Show();
                    break;
                case DialogResult.No:
                    return;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new M_dashboard(CurrentUser));

        }

        private void LoadUserControl(UserControl mem)
        {
            pnlContent.Controls.Clear();   
            mem.Dock = DockStyle.Fill;       
            pnlContent.Controls.Add(mem);  
            mem.BringToFront();
        }
    }
}
