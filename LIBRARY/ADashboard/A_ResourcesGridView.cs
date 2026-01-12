using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
            string bookId = dgvResourceGrid.Rows[e.RowIndex].Cells["colBookId"].Value.ToString();

            if (dgvResourceGrid.Columns[e.ColumnIndex].Name == "EditCol")
            {
                A_EditResource editForm = new A_EditResource(bookId);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();

                    Dashboard_Repository logRepo = new Dashboard_Repository();
                }
            }

            if (dgvResourceGrid.Columns[e.ColumnIndex].Name == "ViewCol")
            {
                string BookId = dgvResourceGrid.Rows[e.RowIndex].Cells["colBookId"].Value.ToString();
                A_ResourceDetail viewForm = new A_ResourceDetail(BookId);
                viewForm.ShowDialog();

            }

            if (dgvResourceGrid.Columns[e.ColumnIndex].Name == "DeleteCol")
            {
                var confirm = MessageBox.Show("Delete this resource and all their history? This cannot be undone.",
                                            "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    Delete_Repository repo = new Delete_Repository();
                    var result = repo.DeleteResource(bookId);

                    if (result.Success)
                    {
                        MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "Deletion Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
