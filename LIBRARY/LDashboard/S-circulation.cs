using LIBRARY.Class;
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
    public partial class S_circulation : UserControl
    {
        private User currentUser = null;
        private bool isCheckoutMode = true;
        private List<string> scannedBooks = new List<string>();

        public S_circulation()
        {
            InitializeComponent();
            InitializeEvents();
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
            string idInput = txtBookAccess.Text.Trim();

            if (string.IsNullOrEmpty(idInput)) return;

            if (currentUser != null)
            {
             
                
                label12.ForeColor = Color.ForestGreen;
                label13.Text = "Member validated. You may now scan books.";
                label13.ForeColor = Color.RoyalBlue;

                txtBookAccess.Focus();
            }
            else
            {
                label12.Text = "User not found. Please try again.";
                label12.ForeColor = Color.Red;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                MessageBox.Show("Please load a valid user first.");
                return;
            }

            string bookId = txtBookAccess.Text.Trim();
            if (!string.IsNullOrEmpty(bookId))
            {
                scannedBooks.Add(bookId);
                txtBookAccess.Clear();
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
       
    }
}
