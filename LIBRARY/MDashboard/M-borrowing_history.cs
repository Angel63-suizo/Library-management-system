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

namespace LIBRARY.MDashboard
{
    public partial class M_borrowing_history : UserControl
    {
        private bool isSearchFocused = false;
        private bool isPanel7Hovered = false;
        private bool isComboFocused = false;
        private DataTable borrowingData;

        public M_borrowing_history()
        {
            InitializeComponent();
            InitializeBorrowingGrid();
            LoadSampleData();
            UpdateSummaryStatistics();
            txtSearch.TextChanged += (s, e) => ApplyFilters();
            cmbStatus.SelectedIndexChanged += (s, e) => ApplyFilters();
            txtSearch.Enter += (s, e) =>
            {
                isSearchFocused = true;
                panel7.Invalidate();
            };

            txtSearch.Leave += (s, e) =>
            {
                isSearchFocused = false;
                panel7.Invalidate();
            };

            cmbStatus.Enter += (s, e) =>
            {
                isSearchFocused = true;
                isComboFocused = true;
                panel7.Invalidate();
            };

            cmbStatus.Leave += (s, e) =>
            {
                isSearchFocused = false;
                isComboFocused = false;
                panel7.Invalidate();
            };
        }

        private void DrawCustomBorder(object sender, PaintEventArgs e)
        {

            Control ctrl = (Control)sender;
            int radius = 16;
            int borderThickness = 1;
            Color borderColor = Color.FromArgb(220, 223, 230);

            if (ctrl.Name == "panel7" && (isPanel7Hovered || isSearchFocused))
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
                    e.Graphics.DrawPath(pen, path);
            }
        }

        private void pnlCombo_Paint(object sender, PaintEventArgs e)
        {
            Color borderIdle = Color.LightGray;
            Color borderActive = Color.FromArgb(64, 64, 64);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(pnlCombo.Focused ? borderActive : borderIdle, 1))
            {
                Rectangle rect = pnlCombo.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
        private void ApplyFilters()
        {
            if (borrowingData == null) return;

            string searchText = txtSearch.Text.Trim().Replace("'", "''");
            string selectedStatus = cmbStatus.SelectedItem?.ToString() ?? "All Status";

            // Search by Title OR Author
            string searchFilter = $"(Title LIKE '%{searchText}%' OR Author LIKE '%{searchText}%')";

            // Combine with Status if not "All Status"
            string finalFilter = searchFilter;
            if (selectedStatus != "All Status" && !string.IsNullOrEmpty(selectedStatus))
            {
                finalFilter += $" AND Status = '{selectedStatus}'";
            }

            // Apply the filter
            borrowingData.DefaultView.RowFilter = finalFilter;
            label7.Text = $"Showing {dgvHistory.Rows.Count} of {borrowingData.Rows.Count} records";
        }
        private void InitializeBorrowingGrid()
        {
            borrowingData = new DataTable();

            // These column names MUST match the "DataPropertyName" in your dgvHistory column properties
            borrowingData.Columns.Add("Title");
            borrowingData.Columns.Add("Author");
            borrowingData.Columns.Add("BorrowDate");
            borrowingData.Columns.Add("ReturnDate");
            borrowingData.Columns.Add("Status");
            borrowingData.Columns.Add("Fine");

            dgvHistory.Columns["Title"].DataPropertyName = "Title";
            dgvHistory.Columns["Author"].DataPropertyName = "Author";
            dgvHistory.Columns["BorrowDate"].DataPropertyName = "BorrowDate";
            dgvHistory.Columns["ReturnDate"].DataPropertyName = "ReturnDate";
            dgvHistory.Columns["Status"].DataPropertyName = "Status";
            dgvHistory.Columns["Fine"].DataPropertyName = "Fine";

            // IMPORTANT: Since you added columns in Properties, prevent the grid from adding them again
            dgvHistory.AutoGenerateColumns = false;

            // Link the DataTable to the Grid
            dgvHistory.DataSource = borrowingData;
        }
        private void LoadSampleData()
        {
            // Adding rows to the DataTable
            borrowingData.Rows.Add("The Great Gatsby", "F. Scott Fitzgerald", "2023-10-01", "2023-10-15", "Returned", "$0.00");
            borrowingData.Rows.Add("1984", "George Orwell", "2023-11-01", "-", "Currently Borrowed", "$0.00");
            borrowingData.Rows.Add("The Hobbit", "J.R.R. Tolkien", "2023-09-20", "2023-10-05", "Overdue Return", "$5.50");
        }
        private void UpdateSummaryStatistics()
        {
            if (borrowingData == null) return;

            // 1. Total Borrowed (Total rows in the table)
            lblTotalBorrowed.Text = borrowingData.Rows.Count.ToString();

            // 2. Currently Borrowed Count
            int currentlyBorrowed = borrowingData.AsEnumerable()
                .Count(row => row.Field<string>("Status") == "Currently Borrowed");
            lblCurrentlyBorrowed.Text = currentlyBorrowed.ToString();

            // 3. Returned Count (Includes "Returned" and "Overdue Return")
            int returned = borrowingData.AsEnumerable()
                .Count(row => row.Field<string>("Status").Contains("Returned"));
            lblReturned.Text = returned.ToString();

            // 4. Total Fines Paid
            decimal totalFines = borrowingData.AsEnumerable()
                .Sum(row => {
                    decimal fine;
                    return decimal.TryParse(row.Field<string>("Fine"), out fine) ? fine : 0;
                });
            lblFinesPaid.Text = $"${totalFines:N2}";

            // 5. Update the "Showing X of X records" label (label7)
            label7.Text = $"Showing {dgvHistory.Rows.Count} of {borrowingData.Rows.Count} records";
        }
    }
}
