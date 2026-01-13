using LIBRARY.ADashboard;
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

namespace LIBRARY.MDashboard
{
    public partial class M_my_account : UserControl
    {
        private MemberType LoggedInMember;
        
        private bool isEditing = false;
        private decimal outstandingFine = 500;

        public M_my_account(MemberType member)
        {
            InitializeComponent();
            LoggedInMember = member;

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
        private void LoadProfileData()
        {
            Profile_Repository repo = new Profile_Repository();
            DataRow profile = repo.GetMemberProfile(LoggedInMember.MemberId);

            if (profile != null)
            {
                lblFirstName.Text = profile["FirstName"].ToString();
                lblLastName.Text = profile["LastName"].ToString();
                lblRole.Text = profile["Role"].ToString();
                lblMemberID.Text = "Member ID: " + profile["MemberID"].ToString();
                lblEmail.Text = profile["Email"].ToString();
                lblPhone.Text = profile["Phone"].ToString();
                lblAddress.Text = profile["Address"].ToString();

                lblJoinDate.Text = Convert.ToDateTime(profile["RegistrationDate"]).ToString("yyyy-MM-dd");
                lblExpiry.Text = Convert.ToDateTime(profile["ExpirationDate"]).ToString("yyyy-MM-dd");

                lblStatus.Text = profile["Status"].ToString();
                pnlStatus.BackColor = lblStatus.Text == "Active" ? Color.Honeydew : Color.MistyRose;
            }
        }

        private void LoadFineHistory()
        {
            if (LoggedInMember == null) return;

            Profile_Repository repo = new Profile_Repository();
            DataTable fineData = repo.GetFineHistory(LoggedInMember.MemberId);

            dataGridView1.Rows.Clear();

            foreach (DataRow row in fineData.Rows)
            {
                string date = Convert.ToDateTime(row["Date"]).ToString("yyyy-MM-dd");
                string desc = row["Description"].ToString();
                string amount = "₱" + Convert.ToDecimal(row["Amount"]).ToString("N2");
                string status = row["Status"].ToString();

                dataGridView1.Rows.Add(date, desc, amount, status);
            }

            dataGridView1.ClearSelection();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            frmUpdateProfile add = new frmUpdateProfile(LoggedInMember);

            if (add.ShowDialog() == DialogResult.OK)
            {
                LoadProfileData();
            }

        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword add = new frmChangePassword(LoggedInMember);
            if (add.ShowDialog() == DialogResult.OK)
            {
                LoadProfileData();
            }
        }

        private void BtnUpdateContact_Click(object sender, EventArgs e)
        {
            frmUpdateProfile add = new frmUpdateProfile(LoggedInMember);

            if (add.ShowDialog() == DialogResult.OK)
            {
                LoadProfileData();
            }
        }

        private void BtnDownloadReceipt_Click(object sender, EventArgs e)
        {
        }

        private void BtnPayNow_Click(object sender, EventArgs e)
        {  
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Showing full fine history.",
        "Fine History",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    );
        }

        private void M_my_account_Load(object sender, EventArgs e)
        {
            LoadProfileData();
            LoadFineHistory();

        }
    }
}
