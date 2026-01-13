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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace LIBRARY.ADashboard
{
    public partial class A_UserManagement : UserControl
    {
        private Admin LoggedInAdmin;
        public A_UserManagement(Admin admin)
        {
            InitializeComponent();
            LoggedInAdmin = admin;
        }

        private void A_UserManagement_Load(object sender, EventArgs e)
        {
            A_GridViewMember myGrid = new A_GridViewMember(LoggedInAdmin);
            myGrid.Dock = DockStyle.Fill;

            pnlGridContainer.Controls.Add(myGrid);

            UpdateDashboardLabels();
            Timer refreshTimer = new Timer();
            refreshTimer.Interval = 5000; 
            refreshTimer.Tick += (s, args) => UpdateDashboardLabels();
            refreshTimer.Start();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDashboardLabels()
        {
            A_StatsBox_Repository repo = new A_StatsBox_Repository();
            DataTable dt = repo.GetMemberStats();

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblTotalMembers.Text = row["Total"].ToString();
                lblActive.Text = row["Active"].ToString();
                lblSuspended.Text = row["Suspended"].ToString();
                lblNew.Text = row["NewMonth"].ToString();
            }
        }



        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; 
                return cp;
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
