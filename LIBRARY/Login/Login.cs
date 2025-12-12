using LIBRARY.Class;
using LIBRARY.MDashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            var user = Login_Repository.Login(txtUsername.Text, txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password");
                return;
            }
            else
            {
                Session.Start(user);

                switch (user.Role)
                {
                    case "Member":
                        new M_MainForm((Member)user).Show();
                        this.Hide();
                        break;

                    case "Librarian":
                        new L_MainForm((Librarian)user).Show();
                        this.Hide();
                        break;

                    default:
                        MessageBox.Show("Error: User Role is not Defined");
                        break;
                }
            }
        }
           


     
        private void lblSignup_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Register.register signup = new Register.register();
            signup.Show();
            this.Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
