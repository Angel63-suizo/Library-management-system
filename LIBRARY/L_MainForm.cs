using LIBRARY.ADashboard;
using LIBRARY.Class;
using LIBRARY.LDashboard;
using LIBRARY.MDashboard;
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
    public partial class L_MainForm : Form
    {
        private libraryStaff LoggedInStaff;
        public L_MainForm(libraryStaff staff)
        {
            InitializeComponent();
            LoggedInStaff = staff;
        }

        private void L_MainForm_Load(object sender, EventArgs e)
        {

            LoadUserControl(new S_circulation());

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

        private void LoadUserControl(UserControl mem)
        {
            pnlContent.Controls.Clear();
            mem.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(mem);
            mem.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new S_circulation());
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            LoadUserControl(new S_book_lookup());
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            LoadUserControl(new S_book_search());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadUserControl(new S_reports());
        }

        private void pnlSidebar1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
