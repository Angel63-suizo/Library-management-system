namespace LIBRARY.MDashboard
{
    partial class frmBookDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPubYear = new System.Windows.Forms.Label();
            this.LBLISBN = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cat = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.SlateGray;
            this.btnReserve.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.Color.White;
            this.btnReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReserve.Location = new System.Drawing.Point(689, 463);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(4);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(159, 46);
            this.btnReserve.TabIndex = 40;
            this.btnReserve.Text = "Reserve Book";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click_1);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(25, 383);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(719, 23);
            this.lblDescription.TabIndex = 38;
            this.lblDescription.Text = "A comprehensive textbook on computer algorithms covering a wide range of topics i" +
    "n depth.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 341);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 32);
            this.label9.TabIndex = 37;
            this.label9.Text = "Description";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Honeydew;
            this.panel3.Controls.Add(this.lblAvailability);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(305, 233);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 81);
            this.panel3.TabIndex = 36;
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAvailability.Location = new System.Drawing.Point(19, 38);
            this.lblAvailability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(208, 25);
            this.lblAvailability.TabIndex = 1;
            this.lblAvailability.Text = "7 of 10 copies available";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Available Now";
            // 
            // lblPubYear
            // 
            this.lblPubYear.AutoSize = true;
            this.lblPubYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPubYear.ForeColor = System.Drawing.Color.DimGray;
            this.lblPubYear.Location = new System.Drawing.Point(301, 186);
            this.lblPubYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPubYear.Name = "lblPubYear";
            this.lblPubYear.Size = new System.Drawing.Size(129, 23);
            this.lblPubYear.TabIndex = 35;
            this.lblPubYear.Text = "Published: 2009";
            // 
            // LBLISBN
            // 
            this.LBLISBN.AutoSize = true;
            this.LBLISBN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLISBN.ForeColor = System.Drawing.Color.DimGray;
            this.LBLISBN.Location = new System.Drawing.Point(301, 145);
            this.LBLISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLISBN.Name = "LBLISBN";
            this.LBLISBN.Size = new System.Drawing.Size(180, 23);
            this.LBLISBN.TabIndex = 34;
            this.LBLISBN.Text = "ISBN: 978-0262033848";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.lblCategory);
            this.panel2.Location = new System.Drawing.Point(387, 98);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 28);
            this.panel2.TabIndex = 33;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Blue;
            this.lblCategory.Location = new System.Drawing.Point(4, 5);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(129, 20);
            this.lblCategory.TabIndex = 22;
            this.lblCategory.Text = "Computer Science";
            // 
            // cat
            // 
            this.cat.AutoSize = true;
            this.cat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat.ForeColor = System.Drawing.Color.DimGray;
            this.cat.Location = new System.Drawing.Point(301, 103);
            this.cat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(72, 20);
            this.cat.TabIndex = 32;
            this.cat.Text = "Category:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.DimGray;
            this.lblAuthor.Location = new System.Drawing.Point(301, 57);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(157, 23);
            this.lblAuthor.TabIndex = 31;
            this.lblAuthor.Text = "Thomas H. Cormen";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(300, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 25);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "Introduction to Algorithms";
            // 
            // pbCover
            // 
            this.pbCover.BackColor = System.Drawing.SystemColors.Control;
            this.pbCover.Image = global::LIBRARY.Properties.Resources.DefaultBookCover;
            this.pbCover.Location = new System.Drawing.Point(24, 7);
            this.pbCover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(249, 306);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCover.TabIndex = 29;
            this.pbCover.TabStop = false;
            // 
            // frmBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 517);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblPubYear);
            this.Controls.Add(this.LBLISBN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbCover);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBookDetails";
            this.Load += new System.EventHandler(this.frmBookDetails_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPubYear;
        private System.Windows.Forms.Label LBLISBN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label cat;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbCover;
    }
}