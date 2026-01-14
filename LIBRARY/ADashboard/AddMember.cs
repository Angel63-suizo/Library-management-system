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
using LIBRARY.Class;
using LIBRARY.Models;

namespace LIBRARY.ADashboard
{
    public partial class AddMember : Form
    {
        private Admin LoggedInAdmin;
        public AddMember(Admin admin)
        {
            InitializeComponent();
            LoggedInAdmin = admin;
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            PopulateComboboxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Models.Member newMember = new Models.Member
            {
                Firstname = txtFirstName.Text,
                Lastname = txtLastName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Address = txtAddress.Text
            };

            string generatedCardNum = LoggedInAdmin.RegisterNewMember(newMember, cmbMemberType.Text, cmbStatus.Text);

            if (!string.IsNullOrEmpty(generatedCardNum))
            {
                MessageBox.Show($"New member added successfully!\n\nLibrary Card Number: {generatedCardNum}",
                                "Registration Complete",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                btnClear_Click(null, null); 
            }
            else
            {
                MessageBox.Show("Failed to add member. Please check if the email is Valid and all fields are filled.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
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

        private void PopulateComboboxes()
        {
            MemberManager repo = new MemberManager();
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

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
