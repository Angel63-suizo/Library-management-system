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
        private Librarian CurrentUser;
        public L_MainForm(Librarian user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void L_MainForm_Load(object sender, EventArgs e)
        {
            /*if (Session.Role != "Librarian")
            {
                MessageBox.Show("You do not have permission to access this page.");
                this.Close();
            }*/

            LoadUserControl(new L_dashboard(CurrentUser));

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
    }
}
