using K4os.Compression.LZ4.Internal;
using LIBRARY.Class;
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
    public partial class A_Inventory : UserControl
    {
        private Admin LoggedInAdmin;
        public A_Inventory(Admin admin)
        {
            InitializeComponent();
            LoggedInAdmin = admin;
        }

        private void A_Inventory_Load(object sender, EventArgs e)
        {
            LoadUserControl(new AlertsView_UC(LoggedInAdmin));
        }

        private void LoadUserControl(UserControl mem)
        {
            pnlInventroryContainer.SuspendLayout();

            if (pnlInventroryContainer.Controls.Count > 0)
            {
                pnlInventroryContainer.Controls[0].Dispose();
                pnlInventroryContainer.Controls.Clear();
            }
            mem.Dock = DockStyle.Fill;
            pnlInventroryContainer.Controls.Add(mem);

            pnlInventroryContainer.ResumeLayout(true);

            UpdateInventoryLabels();
            Timer refreshTimer = new Timer();
            refreshTimer.Interval = 5000;
            refreshTimer.Tick += (s, args) => UpdateInventoryLabels();
            refreshTimer.Start();
        }

        private void UpdateInventoryLabels()
        {
            A_StatsBox_Repository repo = new A_StatsBox_Repository();
            DataTable dt = repo.GetInventoryStats();

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblTotalInventory.Text = row["TotalInventory"].ToString();
                lblLowStock.Text = row["LowStockItems"].ToString();
                lblOutOfStock.Text = row["OutOfStocks"].ToString();
                lblCategories.Text = row["TotalCategories"].ToString();
            }
        }
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnAlertsView_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AlertsView_UC(LoggedInAdmin));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new FullInventory_UC(LoggedInAdmin));
        }

        private void label7_Click(object sender, EventArgs e)
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
    }
}
