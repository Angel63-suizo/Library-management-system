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
    public partial class ucBorrowingHistory : UserControl
    {
        public ucBorrowingHistory()
        {
            InitializeComponent();
        }

        public void SetData(DataRow row)
        {
            lblTitle.Text = row["Title"].ToString();
            lblAuthor.Text = row["Author"].ToString();
            lblAccessionNumber.Text = row["BookID"].ToString();
            lblBorrowDate.Text = Convert.ToDateTime(row["BorrowDate"]).ToString("yyyy-MM-dd");
            if (row["ReturnedDate"] != DBNull.Value)
            {
                DateTime returnedDate = Convert.ToDateTime(row["ReturnedDate"]);
                lblReturnedDate.Text = returnedDate.ToString("MMM dd, yyyy");
            }
            else
            {
                lblReturnedDate.Text = "Not Returned Yet";
                lblReturnedDate.ForeColor = Color.Gray;
            }
            decimal fine = row["Fine"] == DBNull.Value ? 0 : Convert.ToDecimal(row["Fine"]);
            lblFine.Text = fine.ToString("C2");

            string status = row["Status"].ToString();
            lblStatus.Text = status;

            if (status == "Returned")
            {
                lblStatus.Text = "● Returned";
                lblStatus.ForeColor = Color.RoyalBlue;
                lblStatus.BackColor = Color.AliceBlue;
            }
            else if (status == "Borrowed")
            {
                lblStatus.Text = "● Borrowed";
                lblStatus.ForeColor = Color.Green;
                lblStatus.BackColor = Color.Honeydew;
            }
        }
    }
}
