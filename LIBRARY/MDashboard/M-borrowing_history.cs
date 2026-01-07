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
    public partial class M_borrowing_history : UserControl
    {

        public M_borrowing_history()
        {
            InitializeComponent();

            // 2. Attach Paint Events for all panels
            panel1.Paint += DrawCustomBorder;
            panel2.Paint += DrawCustomBorder;
            panel3.Paint += DrawCustomBorder;
            panel4.Paint += DrawCustomBorder;
            panel5.Paint += DrawCustomBorder; // Outer container for search
            panel7.Paint += DrawCustomBorder; // Inner search box border
            panel8.Paint += DrawCustomBorder; // DataGrid container

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
