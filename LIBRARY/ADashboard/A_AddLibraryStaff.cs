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
    public partial class A_AddLibraryStaff : UserControl
    {
        public A_AddLibraryStaff()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            libraryStaff newStaff = new libraryStaff();
            newStaff.Firstname = txtFirstName.Text;
            newStaff.Lastname = txtLastName.Text;
            newStaff.Email = txtEmail.Text;
            newStaff.Password = txtPassword.Text;

            A_AddLibraryStaff_Repository repo = new A_AddLibraryStaff_Repository();
            repo.AddStaff(newStaff);

            MessageBox.Show("Library staff added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Control parentPanel = this.Parent;

            if (parentPanel != null)
            {
                foreach (Control c in parentPanel.Controls)
                {
                    if (c is A_GridViewMember)
                    {
                        c.Enabled = true;
                        break;
                    }
                }

                parentPanel.Controls.Remove(this);
            }
        }
    
    }
}
