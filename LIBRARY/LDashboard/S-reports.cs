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

namespace LIBRARY.LDashboard
{
    public partial class S_reports : UserControl
    {
        libraryStaff LoggedInStaff;
        public S_reports(libraryStaff staff)
        {
            InitializeComponent();
            LoggedInStaff = staff;

            this.button1.Click += (s, e) => ExportOverdueReport();

            panel17.Click += (s, e) => GenerateDailyCirculation();
            panel19.Click += (s, e) => GenerateWeeklySummary();
            panel20.Click += (s, e) => GenerateOverdueReport();
            panel21.Click += (s, e) => GenerateFineCollection();
            this.Load += (s, e) => RefreshDailyStats();
        }

        public void RefreshDailyStats()
        {
            DateTime today = DateTime.Today;

            label12.Text = GetCheckoutCount(today).ToString();
            label14.Text = GetReturnCount(today).ToString();
            label17.Text = GetNewMemberCount(today).ToString();
            label18.Text = GetTotalFines(today).ToString("C2"); 
        }

        private int GetCheckoutCount(DateTime date)
        {
            return 0;
        }

        private int GetReturnCount(DateTime date)
        {
            return 0;
        }

        private int GetNewMemberCount(DateTime date)
        {
            return 0;
        }

        private decimal GetTotalFines(DateTime date)
        {
            return 0.00m;
        }


        private void ExportOverdueReport()
        {
            MessageBox.Show("Exporting Overdue Report to Excel/PDF...", "Report Export");
        }
        private void GenerateDailyCirculation() { MessageBox.Show("Generating Daily Circulation..."); }
        private void GenerateWeeklySummary() { MessageBox.Show("Generating Weekly Summary..."); }
        private void GenerateOverdueReport() { MessageBox.Show("Generating Comprehensive Overdue Report..."); }
        private void GenerateFineCollection() { MessageBox.Show("Generating Fine Collection Report..."); }

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

