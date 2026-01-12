using LIBRARY.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LIBRARY.MDashboard
{
    public partial class BookCardControl : UserControl
    {
        private Resource _bookData;

        public string BookTitle
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public string Author
        {
            get => lblAuthor.Text;
            set => lblAuthor.Text = value;
        }

        public string Category
        {
            get => lblCategory.Text;
            set => lblCategory.Text = value;
        }

        public string AvailabilityText
        {
            get => lblAvailability.Text;
            set => lblAvailability.Text = value;
        }
        public BookCardControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackColor = Color.White;
            this.Padding = new Padding(10);
        }

        private void BookCardControl_Load(object sender, EventArgs e)
        {

        }

        public void PopulateData(Resource book, int available, int total)
        {
            _bookData = book;
            lblTitle.Text = book.Title;
            lblAuthor.Text = book.Author;
            lblCategory.Text = book.ResourceType;
            lblAvailability.Text = $"{available} / {total}";

            lblAvailability.ForeColor = available > 0 ? Color.SeaGreen : Color.Tomato;

            string path = book.GetFullImagePath();
            if (File.Exists(path))
            {
                using (var tempImg = Image.FromFile(path))
                {
                    pbCover.Image = new Bitmap(tempImg);
                }
            }
            else
            {
                pbCover.Image = Properties.Resources.DefaultBookCover;
            }
        }

        public int GetResourceId() => _bookData.ResourceId;
    

    protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int radius = 20;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);

                using (Pen pen = new Pen(Color.FromArgb(230, 230, 230), 1))
                {
                    g.DrawPath(pen, path);
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
        }
    }
}
