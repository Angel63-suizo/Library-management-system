using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LIBRARY.MDashboard
{
    public partial class M_my_books : UserControl
    {

        public M_my_books()
        {
            InitializeComponent();

            panel1.Paint += DrawCustomBorder;
            panel2.Paint += DrawCustomBorder;
            panel3.Paint += DrawCustomBorder;
            panel4.Paint += DrawCustomBorder;

            // For the alert panel (panel5), use a slightly different border color if needed
            panel5.Paint += (s, e) => {
                // You can create a specific color for the warning border here
                DrawCustomBorder(s, e);
            };
        }
        private void M_Profile_Load(object sender, EventArgs e)
        {
           
        }
        private void DrawCustomBorder(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;

            int radius = 16;                 // Matches modern UI cards
            int borderThickness = 1;
            Color borderColor = Color.FromArgb(220, 223, 230); // soft light gray

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                borderThickness,
                borderThickness,
                panel.Width - borderThickness * 4,
                panel.Height - borderThickness * 4
            );

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                panel.Region = new Region(path);

                using (Pen pen = new Pen(borderColor, borderThickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

    }
}

