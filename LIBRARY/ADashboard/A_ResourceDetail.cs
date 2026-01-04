using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.ADashboard
{
    public partial class A_ResourceDetail : Form
    {

        private string _bookId;
        public A_ResourceDetail(String BookId)
        {
            InitializeComponent();
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
                lblPublisher.Text = details["Publisher"].ToString();
                lblPubYear.Text = details["PublicationYear"].ToString();
                lblTotalCopies.Text = details["TotalCopies"].ToString();
                lblAvailableCopies.Text = details["AvailableCopies"].ToString();
                lblCurrentlyBorrowed.Text = details["CurrentlyBorrowed"].ToString();
                lblLocation.Text = details["Location"]?.ToString() ?? "N/A";

                int available = Convert.ToInt32(details["AvailableCopies"]);
                lblStatus.Text = available > 0 ? "Available" : "Not Available";
                lblStatus.BackColor = available > 0 ? Color.LightGreen : Color.PeachPuff;
            }
        }
    }
}
