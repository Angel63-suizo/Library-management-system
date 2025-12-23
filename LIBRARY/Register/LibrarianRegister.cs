using LIBRARY.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.Register
{
    public partial class LibrarianRegister : Form
    {
        
        public LibrarianRegister()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtConfirm.PasswordChar = '*';
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
        }

        private void LibrarianRegister_Load(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
            txtConfirm.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Login.Login log = new Login.Login();
            log.Show();
            this.Hide();
        }
    }
}
