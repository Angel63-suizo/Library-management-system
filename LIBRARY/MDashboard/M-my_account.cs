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

namespace LIBRARY.MDashboard
{
    public partial class M_my_account : UserControl
    {
        private bool isEditing = false;
        private decimal outstandingFine = 500;

        public M_my_account()
        {
            InitializeComponent();
            LoadUserData();
            LoadFineHistory();
        }

        private void DrawCustomBorder(object sender, PaintEventArgs e)
        {
            Control ctrl = (Control)sender;

            int radius = 16;                  // Border corner roundness
            int borderThickness = 1;          // Thickness of the line
            Color borderColor = Color.FromArgb(220, 223, 230); // Soft light gray

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Define the drawing area slightly smaller than the control to prevent clipping
            Rectangle rect = new Rectangle(borderThickness, borderThickness,
                                           ctrl.Width - borderThickness * 2, ctrl.Height - borderThickness * 2);

            using (GraphicsPath path = new GraphicsPath())
            {
                // Create the rounded rectangle path
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                // Set the region so the background color follows the rounded corners
                ctrl.Region = new Region(path);

                // Draw the border line
                using (Pen pen = new Pen(borderColor, borderThickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
        private void LoadUserData()
        {
            label4.Text = "John Smith";
            label5.Text = "john.smith@email.com";
            label22.Text = "555-0101";
            label7.Text = "Member ID: M001";
            label15.Text = "3 / 5";
            label16.Text = "2 slots available";
            label18.Text = $"₱{outstandingFine}";
        }

        private void LoadFineHistory()
        {
            dataGridView1.Rows.Clear();

            dataGridView1.Rows.Add("2024-12-01", "Late return", "₱200", "Paid");
            dataGridView1.Rows.Add("2025-01-03", "Book damage", "₱300", "Unpaid");

            dataGridView1.ClearSelection();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            isEditing = !isEditing;

            label5.BorderStyle = isEditing ? BorderStyle.FixedSingle : BorderStyle.None;
            label22.BorderStyle = isEditing ? BorderStyle.FixedSingle : BorderStyle.None;

            btnEdit.Text = isEditing ? "Save" : "Edit Profile";

            if (!isEditing)
            {
                MessageBox.Show("Profile updated successfully.", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Password change screen goes here.",
        "Change Password",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    );
        }

        private void BtnUpdateContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Contact information updated.",
        "Success",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    );
        }

        private void BtnDownloadReceipt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Receipt downloaded successfully.",
        "Download",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    );
        }

        private void BtnPayNow_Click(object sender, EventArgs e)
        {
            if (outstandingFine <= 0)
            {
                MessageBox.Show("No outstanding fines.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Pay ₱{outstandingFine} now?",
                "Confirm Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                outstandingFine = 0;
                label18.Text = "₱0";
                MessageBox.Show("Payment successful!", "Paid",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Showing full fine history.",
        "Fine History",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    );
        }
    }
}
