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

namespace LIBRARY.ADashboard
{
    public partial class A_UserManagement : UserControl
    {

        public A_UserManagement()
        {
            InitializeComponent();
        }

        private void A_UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            A_AddMember add = new A_AddMember();
            add.Show();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
