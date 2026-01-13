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
                Resource newresource = new Resource();
                newresource.ISBN = txtISBN.Text;
                newresource.Title = txtTitle.Text;
                newresource.Author = txtAuthor.Text;
                newresource.PublisherName = txtPublisher.Text; 
                newresource.PublicationYear = (int)numYear.Value;
                newresource.Edition = txtEdition.Text;
                newresource.Language = txtLanguage.Text;
                newresource.Description = txtDescription.Text;
                newresource.Location = txtLocation.Text;

                int pagesValue;
                int.TryParse(txtPages.Text, out pagesValue); 
                newresource.Pages = pagesValue;

                int copiesValue;
                int.TryParse(txtCopies.Text, out copiesValue); 
                int copies = copiesValue;

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
