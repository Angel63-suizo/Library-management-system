using LIBRARY.MDashboard;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.LDashboard
{
    public partial class S_book_lookup : UserControl
    {
        public S_book_lookup()
        {
            InitializeComponent();
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.txtSearch.KeyDown += new KeyEventHandler(this.txtSearch_KeyDown);

            pnlContainerA.Visible = false;
            pnlContainerB.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ExecuteMemberSearch();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteMemberSearch();
                e.SuppressKeyPress = true;
            }
        }

        private void ExecuteMemberSearch()
        {
            string cardNum = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(cardNum))
            {
                MessageBox.Show("Please enter a Member ID.");
                ResetToEmptyState();
                return;
            }

            ShowResults(cardNum);
        }

        private void ShowResults(string cardNum)
        {
            lblMemSearch.Visible = true;
            lblMemSearch.Text = $"Searching for Member: \"{cardNum}\"...";
            lblMemSearch.ForeColor = Color.SteelBlue;

            MemberLookup_Repository repo = new MemberLookup_Repository();

            DataRow memberProfile = repo.GetMemberProfile(cardNum);

            if (memberProfile != null)
            {
                lblFullName.Text = memberProfile["FullName"].ToString();
                lblCardNumber.Text = memberProfile["MemberId"].ToString();
                lblEmail.Text = memberProfile["Email"].ToString();
                lblPhone.Text = memberProfile["Phone"].ToString();
                lblJoinDate.Text = Convert.ToDateTime(memberProfile["CreatedAt"]).ToString("yyyy-MM-dd");

                lblMemberStatus.Text = memberProfile["AccountStatus"].ToString();
                lblMemberType.Text = memberProfile["NameType"].ToString();

                lblBooksBorrowed.Text = $"{memberProfile["BooksBorrowed"]} / {memberProfile["MaxBooksAllowed"]}";
                lblTotalFines.Text = Convert.ToDecimal(memberProfile["TotalFines"]).ToString("C2");

                DataTable borrowedBooks = repo.GetBorrowedBooks(cardNum);
                dgvCurrentBorrow.DataSource = borrowedBooks;

                int currentCount = Convert.ToInt32(memberProfile["BooksBorrowed"]);
                int maxCount = Convert.ToInt32(memberProfile["MaxBooksAllowed"]);

                if (currentCount >= maxCount)
                {
                    lblBooksBorrowed.ForeColor = Color.Red; 
                }

                pnlContainerA.Visible = true;
                pnlContainerB.Visible = true;
                lblMemSearch.Visible = false;
            }
            else
            {
                MessageBox.Show("Member not found in system.");
                ResetToEmptyState();
            }
        }

        private void ResetToEmptyState()
        {
            pictureBox7.Visible = true;
            label10.Visible = true;
            lblMemSearch.Visible = true;
            lblMemSearch.Text = "Enter a Member ID or name to search";
            lblMemSearch.ForeColor = Color.DimGray;
        }

        private void dgvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvCurrentBorrow_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCurrentBorrow.Columns[e.ColumnIndex].Name == "DueDate" && e.Value != null)
            {
                DateTime dueDate = Convert.ToDateTime(e.Value);

                if (dueDate < DateTime.Now.Date)
                {
                    dgvCurrentBorrow.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 230);
                    dgvCurrentBorrow.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else
                {
                    dgvCurrentBorrow.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dgvCurrentBorrow.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void pnlMemberLookup_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
