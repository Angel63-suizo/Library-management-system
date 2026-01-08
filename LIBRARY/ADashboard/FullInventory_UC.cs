using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace LIBRARY.ADashboard
{
    public partial class FullInventory_UC : UserControl
    {
        public FullInventory_UC()
        {
            InitializeComponent();
        }

        private void dgvInventoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string bookTitle = dgvInventoryGrid.Rows[e.RowIndex].Cells["Title"].Value.ToString();

            if (dgvInventoryGrid.Columns[e.ColumnIndex].Name == "AddCol")
            {
                AddCopy addCopyForm = new AddCopy(bookTitle);

                if (addCopyForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }

            if (dgvInventoryGrid.Columns[e.ColumnIndex].Name == "DeleteCol")
            {
                string booktitle = dgvInventoryGrid.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                string currentStock = dgvInventoryGrid.Rows[e.RowIndex].Cells["AvailableCopies"].Value.ToString();
                string totalStock = dgvInventoryGrid.Rows[e.RowIndex].Cells["TotalCopies"].Value.ToString();

                DeleteCopy removeForm = new DeleteCopy(booktitle, currentStock, totalStock);

                if (removeForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }

            }
        }

        private void RefreshGrid()
        {
            GetInventoryGrid_Repository repo = new GetInventoryGrid_Repository();
            DataTable dt = repo.GetInventoryGrid(txtSearch.Text, cmbCategory.Text, cmbStatus.Text);

            dgvInventoryGrid.DataSource = null;
            dgvInventoryGrid.AutoGenerateColumns = true;
            dgvInventoryGrid.DataSource = dt;

            string[] colsToHide = {
                "AvailableCopies", "TotalCopies", "CheckedOut",
                "Damaged", "Lost", "Good", "Title", "Author", "ISBN", "BookID"
            };

            foreach (string colName in colsToHide)
            {
                if (dgvInventoryGrid.Columns.Contains(colName))
                {
                    dgvInventoryGrid.Columns[colName].Visible = false;
                }
            }

            if (dgvInventoryGrid.Columns.Contains("BookDetails")) dgvInventoryGrid.Columns["BookDetails"].DisplayIndex = 0;
            if (dgvInventoryGrid.Columns.Contains("Category")) dgvInventoryGrid.Columns["Category"].DisplayIndex = 1;
            if (dgvInventoryGrid.Columns.Contains("StockStatus")) dgvInventoryGrid.Columns["StockStatus"].DisplayIndex = 2;
            if (dgvInventoryGrid.Columns.Contains("Condition")) dgvInventoryGrid.Columns["Condition"].DisplayIndex = 3;
            if (dgvInventoryGrid.Columns.Contains("Actions")) dgvInventoryGrid.Columns["Actions"].DisplayIndex = 4;

            dgvInventoryGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvInventoryGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            if (dgvInventoryGrid.Columns.Contains("StockStatus"))
            {
                dgvInventoryGrid.Columns["StockStatus"].DefaultCellStyle.ForeColor = Color.DimGray;
                dgvInventoryGrid.Columns["StockStatus"].Width = 220;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void FullInventory_UC_Load(object sender, EventArgs e)
        {
            cmbCategory.SelectedIndexChanged -= cmbCategory_SelectedIndexChanged;
            cmbStatus.SelectedIndexChanged -= cmbStatus_SelectedIndexChanged;

            PopulateCategories();
            SetupStatusFilter();

            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;

            RefreshGrid();
        }

        private void PopulateCategories()
        {
            try
            {
                A_AddResource_Repository repo = new A_AddResource_Repository();
                DataTable types = repo.GetCategories();

                cmbCategory.Items.Clear();
                cmbCategory.Items.Add("All Categories");

                if (types != null && types.Rows.Count > 0)
                {
                    foreach (DataRow row in types.Rows)
                    {
                        string Category = row["Name"].ToString();
                        cmbCategory.Items.Add(Category);
                    }
                }
                else
                {
                    MessageBox.Show("No Categories were found in the database.");
                }

                cmbCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating Category Filter: " + ex.Message);
            }

        }

        private void dgvInventoryGrid_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvInventoryGrid.Columns[e.ColumnIndex] == null) return;

            string colName = dgvInventoryGrid.Columns[e.ColumnIndex].Name;
            var row = dgvInventoryGrid.Rows[e.RowIndex];

            try
            {
                if (colName == "StockStatus")
                {
                    int avail = GetSafeInt(row.Cells["AvailableCopies"].Value);
                    int total = GetSafeInt(row.Cells["TotalCopies"].Value);
                    int borrowed = GetSafeInt(row.Cells["CheckedOut"].Value);

                    string statusText = avail > 0 ? "● In Stock\n" : "○ Out of Stock\n";
                    e.Value = $"{statusText}{avail} / {total} available\nBorrowed: {borrowed}";
                    e.FormattingApplied = true;
                }

                if (colName == "Condition")
                {
                    int good = GetSafeInt(row.Cells["Good"].Value);
                    int damaged = GetSafeInt(row.Cells["Damaged"].Value);
                    int lost = GetSafeInt(row.Cells["Lost"].Value);

                    e.Value = $"Good: {good}\nDamaged: {damaged}\nLost: {lost}";
                    e.FormattingApplied = true;
                }

                if (colName == "BookDetails")
                {
                    string title = row.Cells["Title"].Value?.ToString() ?? "Untitled";
                    string author = row.Cells["Author"].Value?.ToString() ?? "Unknown";
                    string id = row.Cells["BookID"].Value?.ToString() ?? "N/A";
                    string isbn = row.Cells["ISBN"].Value?.ToString() ?? "N/A";

                    e.Value = $"{title}\n by : {author}\n{id} • ISBN: {isbn}";
                    e.FormattingApplied = true;
                }
            }
            catch
            {
                e.Value = "Check Data"; 
            }
        }

        private int GetSafeInt(object value)
        {
            if (value == null || value == DBNull.Value || string.IsNullOrEmpty(value.ToString()))
                return 0;
            return Convert.ToInt32(value);
        }

        private void SetupStatusFilter()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("All Status");
            cmbStatus.Items.Add("In Stock");
            cmbStatus.Items.Add("Out of Stock");

            cmbStatus.SelectedIndex = 0;
        }
    }
}
