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
    public partial class AlertsView_UC : UserControl
    {
        public AlertsView_UC()
        {
            InitializeComponent();
        }

        private void AlertsView_UC_Load(object sender, EventArgs e)
        {
            StockAlert_UC stockgrid = new StockAlert_UC();
            stockgrid.Dock = DockStyle.Fill;

            pnlStockAlertContainer.Controls.Add(stockgrid);

            InventoryMovements_UC inventgrid = new InventoryMovements_UC();
            inventgrid.Dock = DockStyle.Fill;

            pnlInventroryMoveContainer.Controls.Add(inventgrid);
        }
    }
}
