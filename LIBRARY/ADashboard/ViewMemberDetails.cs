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
using LIBRARY.Models;

namespace LIBRARY.ADashboard
{
    public partial class ViewMemberDetails : Form
    {
        private Admin LoggedInAdmin;
        private DataRow _memberData;
        private DataTable _transactionHistory;
        public ViewMemberDetails(Admin admin, DataRow memberData, DataTable transactionHistory)
        {
            InitializeComponent();
            LoggedInAdmin = admin;
            _memberData = memberData;
            _transactionHistory = transactionHistory;

            LoadMemberProfile();
            LoadHistoryGrid();
        }

        private void ViewMemberDetails_Load(object sender, EventArgs e)
        {

        }

        private void LoadMemberProfile()
        {
            lblFullName.Text = $"{_memberData["FirstName"]} {_memberData["LastName"]}";
            lblCardNumber.Text = _memberData["CardNumber"].ToString();
            lblEmail.Text = _memberData["Email"].ToString();
            lblPhone.Text = _memberData["Phone"].ToString();
            lblAddress.Text = _memberData["Address"].ToString();

            lblStatus.Text = _memberData["Status"].ToString();
            lblMemberType.Text = _memberData["MemberType"].ToString();

            lblRegistrationDate.Text = Convert.ToDateTime(_memberData["JoinDate"]).ToString("yyyy-MM-dd");
            lblExpirationDate.Text = Convert.ToDateTime(_memberData["ExpiryDate"]).ToString("yyyy-MM-dd");
            lblBooksOut.Text = $"{_memberData["BooksCheckedOut"]} / {_memberData["MaxBooksAllowed"]}";

            decimal fines = Convert.ToDecimal(_memberData["TotalFines"]);
            lblTotalFines.Text = fines.ToString("C2");
            lblTotalFines.ForeColor = fines > 0 ? Color.Red : Color.Green;
        }

        private void LoadHistoryGrid()
        {
            dgvHistory.AutoGenerateColumns = false;
            dgvHistory.DataSource = _transactionHistory;

            if (_transactionHistory == null || _transactionHistory.Rows.Count == 0)
            {
                dgvHistory.Visible = false;
                lblNoTransaction.Visible = true;
            }
            else
            {
                dgvHistory.Visible = true;
                lblNoTransaction.Visible = true;

                dgvHistory.Columns["Type"].DataPropertyName = "TransactionType";
                dgvHistory.Columns["Title"].DataPropertyName = "Title";
                dgvHistory.Columns["Date"].DataPropertyName = "TransactionDate";
            }
        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHistory.Columns[e.ColumnIndex].Name == "Type" && e.Value != null)
            {
                string type = e.Value.ToString();

                if (string.Equals(type, "Borrowing", StringComparison.OrdinalIgnoreCase))
                    e.CellStyle.ForeColor = Color.Blue;
                else if (string.Equals(type, "Payment", StringComparison.OrdinalIgnoreCase))
                    e.CellStyle.ForeColor = Color.Green;
                else if (string.Equals(type, "Reservation", StringComparison.OrdinalIgnoreCase))
                    e.CellStyle.ForeColor = Color.Orange;

                e.CellStyle.Font = new Font(dgvHistory.Font, FontStyle.Bold);
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
