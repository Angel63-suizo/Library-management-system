using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.ADashboard
{
    public partial class A_ResourcesGridView : UserControl
    {
        public A_ResourcesGridView()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            A_AddNewResource add = new A_AddNewResource();
            add.DataSaved += (s, args) =>
            {
                RefreshGrid();
            };
            add.ShowDialog();
        }

        private void RefreshGrid()
        {
            A_GetResourceGrid_Repository repo = new A_GetResourceGrid_Repository();
            DataTable dt = repo.GetResourceGrid(txtSearch.Text, cmbCategory.Text);
            dgvResourceGrid.AutoGenerateColumns = false;

            dgvResourceGrid.DataSource = dt;

            dgvResourceGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvResourceGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            if (dgvResourceGrid.Columns["ISBN"] != null) dgvResourceGrid.Columns["ISBN"].Visible = false;
            if (dgvResourceGrid.Columns["BookDetails"] != null)
                dgvResourceGrid.Columns["BookDetails"].HeaderText = "Book Details";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void A_ResourcesGridView_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            PopulateCategories();
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

        private void dgvResourceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string bookId = dgvResourceGrid.Rows[e.RowIndex].Cells["colBookid"].Value.ToString();

            if (dgvResourceGrid.Columns[e.ColumnIndex].Name == "EditCol")
            {

                string BookId = dgvResourceGrid.Rows[e.RowIndex].Cells["colBookid"].Value.ToString();
                A_EditResource viewForm = new A_EditResource(BookId);
                viewForm.ShowDialog();
            }

            if (dgvResourceGrid.Columns[e.ColumnIndex].Name == "ViewCol")
            {
                string BookId = dgvResourceGrid.Rows[e.RowIndex].Cells["colBookid"].Value.ToString();
                A_ResourceDetail viewForm = new A_ResourceDetail(BookId);
                viewForm.ShowDialog();

            }

            if (dgvResourceGrid.Columns[e.ColumnIndex].Name == "DeleteCol")
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete member " + bookId + "?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {

                }
            }
        }
    }
}
