using LIBRARY.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.LDashboard
{ 
    public partial class S_book_search : UserControl
    {
        private libraryStaff LoggedInStaff;

        private bool isSearchFocused = false;
        private bool isPanel1Hovered = false;
        public S_book_search(libraryStaff staff)
        {
            InitializeComponent();
            LoggedInStaff = staff;

            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.txtSearch.KeyDown += new KeyEventHandler(this.txtSearch_KeyDown);
            ResetToEmptyState();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ExecuteBookSearch();

           string bookId = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(bookId))
            {
                MessageBox.Show("Enter a Book ID, title, or ISBN");
                return;
            }
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteBookSearch();
                e.SuppressKeyPress = true;
            }
        }

        private void ExecuteBookSearch()
        {
            string bookId = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(bookId))
            {
                ResetToEmptyState();
                return;
            }

            ShowResults(bookId);
        }

        private void ShowResults(string bookId)
        {
            pnlContainerA.Visible = true;
            flpCopyStatus.Visible = true;
            label19.Text = $"Searching for: \"{bookId}\"...";
            label19.ForeColor = Color.SteelBlue;

            BookSearch_Repository repo = new BookSearch_Repository();

            DataRow bookInfo = repo.GetBookInfo(bookId);

            if (bookInfo != null)
            {
                lblTitle.Text = bookInfo["Title"].ToString();
                lblAuthor.Text = bookInfo["Author"].ToString();
                lblAccessionBase.Text = bookInfo["BookID"].ToString();
                lblISBN.Text = bookInfo["ISBN"].ToString();
                lblCategory.Text = bookInfo["Category"].ToString();
                lblYear.Text = bookInfo["Year"].ToString();
                lblPublisher.Text = bookInfo["Publisher"] != DBNull.Value
                ? bookInfo["Publisher"].ToString()
                : "No Publisher Listed";

                lblCopies.Text = bookInfo["TotalCopies"].ToString();
                lblAvailable.Text = bookInfo["Available"].ToString();
                lblBorrowed.Text = bookInfo["Borrowed"].ToString();

                int resId = Convert.ToInt32(bookInfo["ResourceId"]);
                DataTable copies = repo.GetCopyStatuses(resId);
                DisplayCopyCards(copies);

            }
            else
            {
                MessageBox.Show("No book found with that Accession Base.");
                ResetToEmptyState();
            }
            
        }

        private void ResetToEmptyState()
        {
            pnlContainerA.Visible = false;
            flpCopyStatus.Visible = false;
            label19.Text = "Enter a Book ID, title, or ISBN to search";
            label19.ForeColor = Color.DimGray;
        }

        private void DisplayCopyCards(DataTable dt)
        {
            flpCopyStatus.Controls.Clear(); 

            foreach (DataRow row in dt.Rows)
            {
                string status = row["Status"].ToString();
                string accession = row["AccessionNumber"].ToString();

                Panel card = new Panel();
                card.Size = new Size(240, 120);
                card.Margin = new Padding(10);
                card.BorderStyle = BorderStyle.None;

                if (status == "Available")
                {
                    card.BackColor = Color.FromArgb(232, 250, 237); 
                    AddCardContent(card, accession, status, null, null, Color.DarkGreen);
                }
                else if (status == "Borrowed")
                {
                    card.BackColor = Color.FromArgb(255, 251, 222); 
                    string borrower = row["BorrowedBy"]?.ToString() ?? "Unknown";
                    string dueDate = row["DueDate"] != DBNull.Value
                        ? Convert.ToDateTime(row["DueDate"]).ToString("yyyy-MM-dd")
                        : "N/A";
                    AddCardContent(card, accession, status, borrower, dueDate, Color.Goldenrod);
                }
                else if (status == "Reserved")
                {
                    card.BackColor = Color.FromArgb(235, 245, 255); 
                                                                    
                    string reserver = row["ReservedBy"]?.ToString() ?? "Pending Pickup";
                    string expiry = row["ExpiryDate"] != DBNull.Value
                        ? Convert.ToDateTime(row["ExpiryDate"]).ToString("yyyy-MM-dd")
                        : "N/A";

                    AddCardContent(card, accession, status, $"Reserved by: {reserver}", $"Expires: {expiry}", Color.RoyalBlue);
                }


                flpCopyStatus.Controls.Add(card);
            }
        }

        private void AddCardContent(Panel p, string acc, string stat, string infoHeader, string infoDate, Color accentColor)
        {
            Label lblAcc = new Label { Text = acc, Font = new Font("Segoe UI", 10, FontStyle.Bold), Location = new Point(45, 15), AutoSize = true };

            Label lblStat = new Label { Text = stat, Font = new Font("Segoe UI", 8), Location = new Point(45, 35), AutoSize = true, ForeColor = Color.DimGray };

            Label line = new Label { Size = new Size(190, 1), BackColor = Color.LightGray, Location = new Point(15, 60), AutoSize = false };

            p.Controls.Add(lblAcc);
            p.Controls.Add(lblStat);
            p.Controls.Add(line);

            if (!string.IsNullOrEmpty(infoHeader))
            {
                Label lblInfo = new Label
                {
                    Text = $"{infoHeader}\n{infoDate}",
                    Font = new Font("Segoe UI", 8),
                    Location = new Point(15, 70),
                    Size = new Size(200, 40),
                    ForeColor = accentColor
                };
                p.Controls.Add(lblInfo);
            }

            string iconText = "✔️"; 
            if (stat == "Borrowed") iconText = "⚠️";
            else if (stat == "Reserved") iconText = "🔖"; 

            Label icon = new Label
            {
                Text = iconText,
                Location = new Point(15, 15),
                AutoSize = true,
                ForeColor = accentColor,
                Font = new Font("Segoe UI", 12)
            };
            p.Controls.Add(icon);
        }

        private void pnlBookSearch_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DrawCustomBorder(object sender, PaintEventArgs e)
        {
            Control ctrl = (Control)sender;

            int radius = 16;
            int borderThickness = 1;
            Color borderColor = Color.FromArgb(220, 223, 230);

            if (ctrl.Name == "panel1" && (isPanel1Hovered || isSearchFocused))
            {
                borderColor = Color.FromArgb(55, 65, 81);
                borderThickness = 2;
            }

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
