using LIBRARY.Class;
using LIBRARY.MDashboard;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.Login
{
    public partial class Login : Form
    {
        private string selectedRole = "Member";
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
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter all credentials.");
                return;
            }
            else if (selectedRole == null)
            {
                MessageBox.Show("Please chosse your Role.");
            }


            if (selectedRole == "Admin")
            {
                string adminUser = ConfigurationManager.AppSettings["AdminUser"];
                string adminPass = ConfigurationManager.AppSettings["AdminPass"];

                if (username == adminUser && password == adminPass)
                {
                    Admin loggedInAdmin = new Admin()
                    {
                        Username = adminUser,
                        Password = adminPass,
                        Role = "Admin"
                    };

                    A_MainForm mainform = new A_MainForm(loggedInAdmin);
                    mainform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Admin Credentials.");
                }
            }
            else if (selectedRole == "Member")
            {
                var User = Login_Repository.Login(username, password, selectedRole);

                M_MainForm memberform = new M_MainForm((Member)User);
                memberform.Show();
                this.Hide();
            }
            else if (selectedRole == "Librarian")
            {
                var User = Login_Repository.Login(username, password, selectedRole);

                L_MainForm libraryform = new L_MainForm((libraryStaff)User);
                libraryform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error: Unauthorized role or role not defined.");
            }
        }


        private void lblSignup_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Register.register signup = new Register.register();
            signup.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            selectedRole = "Librarian";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            selectedRole = "Admin";
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            selectedRole = "Member";
        }

    }
    
}
