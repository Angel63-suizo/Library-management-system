namespace LIBRARY.LDashboard
{
    partial class S_book_lookup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblMemSearch = new System.Windows.Forms.Label();
            this.pnlMemberLookup = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.pnlMemberLookup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(23, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(360, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Search and view member information and borrowing history";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Member Lookup";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(9, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(921, 26);
            this.txtSearch.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.btnSearch);
            this.panel6.Location = new System.Drawing.Point(26, 110);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1094, 112);
            this.panel6.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(25, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 51);
            this.panel1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SlateGray;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(976, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 51);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(470, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Try: M001, M002, or M003";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.pictureBox7);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.lblMemSearch);
            this.panel7.Location = new System.Drawing.Point(26, 249);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1094, 340);
            this.panel7.TabIndex = 30;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::LIBRARY.Properties.Resources.Icon__29_;
            this.pictureBox7.Location = new System.Drawing.Point(523, 81);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 18);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(63, 62);
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // lblMemSearch
            // 
            this.lblMemSearch.AutoSize = true;
            this.lblMemSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemSearch.ForeColor = System.Drawing.Color.DimGray;
            this.lblMemSearch.Location = new System.Drawing.Point(417, 161);
            this.lblMemSearch.Margin = new System.Windows.Forms.Padding(3, 0, 3, 18);
            this.lblMemSearch.Name = "lblMemSearch";
            this.lblMemSearch.Size = new System.Drawing.Size(269, 21);
            this.lblMemSearch.TabIndex = 2;
            this.lblMemSearch.Text = "Enter a Member ID or name to search";
            this.lblMemSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMemberLookup
            // 
            this.pnlMemberLookup.AutoScroll = true;
            this.pnlMemberLookup.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlMemberLookup.Controls.Add(this.label9);
            this.pnlMemberLookup.Controls.Add(this.label8);
            this.pnlMemberLookup.Controls.Add(this.panel7);
            this.pnlMemberLookup.Controls.Add(this.panel6);
            this.pnlMemberLookup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMemberLookup.Location = new System.Drawing.Point(0, 0);
            this.pnlMemberLookup.Name = "pnlMemberLookup";
            this.pnlMemberLookup.Size = new System.Drawing.Size(1150, 620);
            this.pnlMemberLookup.TabIndex = 31;
            // 
            // S_book_lookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMemberLookup);
            this.Name = "S_book_lookup";
            this.Size = new System.Drawing.Size(1150, 620);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.pnlMemberLookup.ResumeLayout(false);
            this.pnlMemberLookup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblMemSearch;
        private System.Windows.Forms.Panel pnlMemberLookup;
        private System.Windows.Forms.Panel panel1;
    }
}
