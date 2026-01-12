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
    public partial class AlertsView_UC : UserControl
    {
        public AlertsView_UC()
        {
            InitializeComponent();
        }

        private void AlertsView_UC_Load(object sender, EventArgs e)
        {
            LoadMovementData();
        }

        public void LoadMovementData()
        {
            GetInventoryGrid_Repository repo = new GetInventoryGrid_Repository();
            DataTable dtMovements = repo.GetRecentMovements();

            pnlInventoryMoveContainer.Controls.Clear(); 

            foreach (DataRow row in dtMovements.Rows)
            {
                InventoryMovements_UC card = new InventoryMovements_UC(
                    row["ActionType"].ToString(),
                    row["Title"].ToString(),
                    row["Details"].ToString(),
                    row["PerformedBy"].ToString(),
                    Convert.ToDateTime(row["MovementDate"]).ToString("yyyy-MM-dd")
                );

                card.Width = pnlInventoryMoveContainer.Width - 25;
                pnlInventoryMoveContainer.Controls.Add(card);
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
