using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.MDashboard
{
    public partial class PhotoCropperForm : Form
    {
        private Image originalImage;
        private float zoom = 1.0f;
        private Point imagePosition = new Point(0, 0);
        private bool dragging = false;
        private Point dragStart;

        public PhotoCropperForm(Image image)
        {
            InitializeComponent();
            originalImage = new Bitmap(image);

            picCrop.Paint += PicCrop_Paint;
        }
        private void picCrop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragStart = e.Location;
        }

        private void picCrop_MouseMove(object sender, MouseEventArgs e)
        {
            if (!dragging) return;

            imagePosition.X += e.X - dragStart.X;
            imagePosition.Y += e.Y - dragStart.Y;
            dragStart = e.Location;
            picCrop.Invalidate();
        }

        private void picCrop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void PicCrop_Paint(object sender, PaintEventArgs e)
        {
            if (originalImage == null)
                return;

            try
            {
                int w = (int)(originalImage.Width * zoom);
                int h = (int)(originalImage.Height * zoom);

                e.Graphics.Clear(Color.Black);
                e.Graphics.DrawImage(
                    originalImage,
                    new Rectangle(imagePosition.X, imagePosition.Y, w, h));
            }
            catch
            {
                
            }
        }



        private void PhotoCropperForm_Load(object sender, EventArgs e)
        {
            trackZoom.Minimum = 50;
            trackZoom.Maximum = 200;
            trackZoom.Value = 50; 
            zoom = trackZoom.Value / 100f;
            CenterImage();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Bitmap cropped = new Bitmap(picCrop.Width, picCrop.Height);

            using (Graphics g = Graphics.FromImage(cropped))
            {
                g.Clear(Color.Black);
                int w = (int)(originalImage.Width * zoom);
                int h = (int)(originalImage.Height * zoom);

                g.DrawImage(originalImage,
                    new Rectangle(imagePosition.X, imagePosition.Y, w, h));
            }

            DialogResult = DialogResult.OK;
            Tag = cropped; 
            Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
{
        originalImage?.Dispose();
        base.OnFormClosed(e);
}

        private void trackZoom_Scroll_2(object sender, EventArgs e)
        {
            //i crop and picture tas e zoom
            zoom = trackZoom.Value / 100f;
            CenterImage();
            picCrop.Invalidate();
        }

        private void CenterImage()
        {
            if (originalImage == null) return;

            int w = (int)(originalImage.Width * zoom);
            int h = (int)(originalImage.Height * zoom);

            // kini kay ipatunga ang picture
            imagePosition.X = (picCrop.Width - w) / 2;
            imagePosition.Y = (picCrop.Height - h) / 2;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
