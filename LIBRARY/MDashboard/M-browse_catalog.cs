using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace LIBRARY.MDashboard
{
    public partial class M_browse_catalog : UserControl
    {
        private bool isSearchFocused = false;
        private bool isPanel20Hovered = false;

        private List<BookItem> books = new List<BookItem>();
        private List<string> originalItems = new List<string>();
        private bool isComboFocused = false;


        public M_browse_catalog()
        {
            InitializeComponent();
            LoadBooks();

            foreach (var item in cmbSearch.Items)
                originalItems.Add(item.ToString());

            txtSearch.TextChanged += TxtSearch_TextChanged;
            cmbSearch.SelectedIndexChanged += FilterBooks;
            cmbSearch.TextChanged += cmbSearch_TextChanged;

            txtSearch.Enter += (s, e) =>
            {
                isSearchFocused = true;
                panel20.Invalidate();
            };

            txtSearch.Leave += (s, e) =>
            {
                isSearchFocused = false;
                panel20.Invalidate();
            };

            cmbSearch.Enter += (s, e) =>
            {
                isSearchFocused = true;
                isComboFocused = true;
                panel20.Invalidate();
            };

            cmbSearch.Leave += (s, e) =>
            {
                isSearchFocused = false;
                isComboFocused = false;
                panel20.Invalidate();
            };

            panel20.Paint += DrawCustomBorder;
        }

        private class BookItem
        {
            public Panel Container;
            public string Title;
            public string Author;
            public string Category;
        }

        private void LoadBooks()
        {
            books.Add(new BookItem { Container = BookDetailsControl, Title = label3.Text, Author = label5.Text, Category = label4.Text });
            books.Add(new BookItem { Container = panel3, Title = label14.Text, Author = label13.Text, Category = label11.Text });
            books.Add(new BookItem { Container = panel4, Title = label20.Text, Author = label19.Text, Category = label6.Text });
            books.Add(new BookItem { Container = panel6, Title = label32.Text, Author = label31.Text, Category = label12.Text });
            books.Add(new BookItem { Container = panel5, Title = label26.Text, Author = label25.Text, Category = label23.Text });
            books.Add(new BookItem { Container = panel7, Title = label38.Text, Author = label37.Text, Category = label35.Text });

           
            foreach (var book in books)
                book.Container.Tag = $"{book.Title} {book.Author}".ToLower();
        }

        private void FilterBooks(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();
            string category = cmbSearch.Text;

            foreach (var book in books)
            {
                bool matchesSearch = book.Title.ToLower().StartsWith(search);
                bool matchesCategory = category == "All Categories" || book.Category.Equals(category, StringComparison.OrdinalIgnoreCase);

                book.Container.Visible = matchesSearch && matchesCategory;
            }

            ArrangeBooks();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterBooks(sender, e);
        }

        private void ArrangeBooks()
        {
            flowLayoutPanelBooks.SuspendLayout();
            flowLayoutPanelBooks.Controls.Clear();

            foreach (var book in books.Where(b => b.Container.Visible))
                flowLayoutPanelBooks.Controls.Add(book.Container);

            flowLayoutPanelBooks.ResumeLayout();
        }

        private void DrawCustomBorder(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            int radius = 16;
            int borderThickness = 1;
            Color borderColor = Color.FromArgb(220, 223, 230);

            if (panel.Name == "panel20" && (isPanel20Hovered || isSearchFocused))
            {
                borderColor = Color.FromArgb(55, 65, 81);
                borderThickness = 2;
            }

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(borderThickness, borderThickness,
                                           panel.Width - borderThickness * 2, panel.Height - borderThickness * 2);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                using (SolidBrush brush = new SolidBrush(panel.BackColor))
                    e.Graphics.FillPath(brush, path);

                panel.Region = new Region(path);

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
            if(!cmbSearch.Focused) return;

            string text = cmbSearch.Text.ToLower();

            cmbSearch.BeginUpdate();
            cmbSearch.Items.Clear();

            foreach (string item in originalItems)
            {
                if (item.ToLower().StartsWith(text))
                    cmbSearch.Items.Add(item);
            }

            cmbSearch.EndUpdate();

            cmbSearch.SelectionStart = cmbSearch.Text.Length;
            cmbSearch.DroppedDown = cmbSearch.Items.Count > 0;
        }

    }
}
