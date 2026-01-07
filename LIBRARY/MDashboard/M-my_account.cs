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
        public M_my_account()
        {
            InitializeComponent();

            panel1.Paint += DrawCustomBorder;   // Profile Info Card
            panel6.Paint += DrawCustomBorder;   // Borrowing Summary Card
            panel10.Paint += DrawCustomBorder;  // Fine History Card
            panel12.Paint += DrawCustomBorder;  // Payment Methods Card
            panel13.Paint += DrawCustomBorder;  // Quick Actions Card
            panel14.Paint += DrawCustomBorder;
            panel15.Paint += DrawCustomBorder;  // Settings Card

            // Sub-panels (inner cards)
            panel7.Paint += DrawCustomBorder;   // Current Books sub-card
            panel8.Paint += DrawCustomBorder;   // Outstanding Fines sub-card
            button1.Paint += (s, e) => DrawCustomBorder(s, e);
            button2.Paint += (s, e) => DrawCustomBorder(s, e);
            button3.Paint += (s, e) => DrawCustomBorder(s, e);
            button4.Paint += (s, e) => DrawCustomBorder(s, e);
            button5.Paint += (s, e) => DrawCustomBorder(s, e);
            btnEdit.Paint += (s, e) => DrawCustomBorder(s, e);
        }

        private void DrawCustomBorder(object sender, PaintEventArgs e)
        {
            Control ctrl = (Control)sender;

            int radius = 16;                  // Border corner roundness
            int borderThickness = 1;          // Thickness of the line
            Color borderColor = Color.FromArgb(220, 223, 230); // Soft light gray

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Define the drawing area slightly smaller than the control to prevent clipping
            Rectangle rect = new Rectangle(
                borderThickness,
                borderThickness,
                ctrl.Width - (borderThickness * 4),
                ctrl.Height - (borderThickness * 4)
            );

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
    }
}
