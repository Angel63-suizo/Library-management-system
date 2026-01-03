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
    public partial class A_GridViewMember : UserControl
    {
        public A_GridViewMember()
        {
            InitializeComponent();
        }

        private void A_GridViewMember_Load(object sender, EventArgs e)
        {
            PopulateFilters();
            PopulateMemberType();
            RefreshGrid();
        }

        private void dgvMemberGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string cardnum = dgvMemberGrid.Rows[e.RowIndex].Cells["colCardNumber"].Value.ToString();

            if (dgvMemberGrid.Columns[e.ColumnIndex].Name == "EditCol")
            {
                MessageBox.Show("Editing Member: " + cardnum);
            }

            if (dgvMemberGrid.Columns[e.ColumnIndex].Name == "ViewCol")
            {
                string cardNumber = dgvMemberGrid.Rows[e.RowIndex].Cells["colCardNumber"].Value.ToString();
                A_GetMemberDetails_Repository repo = new A_GetMemberDetails_Repository();

                DataRow memberProfile = repo.GetMemberDetails(cardNumber);

                // DataTable history = repo.GetMemberTransactionHistory(cardNumber);

                if (memberProfile != null)
                {
                    A_ViewMemberDetails viewControl = new A_ViewMemberDetails(memberProfile);
                    Form popupForm = new Form();
                    popupForm.FormBorderStyle = FormBorderStyle.None; 
                    popupForm.StartPosition = FormStartPosition.CenterParent;
                    popupForm.Size = viewControl.Size;

                    viewControl.Dock = DockStyle.Fill;
                    popupForm.Controls.Add(viewControl);

                    popupForm.ShowDialog();
                }
            }

            if (dgvMemberGrid.Columns[e.ColumnIndex].Name == "DeleteCol")
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete member " + cardnum + "?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {

                }
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            A_AddMember add = new A_AddMember();
            Control parentpanel = this.Parent;

            if (parentpanel != null)
            {
                parentpanel.Controls.Add(add);
                add.BringToFront();
                add.Left = (parentpanel.Width - add.Width) / 2;
                add.Top = (parentpanel.Height - add.Height) / 2;

                this.Enabled = false;
            }
        }

        private void btnLibraryStaff_Click(object sender, EventArgs e)
        {
            A_AddLibraryStaff add = new A_AddLibraryStaff();
            Control parentpanel = this.Parent;

            if (parentpanel != null)
            {
                parentpanel.Controls.Add(add);
                add.BringToFront();
                add.Left = (parentpanel.Width - add.Width) / 2;
                add.Top = (parentpanel.Height - add.Height) / 2;

                this.Enabled = false;
            }
        }

        private void RefreshGrid()
        {
            A_MemberGrid_Repository repo = new A_MemberGrid_Repository();
            DataTable dt = repo.GetMemberGrid(txtSearch.Text, cmbMemberType.Text, cmbStatus.Text);
            dgvMemberGrid.AutoGenerateColumns = false;

            dgvMemberGrid.DataSource = dt;

        }

        private void cmbMemberType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void PopulateMemberType()
        {
            try
            {
                A_AddMember_Repository repo = new A_AddMember_Repository();
                DataTable types = repo.GetMemberType();

                cmbMemberType.Items.Clear();
                cmbMemberType.Items.Add("All Types");

                if (types != null && types.Rows.Count > 0)
                {
                    foreach (DataRow row in types.Rows)
                    {
                        string typeName = row["NameType"].ToString();
                        cmbMemberType.Items.Add(typeName);
                    }
                }
                else
                {
                    MessageBox.Show("No Member Types were found in the database.");
                }

                cmbMemberType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating Member Types: " + ex.Message);
            }
        }

        private void AddActionButtons()
        {
            if (dgvMemberGrid.Columns.Contains("View")) return;

            DataGridViewImageColumn viewCol = new DataGridViewImageColumn();
            viewCol.Name = "ViewCol";
            viewCol.HeaderText = "";
            viewCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvMemberGrid.Columns.Add(viewCol);

            DataGridViewImageColumn deleteCol = new DataGridViewImageColumn();
            deleteCol.Name = "DeleteCol";
            deleteCol.HeaderText = "";
            viewCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvMemberGrid.Columns.Add(deleteCol);

            DataGridViewImageColumn editCol = new DataGridViewImageColumn();
            editCol.Name = "EditCol";
            editCol.HeaderText = "Actions";
            viewCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvMemberGrid.Columns.Add(editCol);
        }

        private void PopulateFilters()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("All Status");
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Suspended");
            cmbStatus.Items.Add("Expired");
            cmbStatus.SelectedIndex = 0;
        }
    }
}
