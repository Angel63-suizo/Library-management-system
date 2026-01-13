using LIBRARY.Class;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.ADashboard
{
    public partial class A_ResourceDetail : Form
    {
        private Admin LoggedInAdmin;
        private string _bookId;
        public A_ResourceDetail(Admin admin, String BookId)
        {
            InitializeComponent();
            LoggedInAdmin = admin;
            this._bookId = BookId;
        }

        private void A_ResourceDetail_Load(object sender, EventArgs e)
        {
            LoadResourceDetails();
        }

        private void LoadResourceDetails()
        {
            A_GetResourceDetail_Repository repo = new A_GetResourceDetail_Repository();
            DataRow details = repo.GetResourceDetails(_bookId);

            if (details != null)
            {
                lblTitle.Text = details["Title"].ToString();
                lblAuthor.Text = "by " + details["Author"].ToString();
                lblBookID.Text = _bookId;
                lblCategory.Text = details["Category"].ToString();
                lblDescription.Text = details["Description"].ToString();
                lblISBN.Text = details["ISBN"].ToString();
                lblPubYear.Text = details["PublicationYear"].ToString();
                lblTotalCopies.Text = details["TotalCopies"].ToString();
                lblAvailableCopies.Text = details["AvailableCopies"].ToString();
                lblCurrentlyBorrowed.Text = details["CurrentlyBorrowed"].ToString();
                lblPublisher.Text = details["Publisher"].ToString();
                lblLocation.Text = details["Location"].ToString();

                int available = Convert.ToInt32(details["AvailableCopies"]);
                lblStatus.Text = available > 0 ? "Available" : "Not Available";
                lblStatus.BackColor = available > 0 ? Color.LightGreen : Color.PeachPuff;
            }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
