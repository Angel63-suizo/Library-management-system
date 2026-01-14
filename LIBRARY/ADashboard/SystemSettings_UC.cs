using LIBRARY.Class;
using LIBRARY.Models;
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
    public partial class SystemSettings_UC : UserControl
    {
        private Admin LoggedInAdmin;
        public SystemSettings_UC(Admin admin)
        {
            InitializeComponent();
            LoggedInAdmin = admin;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SystemSettings repo = new SystemSettings();
            bool allSuccess = true;

            allSuccess &= repo.UpdateMemberTypeLimits(1, (int)nudStudentMaxBooks.Value, (int)nudBorrowingPeriod.Value);

            allSuccess &= repo.UpdateMemberTypeLimits(2, (int)nudFacultyMaxBooks.Value, (int)numericUpDown1.Value);

            allSuccess &= repo.UpdateMemberTypeLimits(3, (int)nudStaffMaxBooks.Value, (int)nudStaffBorrowingPeriod.Value);

            if (allSuccess)
            {
                MessageBox.Show("All member type limits updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadCurrentMemberLimits()
        {
            SystemSettings repo = new SystemSettings();
            DataTable dt = repo.FetchCurrentLimits();

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["MemberTypeID"]);
                int max = Convert.ToInt32(row["MaxBooksAllowed"]);
                int days = Convert.ToInt32(row["BorrowingPeriodDays"]);

                if (id == 1) { nudStudentMaxBooks.Value = max; nudBorrowingPeriod.Value = days; }
                else if (id == 2) { nudFacultyMaxBooks.Value = max; numericUpDown1.Value = days; }
                else if (id == 3) { nudStaffMaxBooks.Value = max; nudStaffBorrowingPeriod.Value = days; }
            }
        }

        private void SystemSettings_UC_Load(object sender, EventArgs e)
        {
            LoadCurrentMemberLimits();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newCategory = txtCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(newCategory))
            {
                MessageBox.Show("Please enter a category name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SystemSettings repo = new SystemSettings();
            if (repo.AddCategory(newCategory))
            {
                MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategoryName.Clear();
            }
        }
    }
}
