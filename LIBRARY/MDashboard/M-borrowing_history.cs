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
using LIBRARY.Class;

namespace LIBRARY.MDashboard
{
    public partial class M_borrowing_history : UserControl
    {
        private MemberType LoggedInMember;
        private bool isSearchFocused = false;
        private bool isPanel7Hovered = false;
        private bool isComboFocused = false;
        private DataTable borrowingData;

        public M_borrowing_history(MemberType member)
        {
            InitializeComponent();
            LoggedInMember = member;

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

        private void M_borrowing_history_Load(object sender, EventArgs e)
        {
            RefreshHistory();
            LoadDashboardStats();
            populateStatusFilter();
        }

        private void RefreshHistory()
        {
            string selectedStatus = cmbStatus.SelectedItem?.ToString() ?? "All Status";
            string searchKeyword = txtSearch.Text.Trim();

            BorrowingHistory_Repository repo = new BorrowingHistory_Repository();
            DataTable dt = repo.GetMemberBorrowingHistory(LoggedInMember.MemberId, selectedStatus, searchKeyword);

            flpBorrowingHistory.Controls.Clear();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ucBorrowingHistory bookRow = new ucBorrowingHistory();
                    bookRow.SetData(row); 
                    flpBorrowingHistory.Controls.Add(bookRow);
                }
            }
        }

        private void LoadDashboardStats()
        {
            BorrowingHistory_Repository repo = new BorrowingHistory_Repository();
            DataTable dt = repo.GetBorrowingStats(LoggedInMember.MemberId);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblCurrentlyBorrowed.Text = string.Format("{0:N0}", row["CurrentlyBorrowed"] ?? 0);
                lblFinesPaid.Text = string.Format("{0:C}", row["FinesPaid"] ?? 0);
                lblTotalBorrowed.Text = string.Format("{0:N0}", row["TotalBorrowed"] ?? 0);
                lblReturned.Text = string.Format("${0:N0}", row["Returned"] ?? 0);
            }
        }

        private void populateStatusFilter()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("All Status");
            cmbStatus.Items.Add("Borrowed");
            cmbStatus.Items.Add("Returned");
            cmbStatus.SelectedIndex = 0;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshHistory();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshHistory();
        }
    }
}
