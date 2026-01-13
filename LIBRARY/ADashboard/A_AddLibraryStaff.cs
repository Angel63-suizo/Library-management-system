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
    public partial class A_AddLibraryStaff : UserControl
    {
        private Admin LoggedInAdmin;
        public A_AddLibraryStaff(Admin admin)
        {
            InitializeComponent();
            LoggedInAdmin = admin;
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
