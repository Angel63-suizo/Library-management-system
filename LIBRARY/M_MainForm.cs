using LIBRARY.Models;
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
using LIBRARY.Class;

namespace LIBRARY
{
    public partial class M_MainForm : Form
    {
        private Models.Member LoggedInMember;
        public M_MainForm(Models.Member member)
        {
            InitializeComponent();
            LoggedInMember = member;
        }

        private void M_MainForm_Load(object sender, EventArgs e)
        {
           // LoadUserControl(new M_browse_catalog());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
          //  LoadUserControl(new M_Profile());

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
            LoadUserControl(new M_browse_catalog());

        }

        private void LoadUserControl(UserControl mem)
        {
            pnlContent.Controls.Clear();   
            mem.Dock = DockStyle.Fill;       
            pnlContent.Controls.Add(mem);  
            mem.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMyBooks_Click(object sender, EventArgs e)
        {
            LoadUserControl(new M_my_books());
        }

        private void btnBorrowingHistory_Click(object sender, EventArgs e)
        {
            LoadUserControl(new M_borrowing_history());
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            LoadUserControl(new M_my_account());
        }
    }
}
