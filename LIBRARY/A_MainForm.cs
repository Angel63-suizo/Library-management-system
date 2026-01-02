using LIBRARY.ADashboard;
using LIBRARY.LDashboard;
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
    public partial class A_MainForm : Form
    {
        private Admin LoggedInAdmin;
        public A_MainForm(Admin admin)
        {
            InitializeComponent();
            LoggedInAdmin = admin;
        }

        private void A_MainForm_Load(object sender, EventArgs e)
        {
            LoadUserControl(new A_dashboard());

        }

        private void LoadUserControl(UserControl mem)
        {
            pnlContent.Controls.Clear();
            mem.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(mem);
            mem.BringToFront();
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

        private void btnUserMng_Click(object sender, EventArgs e)
        {
            LoadUserControl(new A_UserManagement());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new A_dashboard());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            LoadUserControl(new A_Inventory());
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pnlSidebar1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            LoadUserControl(new A_Resources());
        }
    }
}
