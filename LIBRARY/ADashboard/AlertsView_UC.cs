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
    }
}
