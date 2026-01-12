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

namespace LIBRARY.ADashboard
{
    public partial class A_dashboard : UserControl
    {
        public A_dashboard()
        {
            InitializeComponent();
            SetupCharts();
        }

        private void A_dashboard_Load(object sender, EventArgs e)
        {
            UpdateDashboardLabels();
            Timer refreshTimer = new Timer();
            refreshTimer.Interval = 5000;
            refreshTimer.Tick += (s, args) => UpdateDashboardLabels();
            refreshTimer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            LoadUserControl(new A_UserManagement());
        }

        private void LoadUserControl(UserControl mem)
        {
            this.SuspendLayout();

            if (this.Controls.Count > 0)
            {
                this.Controls[0].Dispose();
                this.Controls.Clear();
            }
            mem.Dock = DockStyle.Fill;
            this.Controls.Add(mem);

            this.ResumeLayout(true);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            LoadUserControl(new A_Resources());
        }

        private void btn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new SystemSettings_UC());
        }

        private void UpdateDashboardLabels()
        {
            A_StatsBox_Repository repo = new A_StatsBox_Repository();
            DataTable dt = repo.GetDashboardStats();

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblTotalBooks.Text = string.Format("{0:N0}", row["TotalBooks"] ?? 0);
                lblActiveStaff.Text = row["ActiveStaff"]?.ToString() ?? "0";
                lblOverdueBooks.Text = row["OverdueBooks"]?.ToString() ?? "0";
                lblTotalMembers.Text = string.Format("{0:N0}", row["TotalMembers"] ?? 0);
                lblBooksBorrowed.Text = string.Format("{0:N0}", row["BooksBorrowed"] ?? 0);
                lblTotalRevenue.Text = string.Format("${0:N0}", row["TotalRevenue"] ?? 0);
            }
        }

        private void SetupCharts()
        {
            Dashboard_Repository repo = new Dashboard_Repository();

            DataTable trendsData = repo.GetMonthlyTrends();
            chartTrends.DataSource = trendsData;

            chartTrends.Series["Borrowed"].XValueMember = "Month";
            chartTrends.Series["Borrowed"].YValueMembers = "Borrowed";

            chartTrends.Series["Returned"].XValueMember = "Month";
            chartTrends.Series["Returned"].YValueMembers = "Returned";

            DataTable categoryData = repo.GetCategoryStats();
            chartCategory.DataSource = categoryData;

            chartCategory.Series[0].XValueMember = "Category";
            chartCategory.Series[0].YValueMembers = "TotalCount";

            chartCategory.Series[0]["PieLabelStyle"] = "Outside";
            chartCategory.ChartAreas[0].BackColor = Color.Transparent;

            chartTrends.DataBind();
            chartCategory.DataBind();
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
