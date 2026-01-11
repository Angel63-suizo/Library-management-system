using LIBRARY.Class;
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
using System.IO;

namespace LIBRARY.MDashboard
{
    public partial class frmConfirmReservation : Form
    {
        private MemberType LoggedInMember;
        private Resource currentBook;
        private Catalog_Repository _repo = new Catalog_Repository();
        public frmConfirmReservation(MemberType member, Resource book)
        {
            InitializeComponent();
            this.LoggedInMember = member;
            this.currentBook = book;

            lblTitle.Text = book.Title;
            lblAuthor.Text = book.Author;
            lblReservationDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lblExpiryDate.Text = "Calculated on confirm";
            lblUserName.Text = LoggedInMember?.FullName ?? "Unknown User";

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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (currentBook == null || LoggedInMember == null)
            {
                MessageBox.Show("Missing data for reservation.");
                return;
            }

            bool success = _repo.ReserveBook(LoggedInMember.MemberId, currentBook.ResourceId);

            if (success)
            {
                MessageBox.Show("Reservation Confirmed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No available copies found or reservation failed.", "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmConfirmReservation_Load(object sender, EventArgs e)
        {

        }
    }
}
