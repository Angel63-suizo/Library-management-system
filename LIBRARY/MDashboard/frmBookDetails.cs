using LIBRARY.Models;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LIBRARY.Class;

namespace LIBRARY.MDashboard
{
    public partial class frmBookDetails : Form
    {
        private MemberType LoggedInMember;
        private Resource currentBook;
        private Catalog_Repository _repo = new Catalog_Repository();
        public frmBookDetails(MemberType member, Resource book)
        {
            InitializeComponent();
            LoggedInMember = member;
            currentBook = book;
            LoadBookDetails();
        }

        private void frmBookDetails_Load(object sender, EventArgs e)
        {

        }

        private void LoadBookDetails()
        {
            var book = _repo.GetResourceDetails(currentBook.ResourceId);

            if (book != null)
            {
                lblTitle.Text = book.Title;
                lblAuthor.Text = book.Author;
                LBLISBN.Text = book.ISBN;
                lblCategory.Text = book.ResourceType;
                lblDescription.Text = book.Description;

                lblAvailability.Text = $"{book.AvailableCopies} of {book.TotalCopies} copies available";
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

                string fullInfo = book.GetDetails();
            }
        }

        private void btnReserve_Click_1(object sender, EventArgs e)
        {
            using (var confirm = new frmConfirmReservation(LoggedInMember, currentBook))
            {
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
