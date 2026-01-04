using ExCSS;
using LIBRARY.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
        private DataRow originalData;

        private void CheckForChanges(object sender, EventArgs e)
        {
            if (originalData == null) return;

            bool isChanged =
                txtISBN.Text != originalData["ISBN"].ToString() ||
                txtTitle.Text != originalData["Title"].ToString() ||
                txtAuthor.Text != originalData["Author"].ToString() ||
                txtPublisher.Text != originalData["Publisher"].ToString() ||
                numPubYear.Value != Convert.ToDecimal(originalData["PublicationYear"]) ||
                cmbCategory.SelectedValue.ToString() != originalData["CategoryId"].ToString() ||
                txtDescription.Text != (originalData["Description"]?.ToString() ?? "" );

            btnSave.Enabled = isChanged;

            btnSave.BackColor = isChanged ? Color.FromArgb(74, 144, 226) : Color.LightGray;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Resource updatedResource = new Resource
            {
                ISBN = txtISBN.Text,
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                PublisherId = txtPublisher.Text,
                PublicationYear = (int)numPubYear.Value,
                Description = txtDescription.Text,
            };

            int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);

            A_GetResourceDetail_Repository repo = new A_GetResourceDetail_Repository();
            if (repo.UpdateResource(updatedResource, categoryId, _bookId, txtDescription.Text))
            {
                MessageBox.Show("Changes saved successfully!");

                originalData = repo.GetResourceDetails(_bookId);
                btnSave.Enabled = false;

                this.DialogResult = DialogResult.OK;
            }
        }

        private void A_EditResource_Load(object sender, EventArgs e)
        {
            A_GetResourceDetail_Repository repo = new A_GetResourceDetail_Repository();

            originalData = repo.GetResourceDetails(_bookId);
            if (originalData != null)
            {
                lblBookID.Text = _bookId; 
                txtISBN.Text = originalData["ISBN"].ToString();
                txtTitle.Text = originalData["Title"].ToString();
                txtAuthor.Text = originalData["Author"].ToString();
                txtPublisher.Text = originalData["Publisher"].ToString();

                numPubYear.Value = Convert.ToDecimal(originalData["PublicationYear"]);
                cmbCategory.SelectedValue = originalData["CategoryId"];

                txtDescription.Text = originalData["Description"]?.ToString() ?? "";

                txtISBN.TextChanged += CheckForChanges;
                txtTitle.TextChanged += CheckForChanges;
                txtAuthor.TextChanged += CheckForChanges;
                txtPublisher.TextChanged += CheckForChanges;
                numPubYear.TextChanged += CheckForChanges;
                cmbCategory.SelectedIndexChanged += CheckForChanges;
                txtDescription.TextChanged += CheckForChanges;

                btnSave.Enabled = false;


            }

            A_AddResource_Repository repos = new A_AddResource_Repository();
            try
            {
                DataTable dt = repos.GetCategories();
                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "CategoryId";
                cmbCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading member types: " + ex.Message);
            }

        }
    
    }
}
