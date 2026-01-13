using LIBRARY.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}

