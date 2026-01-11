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
        private string _selectedRole = "Member";
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            SetRole("Member");
            btnMember.BackColor = Color.SteelBlue;
            btnMember.ForeColor = Color.White;

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (!ValidateInputs(username, password)) return;

            if (_selectedRole == "Admin")
            {
                HandleAdminLogin(username, password);
            }
            else
            {
                HandleUserLogin(username, password);
            }
        }

        private bool ValidateInputs(string user, string pass)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter all credentials.");
                return false;
            }
            return true;
        }

        private void HandleAdminLogin(string user, string pass)
        {
            string adminUser = ConfigurationManager.AppSettings["AdminUser"];
            string adminPass = ConfigurationManager.AppSettings["AdminPass"];

            if (user == adminUser && pass == adminPass)
            {
                Admin loggedInAdmin = new Admin { Username = adminUser, Role = "Admin" };
                new A_MainForm(loggedInAdmin).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Admin Credentials.");
            }
        }

        private void HandleUserLogin(string user, string pass)
        {
            
            var loggedInUser = Login_Repository.Login(user, pass, _selectedRole);

            if (loggedInUser == null)
            {
                MessageBox.Show("Invalid Username or Password.");
                return;
            }

            if (_selectedRole == "Member" && loggedInUser is MemberType member)
            {
                new M_MainForm(member).Show();
                this.Hide();
            }
            else if (_selectedRole == "Librarian" && loggedInUser is libraryStaff staff)
            {
                new L_MainForm(staff).Show();
                this.Hide();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }


        private void SetRole(string role)
        {
            _selectedRole = role;

            btnMember.BackColor = Color.White;
            btnMember.ForeColor = Color.Black;
            btnStaff.BackColor = Color.White;
            btnStaff.ForeColor = Color.Black;
            btnAdmin.BackColor = Color.White;
            btnAdmin.ForeColor = Color.Black;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            SetRole("Admin");
            btnAdmin.BackColor = Color.SteelBlue;
            btnAdmin.ForeColor = Color.White;

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            SetRole("Librarian");
            btnStaff.BackColor = Color.SteelBlue;
            btnStaff.ForeColor = Color.White;
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            SetRole("Member");
            btnMember.BackColor = Color.SteelBlue;
            btnMember.ForeColor = Color.White;
        }
    }
    
}
