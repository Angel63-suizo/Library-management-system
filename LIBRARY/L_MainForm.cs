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

            LDashboard.L_dashboard dash = new LDashboard.L_dashboard(CurrentUser);
            this.Controls.Add(dash);
            dash.Dock = DockStyle.Fill;
     
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
        
           switch (MessageBox.Show("Are you sure you want to logout?", "Question", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    this.Close();
                    break;
                case DialogResult.No:
                    return;
            }
            

        }
    }
}
