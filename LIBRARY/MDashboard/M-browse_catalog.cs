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
    public partial class M_browse_catalog : UserControl
    {
        private readonly Color colorNormal = Color.White;
        private readonly Color colorHover = Color.FromArgb(249, 250, 251); // Lighter gray
        private readonly Color colorPressed = Color.FromArgb(229, 231, 235);
        private bool isSearchFocused = false;
        private bool isPanel20Hovered = false;
        public M_browse_catalog()
        {
            InitializeComponent();

            panel1.Paint += DrawCustomBorder;
            panel3.Paint += DrawCustomBorder;
            panel4.Paint += DrawCustomBorder;
            panel5.Paint += DrawCustomBorder;
            panel6.Paint += DrawCustomBorder;
            panel7.Paint += DrawCustomBorder;
            panel8.Paint += DrawCustomBorder;
            panel19.Paint += DrawCustomBorder;
            BookDetailsControl.Paint += DrawCustomBorder;

            panel20.Paint += DrawCustomBorder;

            // 1. HOVER LOGIC
            panel20.MouseEnter += (s, e) => { isPanel20Hovered = true; panel20.Invalidate(); };
            panel20.MouseLeave += (s, e) => { isPanel20Hovered = false; panel20.Invalidate(); };
            cmbCategory.MouseEnter += (s, e) => { isPanel20Hovered = true; panel20.Invalidate(); };
            cmbCategory.MouseLeave += (s, e) => { isPanel20Hovered = false; panel20.Invalidate(); };

            // 2. FOCUS/PRESSED LOGIC (Stays dark while active)
            txtSearch.Enter += (s, e) => { isSearchFocused = true; panel20.Invalidate(); };
            txtSearch.Leave += (s, e) => { isSearchFocused = false; panel20.Invalidate(); };
            cmbCategory.Enter += (s, e) => { isSearchFocused = true; panel20.Invalidate(); };
            cmbCategory.Leave += (s, e) => { isSearchFocused = false; panel20.Invalidate(); };

            // Existing panels...
            panel1.Paint += DrawCustomBorder;
        }

        private void DrawCustomBorder(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            int radius = 16;
            int borderThickness = 1;

            // FIGMA COLORS
            Color colorLightGray = Color.FromArgb(220, 223, 230); // Normal
            Color colorDarkGray = Color.FromArgb(55, 65, 81);    // Hover/Pressed (Darker)

            Color borderColor = colorLightGray;

            // Apply darker border if hovered OR focused
            if (panel.Name == "panel20")
            {
                if (isPanel20Hovered || isSearchFocused)
                {
                    borderColor = colorDarkGray;
                    borderThickness = 2;
                }
            }

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(
                borderThickness,
                borderThickness,
                panel.Width - (borderThickness * 2),
                panel.Height - (borderThickness * 2)
            );

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                using (SolidBrush brush = new SolidBrush(panel.BackColor))
                    e.Graphics.FillPath(brush, path);

                panel.Region = new Region(path);

                using (Pen pen = new Pen(borderColor, borderThickness))
                    e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
