using K4os.Compression.LZ4.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.ADashboard
{
    public partial class A_Inventory : UserControl
    {
        public A_Inventory()
        {
            InitializeComponent();
        }

        private void A_Inventory_Load(object sender, EventArgs e)
        {
            LoadUserControl(new AlertsView_UC());
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
            LoadUserControl(new AlertsView_UC());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new FullInventory_UC());
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
