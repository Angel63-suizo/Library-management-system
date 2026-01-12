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
    public partial class A_Resources : UserControl
    {
        public A_Resources()
        {
            InitializeComponent();
        }

        private void A_Resources_Load(object sender, EventArgs e)
        {
            A_ResourcesGridView myGrid = new A_ResourcesGridView();
            myGrid.Dock = DockStyle.Fill;

            pnlGridContent.Controls.Add(myGrid);

            UpdateResourceLabels();
            Timer refreshTimer = new Timer();
            refreshTimer.Interval = 5000;
            refreshTimer.Tick += (s, args) => UpdateResourceLabels();
            refreshTimer.Start();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateResourceLabels()
        {
            A_StatsBox_Repository repo = new A_StatsBox_Repository();
            DataTable dt = repo.GetResourceStats();

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblTotalBooks.Text = row["TotalBooks"].ToString();
                lblAvailable.Text = row["AvailableBooks"].ToString();
                lblBorrowed.Text = row["BorrowedBooks"].ToString();
                lblCategories.Text = row["TotalCategories"].ToString();
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
