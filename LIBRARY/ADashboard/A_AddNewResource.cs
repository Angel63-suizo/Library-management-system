using ExCSS;
using Fizzler;
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

namespace LIBRARY.ADashboard
{
    public partial class A_AddNewResource : Form
    {
        public A_AddNewResource()
        {
            InitializeComponent();
        }

        public event EventHandler DataSaved;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Resource newresource = new Resource();
                newresource.ISBN = txtISBN.Text;
                newresource.Title = txtTitle.Text;
                newresource.Author = txtAuthor.Text;
                newresource.PublisherId = txtPublisher.Text; 
                newresource.PublicationYear = (int)numYear.Value;
                newresource.Edition = txtEdition.Text;
                newresource.Language = txtLanguage.Text;
                newresource.Pages = int.Parse(txtPages.Text);

                int copies = Convert.ToInt32(txtCopies.Text);

                int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);

                A_AddResource_Repository repo = new A_AddResource_Repository();
                repo.AddNewResource(newresource, categoryId, cmbResourceType.Text, copies);

                MessageBox.Show("Book added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input Error: " + ex.Message);
            }
            DataSaved?.Invoke(this, EventArgs.Empty);
            this.Close();

        }

        private void A_AddNewResource_Load(object sender, EventArgs e)
        {
            A_AddResource_Repository repo = new A_AddResource_Repository();
            try
            {
                DataTable dt = repo.GetCategories();
                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "CategoryId";
                cmbCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading member types: " + ex.Message);
            }

            cmbResourceType.DataSource = repo.GetResourceType("Resource", "ResourceType");
            cmbResourceType.SelectedItem = "EBook";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtISBN.Clear();
            txtAuthor.Clear();
            txtTitle.Clear();
            txtPublisher.Clear();
            txtEdition.Clear();
            txtLanguage.Clear();
            txtPages.Clear();
            numYear.Value = 2026;
            cmbResourceType.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
