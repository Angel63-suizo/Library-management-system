namespace LIBRARY.ADashboard
{
    partial class A_AddNewResource
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbResourceType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCopies);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtPages);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtLanguage);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtEdition);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPublisher);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtISBN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 584);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.numYear);
            this.panel5.Location = new System.Drawing.Point(513, 329);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(423, 40);
            this.panel5.TabIndex = 49;
            // 
            // numYear
            // 
            this.numYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numYear.Location = new System.Drawing.Point(3, 13);
            this.numYear.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1901,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(415, 18);
            this.numYear.TabIndex = 48;
            this.numYear.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 652);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(983, 107);
            this.panel4.TabIndex = 47;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(571, 47);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 41);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SlateGray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(677, 47);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(259, 41);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbResourceType);
            this.panel3.Location = new System.Drawing.Point(53, 612);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 40);
            this.panel3.TabIndex = 46;
            // 
            // cmbResourceType
            // 
            this.cmbResourceType.BackColor = System.Drawing.SystemColors.Window;
            this.cmbResourceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbResourceType.FormattingEnabled = true;
            this.cmbResourceType.Location = new System.Drawing.Point(3, 11);
            this.cmbResourceType.Name = "cmbResourceType";
            this.cmbResourceType.Size = new System.Drawing.Size(415, 24);
            this.cmbResourceType.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 591);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Resource Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(510, 494);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Pages";
            // 
            // txtPages
            // 
            this.txtPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPages.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPages.Location = new System.Drawing.Point(513, 515);
            this.txtPages.Multiline = true;
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(423, 40);
            this.txtPages.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(510, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Language";
            // 
            // txtLanguage
            // 
            this.txtLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLanguage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanguage.Location = new System.Drawing.Point(513, 426);
            this.txtLanguage.Multiline = true;
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(423, 40);
            this.txtLanguage.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Edition";
            // 
            // txtEdition
            // 
            this.txtEdition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdition.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdition.Location = new System.Drawing.Point(53, 426);
            this.txtEdition.Multiline = true;
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(423, 40);
            this.txtEdition.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Location = new System.Drawing.Point(513, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 40);
            this.panel2.TabIndex = 34;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(3, 8);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(415, 24);
            this.cmbCategory.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Publication Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Publisher";
            // 
            // txtPublisher
            // 
            this.txtPublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPublisher.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(53, 329);
            this.txtPublisher.Multiline = true;
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(423, 40);
            this.txtPublisher.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(513, 140);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(423, 40);
            this.txtTitle.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthor.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(53, 237);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(423, 40);
            this.txtAuthor.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISBN.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(53, 140);
            this.txtISBN.Multiline = true;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(423, 40);
            this.txtISBN.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add New Book";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 591);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Copies";
            // 
            // txtCopies
            // 
            this.txtCopies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCopies.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopies.Location = new System.Drawing.Point(512, 612);
            this.txtCopies.Multiline = true;
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(423, 40);
            this.txtCopies.TabIndex = 50;
            // 
            // A_AddNewResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 584);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "A_AddNewResource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A_AddNewResource";
            this.Load += new System.EventHandler(this.A_AddNewResource_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbResourceType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCopies;
    }
}