using ExCSS;
using LIBRARY.Models;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace LIBRARY.ADashboard
{
    public partial class A_EditResource : Form
    {
        private string _bookId;
        public A_EditResource(String BookId)
        {
            InitializeComponent();

            _bookId = BookId;
            LoadInitialData();
        }

        private void CheckForChanges(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Resource updatedResource = new Resource
            {
                AccessionBase = _bookId, 
                ISBN = txtISBN.Text.Trim(),
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                PublisherName = txtPublisher.Text.Trim(),
                PublicationYear = (int)numPubYear.Value,
                Description = txtDescription.Text.Trim()
            };

            Update_Repository repo = new Update_Repository();
            if (repo.UpdateResource(updatedResource))
            {
                MessageBox.Show("Update Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Update failed. Check if the Book ID exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A_EditResource_Load(object sender, EventArgs e)
        {
        }
        private void LoadInitialData()
        {
            Update_Repository repo = new Update_Repository(); 
            DataRow row = repo.GetResourceDetails2(_bookId);

            if (row != null)
            {
                lblBookID.Text = row["AccessionBase"].ToString();
                txtISBN.Text = row["ISBN"].ToString();
                txtTitle.Text = row["Title"].ToString();
                txtAuthor.Text = row["Author"].ToString();
                txtPublisher.Text = row["PublisherName"].ToString();
                numPubYear.Value = Convert.ToInt32(row["PublicationYear"]);
                txtDescription.Text = row["Description"].ToString();
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
