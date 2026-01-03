using LIBRARY.Class;
using System;
using System.Data;
using System.Windows.Forms;

namespace LIBRARY.ADashboard
{
    public partial class A_AddMember : UserControl
    {

        public A_AddMember()
        {
            InitializeComponent();

        }

        private void A_AddMember_Load(object sender, EventArgs e)
        {
            A_AddMember_Repository repo = new A_AddMember_Repository();
            try
            {
                DataTable dt = repo.GetMemberType();
                cmbMemberType.DataSource = dt;
                cmbMemberType.DisplayMember = "NameType";
                cmbMemberType.ValueMember = "MemberTypeID";
                cmbMemberType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading member types: " + ex.Message);
            }

            cmbStatus.DataSource = repo.GetStatus("Member", "Status");
            cmbStatus.SelectedItem = "Active";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Member newMember = new Member();
            newMember.Firstname = txtFirstName.Text;
            newMember.Lastname = txtLastName.Text;
            newMember.Email = txtEmail.Text;
            newMember.Password = txtPassword.Text;
            newMember.Address = txtAddress.Text;

            A_AddMember_Repository repo = new A_AddMember_Repository();
            repo.AddNewMember(newMember, cmbMemberType.Text, cmbStatus.Text);

            MessageBox.Show("New member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtAddress.Clear();
            cmbMemberType.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
        }
    }
}
