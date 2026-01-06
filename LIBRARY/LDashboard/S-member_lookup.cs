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
    public partial class S_book_lookup : UserControl
    {
        public S_book_lookup()
        {
            InitializeComponent();
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.txtSearch.KeyDown += new KeyEventHandler(this.txtSearch_KeyDown);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ExecuteMemberSearch();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteMemberSearch();
                e.SuppressKeyPress = true;
            }
        }

        private void ExecuteMemberSearch()
        {
            string query = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Please enter a Member ID or Name.");
                ResetToEmptyState();
                return;
            }
            ShowResults(query);
        }

        private void ShowResults(string query)
        {
            pictureBox7.Visible = false;
            label10.Visible = false;
            lblMemSearch.Visible = false;

            lblMemSearch.Visible = true;
            lblMemSearch.Text = $"Searching for Member: \"{query}\"...";
            lblMemSearch.ForeColor = Color.SteelBlue;
        }

        private void ResetToEmptyState()
        {
            pictureBox7.Visible = true;
            label10.Visible = true;
            lblMemSearch.Visible = true;
            lblMemSearch.Text = "Enter a Member ID or name to search";
            lblMemSearch.ForeColor = Color.DimGray;
        }
    }
}
