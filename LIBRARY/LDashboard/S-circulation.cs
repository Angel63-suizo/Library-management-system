using LIBRARY.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LIBRARY.LDashboard
{
    public partial class S_circulation : UserControl
    {
        private Models.Member currentUser = null;
        private bool isCheckoutMode = true;
        private List<string> scannedBooks = new List<string>();

        public S_circulation()
        {
            InitializeComponent();
            InitializeEvents();

            pnlContainer1.Visible = false;
        }

        private void InitializeEvents()
        {
            btnLoadMember.Click += btnLoadMember_Click;
            btnAddBook.Click += btnAddBook_Click;
            btnCheckout.Click += (s, e) => SetMode(true);  
            btnReturn.Click += (s, e) => SetMode(false);
        }

        private void btnLoadMember_Click(object sender, EventArgs e)
        {
            string cardNum = txtSearch.Text.Trim();
            GetMember_Repository repo = new GetMember_Repository();
            DataRow row = repo.GetMemberProfile(cardNum);

            if (row != null)
            {
                this.SetMemberData(row);
                pnlContainer1.Visible = true;

                currentUser = new Models.Member();
                currentUser.Cardnumber = row["CardNumber"].ToString();
            }
            else
            {
                MessageBox.Show("Member not found.");
                pnlContainer1.Visible = false;
                currentUser = null;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                MessageBox.Show("Please load a valid user first.");
                return;
            }

            string bookId = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(bookId))
            {
                scannedBooks.Add(bookId);
                txtSearch.Clear();
                UpdateTransactionList();
            }
        }

        private void UpdateTransactionList()
        {
            if (scannedBooks.Count > 0)
            {
                label19.Text = $"{scannedBooks.Count} Item(s) ready for {(isCheckoutMode ? "Checkout" : "Return")}";
                label18.Text = "Click 'Process' to finalize.";
                pictureBox13.Visible = false; 
            }
            else
            {
                label19.Text = "No items scanned yet";
                label18.Text = "Scan book barcodes to begin";
                pictureBox13.Visible = true; 
            }
        }

        private void SetMode(bool checkout)
        {
            isCheckoutMode = checkout;
            label17.Text = checkout ? "Checking Out Books" : "Returning Books";
            panel8.BackColor = checkout ? Color.Azure : Color.Azure;
            btnCheckout.BackColor = checkout ? Color.SlateGray : Color.White;
            btnCheckout.ForeColor = checkout ? Color.White : Color.Black;
            btnCheckout.FlatAppearance.BorderColor = checkout ? Color.SlateGray : Color.White;
            btnReturn.BackColor = checkout ? Color.White : Color.SlateGray;
            btnReturn.ForeColor = checkout ? Color.Black : Color.White;
            btnReturn.FlatAppearance.BorderColor = checkout ? Color.White : Color.SlateGray;
            pictureBox9.Image = checkout ? Properties.Resources.check : Properties.Resources.ret;
        }

        public void SetMemberData(DataRow row)
        {
            if (row == null) return;

            lblFullName.Text = row["MemberFullName"].ToString();
            lblMemberType.Text = row["Role"].ToString();
            lblCardNumber.Text = "ID: " + row["CardNumber"].ToString();

            string photoPath = row["PhotoPath"].ToString();
            if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
            {
                pbProfile.Image = Image.FromFile(photoPath);
            }
            else
            {
                pbProfile.Image = null; 
            }

            string status = row["AccountStatus"].ToString();
            lblStatus.Text = status;

            if (status == "Active")
            {
                pnlStatusContainer.BackColor = Color.FromArgb(212, 247, 224); 
                lblStatus.ForeColor = Color.DarkGreen;
            }
            else
            {
                pnlStatusContainer.BackColor = Color.FromArgb(255, 204, 204); 
                lblStatus.ForeColor = Color.DarkRed;
            }

            lblBooksBorrowed.Text = $"{row["BooksBorrowed"]} / {row["MaxBorrowLimit"]}";

            decimal fines = Convert.ToDecimal(row["UnpaidFines"]);
            lblUnpaidFines.Text = fines.ToString("C2");
        }

    }
}
