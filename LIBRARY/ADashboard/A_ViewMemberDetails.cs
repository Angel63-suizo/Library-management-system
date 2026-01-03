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
    public partial class A_ViewMemberDetails : UserControl
    {
        private DataRow _memberData;
        private DataTable _transactionHistory;
        public A_ViewMemberDetails(DataRow memberData)
        {
            InitializeComponent();
            _memberData = memberData;
           // _transactionHistory = transactionHistory;

            LoadMemberProfile();
            //LoadHistoryGrid();

        }

        private void LoadMemberProfile()
        {
            lblFullName.Text = $"{_memberData["FirstName"]} {_memberData["LastName"]}";
            lblCardNumber.Text = _memberData["CardNumber"].ToString();
            lblEmail.Text = _memberData["Email"].ToString();
            lblPhone.Text = _memberData["Phone"].ToString();
            lblAddress.Text = _memberData["Address"].ToString();

            lblStatus.Text = _memberData["Status"].ToString();
            lblMemberType.Text = _memberData["MemberType"].ToString();

            lblRegistrationDate.Text = Convert.ToDateTime(_memberData["JoinDate"]).ToString("yyyy-MM-dd");
            lblExpirationDate.Text = Convert.ToDateTime(_memberData["ExpiryDate"]).ToString("yyyy-MM-dd");
            lblBooksOut.Text = $"{_memberData["BooksCheckedOut"]} / {_memberData["MaxBooksAllowed"]}";

            decimal fines = Convert.ToDecimal(_memberData["TotalFines"]);
            lblTotalFines.Text = fines.ToString("C2");
            lblTotalFines.ForeColor = fines > 0 ? Color.Red : Color.Green;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Control parent = this.Parent;
            if (parent != null)
            {
                if (parent is Form f) f.Close();

                foreach (Control c in parent.Controls)
                {
                    if (c is A_GridViewMember grid) grid.Enabled = true;
                }
                parent.Controls.Remove(this);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /*   private void LoadHistoryGrid()
           {
               dgvHistory.DataSource = _transactionHistory;
               dgvHistory.AutoGenerateColumns = false;

               dgvHistory.Columns["Type"].DataPropertyName = "TransactionType";
               dgvHistory.Columns["Title"].DataPropertyName = "BookTitle";
               dgvHistory.Columns["Date"].DataPropertyName = "TransactionDate";
           }

           private void dgvHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
           {
               if (dgvHistory.Columns[e.ColumnIndex].Name == "Type" && e.Value != null)
               {
                   string type = e.Value.ToString();
                   if (type == "Checkout") e.CellStyle.ForeColor = Color.Blue;
                   else if (type == "Return") e.CellStyle.ForeColor = Color.Green;
                   else if (type == "Fine Payment") e.CellStyle.ForeColor = Color.Purple;
               }*/

    }
}
