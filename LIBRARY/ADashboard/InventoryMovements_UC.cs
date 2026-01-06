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
    public partial class InventoryMovements_UC : UserControl
    {
        public InventoryMovements_UC(string action, string title, string details, string user, string date)
        {
            InitializeComponent();

            lblAction.Text = action; 
            lblTitle.Text = title;
            lblDetails.Text = details;
            lblUser.Text = user;
            lblDate.Text = date;

       
            if (action == "Addition")
            {
                lblAction.BackColor = Color.FromArgb(232, 250, 241); 
                lblAction.ForeColor = Color.FromArgb(39, 174, 96);  
            }
            else
            {
                lblAction.BackColor = Color.FromArgb(253, 237, 236); 
                lblAction.ForeColor = Color.FromArgb(231, 76, 60);   
            }
        }

        private void pnlInventoryContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
