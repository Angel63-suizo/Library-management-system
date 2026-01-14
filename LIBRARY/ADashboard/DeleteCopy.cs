using LIBRARY.Class;
using Org.BouncyCastle.Asn1.X509;
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
using System.Windows.Forms.DataVisualization.Charting;
using static LIBRARY.ADashboard.AddCopy_Repository;

namespace LIBRARY.ADashboard
{
    public partial class DeleteCopy : Form
    {
        private Admin LoggedInAdmin;
        private string _booktitle;
        private readonly Delete_Repository _repo = new Delete_Repository();
        public DeleteCopy(Admin admin, string title, string available, string total)
        {
            InitializeComponent();
            LoggedInAdmin = admin;
            _booktitle = title;

            this.Text = "Remove Copies for: " + _booktitle;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string selectedAccession = cmbAccessionNumber.Text;

            if (string.IsNullOrEmpty(selectedAccession))
            {
                MessageBox.Show("Please select an Accession Number or 'All'.");
                return;
            }

            bool isRemoveAll = (selectedAccession == "All");

            string confirmMsg = isRemoveAll
                ? $"Are you sure you want to remove ALL copies of '{_booktitle}'?"
                : $"Remove copy {selectedAccession} from the system?";

            if (MessageBox.Show(confirmMsg, "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            var result = _repo.RemoveCopy(_booktitle, selectedAccession, isRemoveAll);

            if (result.Success)
            {
                MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void DeleteCopy_Load(object sender, EventArgs e)
        {
            UpdateAccessionList(_booktitle);
        }

        private void UpdateAccessionList(string title)
        {
            try
            {
                List<string> accessions = _repo.GetAccessionNumbers(title);

                cmbAccessionNumber.Items.Clear();
                cmbAccessionNumber.Items.Add("All");

                foreach (var acc in accessions)
                {
                    cmbAccessionNumber.Items.Add(acc);
                }

                if (cmbAccessionNumber.Items.Count > 0)
                    cmbAccessionNumber.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading Accessions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
