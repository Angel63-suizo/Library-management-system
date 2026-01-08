using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static LIBRARY.ADashboard.AddCopy_Repository;

namespace LIBRARY.ADashboard
{
    public partial class DeleteCopy : Form
    { 
        private string  _booktitle;
        public DeleteCopy(string title, string available, string total)
        {
            InitializeComponent();

            _booktitle = title;

            this.Text = "Remove Copies for: " + _booktitle;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCopy.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            string reason = cmbReason.Text;

            var repo = new Delete_Repository();
            var result = repo.RemoveCopy(_booktitle, qty, reason);

            if (result.Success)
            {
                MessageBox.Show(result.Message, "Stock Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
