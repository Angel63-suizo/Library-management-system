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

namespace LIBRARY.MDashboard
{
    public partial class frmUpdateProfile : Form
    {
        private MemberType LoggedInMember;
        public frmUpdateProfile(MemberType member)
        {
            InitializeComponent();
            this.LoggedInMember = member;


        }
         private void InitialValue()
        {
            Profile_Repository repo = new Profile_Repository();
            DataRow profileData = repo.GetMemberProfile(LoggedInMember.MemberId);
            if (profileData != null)
            {
                txtFirstName.Text = profileData["FirstName"].ToString();
                txtLastName.Text = profileData["LastName"].ToString();
                txtEmail.Text = profileData["Email"].ToString();
                txtPhone.Text = profileData["Phone"].ToString();
                txtAddress.Text = profileData["Address"].ToString();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string newFName = txtFirstName.Text.Trim();
            string newLName = txtLastName.Text.Trim();
            string newEmail = txtEmail.Text.Trim();
            string newPhone = txtPhone.Text.Trim();
            string newAdress = txtAddress.Text.Trim();

            Profile_Repository repo = new Profile_Repository();
            bool isSuccess = repo.UpdateProfile(LoggedInMember.MemberId, newFName, newLName, newEmail, newPhone, newAdress);

            if (isSuccess)
            {
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Failed to save changes. Please check your database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUpdateProfile_Load(object sender, EventArgs e)
        {
            InitialValue();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();

        }
    }
}
