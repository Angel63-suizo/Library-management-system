using LIBRARY.Class;
using LIBRARY.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LIBRARY.LDashboard.BorrowingTransaction_Repository;

namespace LIBRARY.LDashboard
{
    public partial class S_circulation : UserControl
    {
        private libraryStaff LoggedInStaff;

        private MemberType currentUser = null;
        private bool isCheckoutMode = true;
        private List<string> scannedBooks = new List<string>();

        public S_circulation(libraryStaff staff)
        {
            InitializeComponent();
            InitializeEvents();
            LoggedInStaff = staff;

            pnlContainer1.Visible = false;
            pnlContentStatus.Visible = false;
            dgvTransaction.Visible = false;
            btnAddBook.Enabled = false;
        }

        private void InitializeEvents()
        {
            btnLoadMember.Click -= btnLoadMember_Click;
            btnLoadMember.Click += btnLoadMember_Click;

            btnAddBook.Click -= btnAddBook_Click;
            btnAddBook.Click += btnAddBook_Click;

            btnCheckout.Click += (s, e) => SetMode(true);  
            btnReturn.Click += (s, e) => SetMode(false);

            dgvTransaction.CellContentClick += dgvTransaction_CellContentClick;
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
                btnAddBook.Enabled = true;
                btnAddBook.BackColor = Color.SlateGray;

                currentUser = new MemberType();
                currentUser.Cardnumber = row["CardNumber"].ToString();
                currentUser.BorrowingPeriodDays = Convert.ToInt32(row["BorrowingPeriodDays"]);

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

            int alreadyBorrowed = int.Parse(lblBooksBorrowed.Text.Split('/')[0].Trim());

            int itemsInGrid = dgvTransaction.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);

            int maxLimit = int.Parse(lblBooksBorrowed.Text.Split('/')[1].Trim());

            if (isCheckoutMode)
            {
                if ((alreadyBorrowed + itemsInGrid) >= maxLimit)
                {
                    MessageBox.Show($"Limit Reached! This member can only borrow a maximum of {maxLimit} books.\n" +
                                    $"Currently borrowed: {alreadyBorrowed}\n" +
                                    $"In current list: {itemsInGrid}",
                                    "Borrowing Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string bookId = txtSearch2.Text.Trim();
            GetBook_Repository bookRepo = new GetBook_Repository();
            DataRow bookRow = bookRepo.GetBookCopy(bookId);

            if (bookRow != null)
            {

                string bookStatus = bookRow["Status"].ToString();

                if (isCheckoutMode && bookStatus != "Available")
                {
                    MessageBox.Show($"Cannot checkout: Book is currently '{bookStatus}'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!isCheckoutMode && bookStatus != "Borrowed")
                {
                    MessageBox.Show($"Cannot return: Book is currently '{bookStatus}'. Only 'Borrowed' books can be returned.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (DataGridViewRow r in dgvTransaction.Rows)
                {
                    if (r.Cells["colAccession"].Value?.ToString() == bookId)
                    {
                        MessageBox.Show("This book is already in the list.");
                        return;
                    }
                }

                DateTime dueDate = DateTime.Now.AddDays(currentUser.BorrowingPeriodDays);
                SetupDataGridView();
                dgvTransaction.Rows.Add(
                    bookRow["CopyId"],
                    bookRow["AccessionNumber"],
                    bookRow["Title"],
                    bookRow["Author"],
                    isCheckoutMode ? dueDate.ToString("MMM dd, yyyy") : "N/A"
                );

                scannedBooks.Add(bookId);
                txtSearch2.Clear();
                UpdateTransactionList();
            }
            else
            {
                MessageBox.Show("Book barcode not found.");
            }
        }

        private void UpdateTransactionList()
        {
            int itemCount = dgvTransaction.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);

            if (itemCount > 0)
            {
                dgvTransaction.Visible = true;
                pnlContentStatus.Visible = true;
                pb1.Visible = false;
                lbl1.Visible = false;

                lblTransactionStatus.Text = $"{itemCount} item(s) in current transaction";

                label19.Text = $"{itemCount} Item(s) ready for {(isCheckoutMode ? "Checkout" : "Return")}";
                label18.Text = "Click 'Process' to finalize.";
                pictureBox13.Visible = false;
            }
            else
            {
                pnlContentStatus.Visible = false;
                label19.Text = "No items scanned yet";
                label18.Text = "Scan book barcodes to begin";
                pictureBox13.Visible = true;
            }
        }

        private void SetMode(bool checkout)
        {
            if (dgvTransaction.Rows.Count > 0)
            {
                var result = MessageBox.Show("Switching modes will clear your current list. Continue?", "Confirm Switch", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;

                dgvTransaction.Rows.Clear();
                scannedBooks.Clear();
            }

            isCheckoutMode = checkout;

            label17.Text = checkout ? "Checking Out Books" : "Returning Books";
            btnCheckout.BackColor = checkout ? Color.SlateGray : Color.White;
            btnCheckout.ForeColor = checkout ? Color.White : Color.Black;
            btnReturn.BackColor = checkout ? Color.White : Color.SlateGray;
            btnReturn.ForeColor = checkout ? Color.Black : Color.White;
            pictureBox9.Image = checkout ? Properties.Resources.check : Properties.Resources.ret;

            if (dgvTransaction.Columns.Contains("colDueDate"))
            {
                dgvTransaction.Columns["colDueDate"].Visible = checkout;
            }

            UpdateTransactionList();
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

            int current = Convert.ToInt32(row["BooksBorrowed"]);
            int max = Convert.ToInt32(row["MaxBorrowLimit"]);

            lblBooksBorrowed.Text = $"{current} / {max}";

            if (current >= max)
            {
                lblBooksBorrowed.ForeColor = Color.Red;
                panel4.BackColor = Color.MistyRose; 
            }
            else
            {
                lblBooksBorrowed.ForeColor = Color.Black;
                panel4.BackColor = Color.Honeydew;
            }

            decimal fines = Convert.ToDecimal(row["UnpaidFines"]);
            lblUnpaidFines.Text = fines.ToString("C2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvTransaction.Rows.Count == 0) return;

            List<BorrowingTransaction> itemsToSave = new List<BorrowingTransaction> ();

            foreach (DataGridViewRow row in dgvTransaction.Rows)
            {
                if (row.IsNewRow) continue;

                itemsToSave.Add(new BorrowingTransaction
                {
                    CopyId = Convert.ToInt32(row.Cells["colCopyId"].Value),
                    DueDate = isCheckoutMode ? DateTime.Parse(row.Cells["colDueDate"].Value.ToString()) : DateTime.Now
                });
            }

            BorrowingTransaction_Repository repo = new BorrowingTransaction_Repository();
            bool success = false;

            if (isCheckoutMode)
            {
                success = repo.SaveBorrowingTransaction(currentUser.Cardnumber, itemsToSave);
            }
            else
            {
                success = repo.ReturnBooksTransaction(itemsToSave);
            }

            if (success)
            {
                MessageBox.Show(isCheckoutMode ? "Books Checked Out!" : "Books Returned Successfully!");
                dgvTransaction.Rows.Clear();
                UpdateTransactionList();
                ItemsClear();
            }
        }

        private void SetupDataGridView()
        {
            if (dgvTransaction.Columns.Count > 0) return;

            dgvTransaction.Columns.Clear();

            dgvTransaction.Columns.Add("colCopyId", "Copy ID");
            dgvTransaction.Columns["colCopyId"].Visible = false;

            dgvTransaction.Columns.Add("colAccession", "Accession #");
            dgvTransaction.Columns.Add("colTitle", "Title");
            dgvTransaction.Columns.Add("colAuthor", "Author");
            dgvTransaction.Columns.Add("colDueDate", "Due Date");

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "colAction";
            btnDelete.HeaderText = "Action";
            btnDelete.Text = "🗑"; 
            btnDelete.UseColumnTextForButtonValue = true;
            dgvTransaction.Columns.Add(btnDelete);
        }

        private void dgvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTransaction.Columns[e.ColumnIndex].Name == "colAction" && e.RowIndex >= 0)
            {
                string accession = dgvTransaction.Rows[e.RowIndex].Cells["colAccession"].Value.ToString();

                scannedBooks.Remove(accession);

                dgvTransaction.Rows.RemoveAt(e.RowIndex);

                UpdateTransactionList();
            }
        }

        private void ItemsClear()
        {
            dgvTransaction.Rows.Clear();
            scannedBooks.Clear();
            txtSearch.Clear();
            lblFullName.Text = "---";
            lblCardNumber.Text = "ID: ---";
            lblBooksBorrowed.Text = "0 / 0";
            pbProfile.Image = null;
            currentUser = null;

            pnlContainer1.Visible = false;
            dgvTransaction.Visible = false;
            pnlContentStatus.Visible = false;
            pb1.Visible = true;
            lbl1.Visible = true;
            btnAddBook.Enabled = false;
            btnAddBook.BackColor = Color.LightGray;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            ItemsClear();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ItemsClear();
        }

        private void pnlCirculation_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DrawCustomBorder(object sender, PaintEventArgs e)
        {
            Control ctrl = (Control)sender;

            int radius = 16;
            int borderThickness = 1;
            Color borderColor = Color.FromArgb(220, 223, 230);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(borderThickness, borderThickness,
                                           ctrl.Width - borderThickness * 2, ctrl.Height - borderThickness * 2);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                ctrl.Region = new Region(path);

                using (Pen pen = new Pen(borderColor, borderThickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
