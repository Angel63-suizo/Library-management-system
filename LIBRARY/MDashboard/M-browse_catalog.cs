using LIBRARY.ADashboard;
using LIBRARY.Class;
using LIBRARY.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace LIBRARY.MDashboard
{
    public partial class M_browse_catalog : UserControl
    {
        private MemberType LoggedInMember;
        private Catalog_Repository catalogRepo = new Catalog_Repository();
        private bool isSearchFocused = false;
        private bool isPanel20Hovered = false;


        public M_browse_catalog(MemberType member)
        {
            InitializeComponent();
            LoggedInMember = member;

            txtSearch.TextChanged += TxtSearch_TextChanged;
            cmbSearch.SelectedIndexChanged += (s, e) => LoadCatalog(); 

            txtSearch.Enter += (s, e) => { isSearchFocused = true; panel20.Invalidate(); };
            txtSearch.Leave += (s, e) => { isSearchFocused = false; panel20.Invalidate(); };
            panel20.Paint += DrawCustomBorder;

            PopulateCategories();
            LoadCatalog();
        }

        private void PopulateCategories()
        {
            try
            {
                A_AddResource_Repository repo = new A_AddResource_Repository();
                DataTable types = repo.GetCategories();

                cmbSearch.Items.Clear();
                cmbSearch.Items.Add("All Categories");

                if (types != null && types.Rows.Count > 0)
                {
                    foreach (DataRow row in types.Rows)
                    {
                        cmbSearch.Items.Add(row["Name"].ToString());
                    }
                }
                cmbSearch.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating Categories: " + ex.Message);
            }

        }

        private void LoadCatalog()
        {
            flowLayoutPanelBooks.SuspendLayout();
            flowLayoutPanelBooks.Controls.Clear();

            List<Resource> catalogItems = catalogRepo.GetCatalogItems(txtSearch.Text, cmbSearch.Text);

            foreach (Resource book in catalogItems)
            {
                BookCardControl card = new BookCardControl();

                card.PopulateData(book, book.AvailableCopies, book.TotalCopies);

                card.Click += (s, e) => {
                    frmBookDetails details = new frmBookDetails(LoggedInMember, book);
                    details.ShowDialog();

                };

                flowLayoutPanelBooks.Controls.Add(card);
            }

            flowLayoutPanelBooks.ResumeLayout();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCatalog();
        }

        private void DrawCustomBorder(object sender, PaintEventArgs e)
        {
            Control ctrl = (Control)sender;
            int radius = 16;
            int borderThickness = 1;
            Color borderColor = Color.FromArgb(220, 223, 230);

            if (ctrl.Name == "panel20" && (isPanel20Hovered || isSearchFocused))
            {
                borderColor = Color.FromArgb(55, 65, 81);
                borderThickness = 2;
            }

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
                    e.Graphics.DrawPath(pen, path);
            }
        }

        private void cmbCategory_Enter(object sender, EventArgs e)
        {
            pnlCombo.Invalidate();
        }

        private void cmbCategory_Leave(object sender, EventArgs e)
        {
            pnlCombo.Invalidate();
        }

        private void pnlCombo_Paint(object sender, PaintEventArgs e)
        {
            Color borderIdle = Color.LightGray;
            Color borderActive = Color.FromArgb(64, 64, 64);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(pnlCombo.Focused ? borderActive : borderIdle, 1))
            {
                Rectangle rect = pnlCombo.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
        private void cmbSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCatalog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
        }

        private void LoadUserControl(UserControl mem)
        {
            pnlContent.Controls.Clear();   
            mem.Dock = DockStyle.Fill;       
            pnlContent.Controls.Add(mem);  
            mem.BringToFront();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
