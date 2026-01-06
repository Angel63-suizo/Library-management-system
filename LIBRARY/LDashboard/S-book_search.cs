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
    public partial class S_book_search : UserControl
    {
        public S_book_search()
        {
            InitializeComponent();
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.txtSearch.KeyDown += new KeyEventHandler(this.txtSearch_KeyDown);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ExecuteBookSearch();

            string searchQuery = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Enter a Book ID, title, or ISBN");
                return;
            }
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteBookSearch();
                e.SuppressKeyPress = true;
            }
        }

        private void ExecuteBookSearch()
        {
            string query = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                ResetToEmptyState();
                return;
            }

            ShowResults(query);
        }

        private void ShowResults(string query)
        {
            pictureBox7.Visible = false;
            label10.Visible = false;
            label19.Visible = false;

            label19.Visible = true;
            label19.Text = $"Searching for: \"{query}\"...";
            label19.ForeColor = Color.SteelBlue;
        }

        private void ResetToEmptyState()
        {
            pictureBox7.Visible = true;
            label10.Visible = true;
            label19.Visible = true;
            label19.Text = "Enter a Book ID, title, or ISBN to search";
            label19.ForeColor = Color.DimGray;
        }
    }
}
