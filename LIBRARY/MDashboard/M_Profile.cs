using ExCSS;
using LIBRARY.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace LIBRARY.MDashboard
{
    public partial class M_Profile : UserControl
    {
        public M_Profile()
        {
            InitializeComponent();
           /* CurrentUser = user;

            //editable
            Usernametxt.Text = CurrentUser.Username;
            Emailtxt.Text = CurrentUser.Email;
            Contacttxt.Text = CurrentUser.contactNumber;
            Addresstxt.Text = CurrentUser.Address;


            //fixed
            lblCardNumber.Text = CurrentUser.MemberId.ToString("D8");
            lblEmail.Text = CurrentUser.Email;
            lblFullname.Text = CurrentUser.FirstName + " " + CurrentUser.LastName;
            MemberTypelbl.Text = CurrentUser.MemberRole;
            lblMemberStatus.Text = CurrentUser.Status;
            lblRegisterDate.Text = CurrentUser.RegisterDate.ToString("MMMM dd, yyyy");
            lblExpirationDate.Text = CurrentUser.ExpirationDate.ToString("MMMM dd, yyyy");
            picProfilePhoto.Text = CurrentUser.Photo != null ? "Photo Uploaded" : "No Photo";

            MemberType memberType = MemberType.GetMemberTypeById(CurrentUser.MemberTypeId);
            lblMaxBorrowed.Text = memberType.Maxborrow.ToString();
            lblBorrowingDuration.Text = memberType.Borrowdays.ToString() + " days";
            lblRenewalLimit.Text = memberType.Accesslevel.ToString() + " times";
            lblReservationPrivileges.Text = memberType.Maxreserve.ToString();
           */
        }

        private void M_Profile_Load(object sender, EventArgs e)
        {
           
            //LoadProfile();
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        /*private void LoadProfile()
        {
            lblEmail.Text = CurrentUser.Email;
            Usernametxt.Text = CurrentUser.Username;
            Emailtxt.Text = CurrentUser.Email;
            Contacttxt.Text = CurrentUser.contactNumber;
            Addresstxt.Text = CurrentUser.Address;

            if (CurrentUser.Photo == null || CurrentUser.Photo.Length == 0)
            {
                picProfilePhoto.Image = Properties.Resources.DefaultAvatar;
                picProfilePhoto.Text = "No Photo";
                return;
            }

            try
            {
                using (var ms = new MemoryStream(CurrentUser.Photo))
                {
                    picProfilePhoto.Image = Image.FromStream(ms);
                }
                picProfilePhoto.Text = "Photo Uploaded";
            }
            catch
            {
                picProfilePhoto.Image = Properties.Resources.DefaultAvatar;
                picProfilePhoto.Text = "Invalid Photo";
            }
        }*/


        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            /*using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                Image selectedImage;

                try
                {
                    selectedImage = Image.FromFile(ofd.FileName); 
                }
                catch
                {
                    MessageBox.Show("Failed to load image.");
                    return;
                }

                if (selectedImage == null)
                    return;

                // Open cropper
                using (var cropper = new PhotoCropperForm(selectedImage))
                { 
                    //kani kay mao na ang ang mag crop sa picture
                    if (cropper.ShowDialog() == DialogResult.OK)
                    {
                        // walon niya ang daan na picture
                        picProfilePhoto.Image?.Dispose();

                        picProfilePhoto.Image = (Image)cropper.Tag;

                        // i save ang bago na picture sa database
                        CurrentUser.Photo = ImageToByteArray(picProfilePhoto.Image);

                        var repo = new ProfileUpdate_Repository();
                        repo.UpdateUserProfile(CurrentUser);

                        MessageBox.Show("Profile photo updated successfully!");
                    }
                }

                
                selectedImage.Dispose();
            }*/
        }

        /*private Image ResizeImage(Image img, int width, int height)
        {
            //alisdan ang size sa picture para maigo
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }


        private byte[] ImageToByteArray(Image img)
        {
            if (img == null)
                return null;

            using (var ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png); 
                return ms.ToArray();
            }
        }*/

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnUsernameUpdate_Click(object sender, EventArgs e)
        {
            /*if (Usernametxt.Text.Trim() != CurrentUser.Username)
            {
                try
                {
                    var userRepo = new ProfileUpdate_Repository();
                    userRepo.UpdateUsername(CurrentUser.UserId, Usernametxt.Text);

                    CurrentUser.Username = Usernametxt.Text;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            MessageBox.Show("Username updated successfully.");*/

        }

        private void btnProfileUpdate_Click(object sender, EventArgs e)
        {
            /*Member updatedUser = new Member
            {
                UserId = CurrentUser.UserId,   
                contactNumber = string.IsNullOrWhiteSpace(Contacttxt.Text) ? null : Contacttxt.Text,
                Email = string.IsNullOrWhiteSpace(Emailtxt.Text) ? null : Emailtxt.Text,
                Address = string.IsNullOrWhiteSpace(Addresstxt.Text) ? null : Addresstxt.Text,
                Photo = CurrentUser.Photo
            };


            ProfileUpdate_Repository repo = new ProfileUpdate_Repository();
            bool success = repo.UpdateUserProfile(updatedUser);

            if (!success)
            {
                MessageBox.Show("Profile update failed.");
                return;
            }
            CurrentUser.contactNumber = updatedUser.contactNumber ?? CurrentUser.contactNumber;
            CurrentUser.Email = updatedUser.Email ?? CurrentUser.Email;
            CurrentUser.Address = updatedUser.Address ?? CurrentUser.Address;
            lblEmail.Text = CurrentUser.Email;

            MessageBox.Show("Profile updated successfully.");*/
        }

    }
}


