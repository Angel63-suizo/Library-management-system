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
        private bool isSearchFocused = false;
        private bool isPanel7Hovered = false;
        private bool isComboFocused = false;

        public M_borrowing_history()
        {
            InitializeComponent();

            txtSearch.Enter += (s, e) =>
            {
                isSearchFocused = true;
                panel7.Invalidate();
            };

            txtSearch.Leave += (s, e) =>
            {
                isSearchFocused = false;
                panel7.Invalidate();
            };

            cmbSearch.Enter += (s, e) =>
            {
                isSearchFocused = true;
                isComboFocused = true;
                panel20.Invalidate();
            };

            cmbSearch.Leave += (s, e) =>
            {
                isSearchFocused = false;
                isComboFocused = false;
                panel7.Invalidate();
            };
        }

        private void DrawCustomBorder(object sender, PaintEventArgs e)
        {

            Panel panel = (Panel)sender;
            int radius = 16;
            int borderThickness = 1;
            Color borderColor = Color.FromArgb(220, 223, 230);

            if (panel.Name == "panel7" && (isPanel7Hovered || isSearchFocused))
            {
                borderColor = Color.FromArgb(55, 65, 81);
                borderThickness = 2;
            }

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(borderThickness, borderThickness,
                                           panel.Width - borderThickness * 2, panel.Height - borderThickness * 2);

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

        private void pnlCombo_Paint(object sender, PaintEventArgs e)
        {
            Color borderIdle = Color.LightGray;
            Color borderActive = Color.FromArgb(64, 64, 64);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(pnlCombo.Focused ? borderActive : borderIdle, 1))
            {
                Rectangle rect = pnlCombo.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
    }
}
