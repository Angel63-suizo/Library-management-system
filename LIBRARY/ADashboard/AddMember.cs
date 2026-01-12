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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            PopulateComboboxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Models.Member newMember = new Models.Member();
            newMember.Firstname = txtFirstName.Text;
            newMember.Lastname = txtLastName.Text;
            newMember.Email = txtEmail.Text;
            newMember.Password = txtPassword.Text;
            newMember.Address = txtAddress.Text;

            A_AddMember_Repository repo = new A_AddMember_Repository();
            repo.AddNewMember(newMember, cmbMemberType.Text, cmbStatus.Text);

            MessageBox.Show("New member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
