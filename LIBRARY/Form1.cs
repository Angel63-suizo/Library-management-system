using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Member
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            Browse_Catalog browse = new Browse_Catalog();
            browse.Dock = DockStyle.Fill;

            panelMain.Controls.Add(browse);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            My_Books browse = new My_Books();
            browse.Dock = DockStyle.Fill;

            panelMain.Controls.Add(browse);
        }

        private void btnBorrowingHistory_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            Borrowing_History browse = new Borrowing_History();
            browse.Dock = DockStyle.Fill;

            panelMain.Controls.Add(browse);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            ProfileAccount browse = new ProfileAccount();
            browse.Dock = DockStyle.Fill;

            panelMain.Controls.Add(browse);
        }
    }
}
