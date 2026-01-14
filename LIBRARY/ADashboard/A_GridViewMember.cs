using LIBRARY.Class;
using LIBRARY.Models;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LIBRARY.ADashboard
{
    public partial class A_GridViewMember : UserControl
    {
        private Admin LoggedInAdmin;
        public A_GridViewMember(Admin admin)
        {
            InitializeComponent();
            LoggedInAdmin = admin;
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
            string cardNum = dgvMemberGrid.Rows[e.RowIndex].Cells["colCardNumber"].Value.ToString();

            if (dgvMemberGrid.Columns[e.ColumnIndex].Name == "EditCol")
            {
                EditMembers editForm = new EditMembers(LoggedInAdmin, cardNum);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();

                    Dashboard_Repository logRepo = new Dashboard_Repository();
                }
            }



            if (dgvMemberGrid.Columns[e.ColumnIndex].Name == "ViewCol")
            {
                string cardNumber = dgvMemberGrid.Rows[e.RowIndex].Cells["colCardNumber"].Value.ToString();
                A_GetMemberDetails_Repository repo = new A_GetMemberDetails_Repository();

                DataRow memberProfile = repo.GetMemberDetails(cardNumber);

                DataTable history = repo.GetMemberTransactionHistory(cardNumber);

                if (memberProfile != null)
                {
                    ViewMemberDetails view = new ViewMemberDetails(LoggedInAdmin, memberProfile, history);
                    view.ShowDialog();
                }
            }

            if (dgvMemberGrid.Columns[e.ColumnIndex].Name == "DeleteCol")
            {
                var confirm = MessageBox.Show("Delete this member and all their history? This cannot be undone.",
                                             "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    Delete_Repository repo = new Delete_Repository();
                    var result = repo.DeleteMemberFull(cardNum);

                    if (result.success)
                    {
                        MessageBox.Show(result.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                    }
                    else
                    {
                        MessageBox.Show(result.message, "Deletion Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AddMember add = new AddMember(LoggedInAdmin);

            if (add.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();

                Dashboard_Repository logRepo = new Dashboard_Repository();
            }

            RefreshGrid();
        }

        private void btnLibraryStaff_Click(object sender, EventArgs e)
        {
            A_AddLibraryStaff add = new A_AddLibraryStaff(LoggedInAdmin);
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
                MemberManager repo = new MemberManager();
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

        private void PopulateFilters()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("All Status");
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Suspended");
            cmbStatus.Items.Add("Expired");
            cmbStatus.SelectedIndex = 0;
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
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
