using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.ADashboard
{
    public partial class EditMembers : Form
    {
        private string _cardNumber;
        public EditMembers(string cardNumber)
        {
            InitializeComponent();
            _cardNumber = cardNumber;
            LoadInitialMemberData();
        }

        private void EditMembers_Load(object sender, EventArgs e)
        {
            PopulateComboboxes();
        }

        private void PopulateComboboxes()
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

        private void LoadInitialMemberData()
        {
            Update_Repository repo = new Update_Repository();
            DataRow member = repo.GetMemberDetails2(_cardNumber);

            if (member != null)
            {
                lblMemberID.Text = member["CardNumber"].ToString();
                txtFirstName.Text = member["FirstName"].ToString();
                txtLastName.Text = member["FirstName"].ToString();
                txtEmail.Text = member["Email"].ToString();
                txtPhone.Text = member["Phone"].ToString();
                cmbMemberType.Text = member["MemberType"].ToString();
                txtAddress.Text = member["Address"].ToString();
                cmbStatus.Text = member["Status"].ToString();
            }
            else
            {
                MessageBox.Show("Member data not found.");
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Models.Member updatedMember = new Models.Member
            {
                Cardnumber = _cardNumber,
                Firstname = txtFirstName.Text,
                Lastname = txtLastName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text
            };

            Update_Repository repo = new Update_Repository();
            if (repo.UpdateMember(updatedMember, cmbMemberType.Text, cmbStatus.Text))
            {
                MessageBox.Show("Update Successful!");
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
        }
        private void DrawCustomBorder(object sender, PaintEventArgs e)
        {
            Control ctrl = (Control)sender;

            int radius = 16;
            int borderThickness = 1;
            Color borderColor = Color.FromArgb(220, 223, 230);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(borderThickness, borderThickness,
                                           ctrl.Width - borderThickness * 2, ctrl.Height - borderThickness * 2);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                ctrl.Region = new Region(path);

                using (Pen pen = new Pen(borderColor, borderThickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
