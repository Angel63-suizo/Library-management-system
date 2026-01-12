using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.MDashboard
{
    public partial class ucBorrowedBook : UserControl
    {
        public ucBorrowedBook()
        {
            InitializeComponent();
        }

        private void ucBorrowedBook_Load(object sender, EventArgs e)
        {

        }

        public void SetData(DataRow row)
        {
            lblTitle.Text = row["Title"].ToString();
            lblAuthor.Text = row["Author"].ToString();
            lblAccessionNumber.Text = row["BookID"].ToString();
            lblBorrowDate.Text = Convert.ToDateTime(row["BorrowDate"]).ToString("yyyy-MM-dd");
            lblDueDate.Text = Convert.ToDateTime(row["DueDate"]).ToString("yyyy-MM-dd");
            lblFine.Text = $"${Convert.ToDecimal(row["Fine"]):N2}";

            string status = row["CopyStatus"].ToString();
            lblStatus.Text = status;

            if (status == "Overdue") 
            {
                lblStatus.Text = "● Overdue";
                lblStatus.ForeColor = Color.Red;
                lblStatus.BackColor = Color.MistyRose;
            }
            else if (status == "Due Soon")
            {
                lblStatus.Text = "● Due Soon";
                lblStatus.ForeColor = Color.Goldenrod;
                lblStatus.BackColor = Color.LightYellow;
            }
            else
            {
                lblStatus.Text = "● Borrowed";
                lblStatus.ForeColor = Color.Green;
                lblStatus.BackColor = Color.Honeydew;
            }
        }
    }
}
