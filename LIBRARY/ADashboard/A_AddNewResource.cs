using Fizzler;
using LIBRARY.Class;
using LIBRARY.Models;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.ADashboard
{
    public partial class A_AddNewResource : Form
    {
        private Admin LoggedInAdmin;
        public A_AddNewResource(Admin admin)
        {
            InitializeComponent();
            LoggedInAdmin = admin;
        }

        public event EventHandler DataSaved;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Resource newresource = new Resource
                {
                    ISBN = txtISBN.Text,
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    PublisherName = txtPublisher.Text,
                    PublicationYear = (int)numYear.Value,
                    Edition = txtEdition.Text,
                    Language = txtLanguage.Text,
                    Description = txtDescription.Text,
                    Location = txtLocation.Text,
                    Pages = int.TryParse(txtPages.Text, out int p) ? p : 0
                };

                int copiesValue = int.TryParse(txtCopies.Text, out int c) ? c : 1;
                int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);

                string resultAccession = LoggedInAdmin.AddResourceToCatalog(newresource, categoryId, cmbResourceType.Text, copiesValue);

                if (!string.IsNullOrEmpty(resultAccession))
                {
                    MessageBox.Show($"Resource added successfully!\nBase Accession: {resultAccession}",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataSaved?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add resource. Please verify that the ISBN is unique and all required fields are filled.",
                                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Critical Error: " + ex.Message);
            }

        }

        private void A_AddNewResource_Load(object sender, EventArgs e)
        {
            CatalogManager repo = new CatalogManager();
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
