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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            Register.LibrarianRegister libreg = new Register.LibrarianRegister();
            libreg.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register.register regform = new Register.register();
            regform.Show();
            this.Hide();
        }

        private void btnogin_Click(object sender, EventArgs e)
        {
            Login.Login loginform = new Login.Login();
            loginform.Show();
            this.Hide();
        }
    }
}
