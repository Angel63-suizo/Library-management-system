using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBRARY.Class;

namespace LIBRARY.MDashboard
{
    public partial class frmChangePassword : Form
    {
        private MemberType LoggedInMember;
        public frmChangePassword(MemberType member)
        {
            InitializeComponent();
            this.LoggedInMember = member;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string current = txtCurrentPassword.Text;
            string newPwd = txtNewPassword.Text;
            string confirm = txtConfirmPassword.Text;

            if (newPwd.Length < 8)
            {
                MessageBox.Show("New password must be at least 8 characters long.");
                return;
            }

            if (newPwd != confirm)
            {
                MessageBox.Show("New passwords do not match.");
                return;
            }

            Profile_Repository repo = new Profile_Repository();
            int result = repo.ChangePassword(LoggedInMember.MemberId, current, newPwd);

            if (result == 1)
            {
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (result == 0)
            {
                MessageBox.Show("Incorrect current password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtCurrentPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
            txtNewPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
            txtConfirmPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
