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
            SetActiveButton(btnDashboard);
            LoadUserControl(new A_dashboard(LoggedInAdmin));
          
        }
         private void LoadUserControl(UserControl mem)
          {
            pnlContent.SuspendLayout();

            if (pnlContent.Controls.Count > 0)
            {
                pnlContent.Controls[0].Dispose();
                pnlContent.Controls.Clear();
            }
            mem.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(mem);

            pnlContent.ResumeLayout(true);
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
            SetActiveButton((Button)sender);
            LoadUserControl(new A_UserManagement(LoggedInAdmin));
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            LoadUserControl(new A_dashboard(LoggedInAdmin));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            LoadUserControl(new A_Inventory(LoggedInAdmin));
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
            SetActiveButton((Button)sender);
            LoadUserControl(new A_Resources(LoggedInAdmin));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            LoadUserControl(new SystemSettings_UC(LoggedInAdmin));
        }

        private void SetActiveButton(Button clickedButton)
        {

            Color borderColor = Color.White;

            foreach (Control ctrl in pnlSidebar1.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }

            clickedButton.FlatStyle = FlatStyle.Flat;
            clickedButton.FlatAppearance.BorderSize = 1;
            clickedButton.FlatAppearance.BorderColor = borderColor;
        }

        private void btnCirculation_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Reports(LoggedInAdmin));
            SetActiveButton((Button)sender);
        }
    }
}
