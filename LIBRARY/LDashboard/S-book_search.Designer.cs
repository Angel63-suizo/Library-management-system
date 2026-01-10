namespace LIBRARY.LDashboard
{
    partial class S_book_search
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
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlBookSearch = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlContainerA = new System.Windows.Forms.Panel();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccessionBase = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.publisher = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCopies = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.flpCopyStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.pnlBookSearch.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlContainerA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(600, 246);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Try: B001, B002, or \"Clean Code\"";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.pictureBox7);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Location = new System.Drawing.Point(3, 302);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1507, 418);
            this.panel7.TabIndex = 34;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::LIBRARY.Properties.Resources.Icon__29_;
            this.pictureBox7.Location = new System.Drawing.Point(687, 100);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 22);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(84, 76);
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(556, 198);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(348, 28);
            this.label19.TabIndex = 2;
            this.label19.Text = "Enter a Book ID, title, or ISBN to search";
            // 
            // pnlBookSearch
            // 
            this.pnlBookSearch.AutoScroll = true;
            this.pnlBookSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlBookSearch.Controls.Add(this.flpCopyStatus);
            this.pnlBookSearch.Controls.Add(this.pnlContainerA);
            this.pnlBookSearch.Controls.Add(this.panel7);
            this.pnlBookSearch.Controls.Add(this.panel6);
            this.pnlBookSearch.Controls.Add(this.label8);
            this.pnlBookSearch.Controls.Add(this.label9);
            this.pnlBookSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBookSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlBookSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBookSearch.Name = "pnlBookSearch";
            this.pnlBookSearch.Size = new System.Drawing.Size(1533, 763);
            this.pnlBookSearch.TabIndex = 35;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.btnSearch);
            this.panel6.Location = new System.Drawing.Point(-4, 135);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1525, 138);
            this.panel6.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(33, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 62);
            this.panel1.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1296, 32);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SlateGray;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1372, 36);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 63);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-4, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Book Search";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(-2, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Check for books and check availability";
            // 
            // pnlContainerA
            // 
            this.pnlContainerA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlContainerA.BackColor = System.Drawing.Color.White;
            this.pnlContainerA.Controls.Add(this.panel3);
            this.pnlContainerA.Controls.Add(this.panel2);
            this.pnlContainerA.Controls.Add(this.panel4);
            this.pnlContainerA.Controls.Add(this.publisher);
            this.pnlContainerA.Controls.Add(this.lblPublisher);
            this.pnlContainerA.Controls.Add(this.label12);
            this.pnlContainerA.Controls.Add(this.lblISBN);
            this.pnlContainerA.Controls.Add(this.label4);
            this.pnlContainerA.Controls.Add(this.lblYear);
            this.pnlContainerA.Controls.Add(this.label2);
            this.pnlContainerA.Controls.Add(this.lblCategory);
            this.pnlContainerA.Controls.Add(this.label3);
            this.pnlContainerA.Controls.Add(this.lblAccessionBase);
            this.pnlContainerA.Controls.Add(this.lblAuthor);
            this.pnlContainerA.Controls.Add(this.lblTitle);
            this.pnlContainerA.Controls.Add(this.label1);
            this.pnlContainerA.Controls.Add(this.pbProfile);
            this.pnlContainerA.Location = new System.Drawing.Point(3, 302);
            this.pnlContainerA.Name = "pnlContainerA";
            this.pnlContainerA.Size = new System.Drawing.Size(1507, 587);
            this.pnlContainerA.TabIndex = 6;
            // 
            // pbProfile
            // 
            this.pbProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pbProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbProfile.ImageLocation = "";
            this.pbProfile.Location = new System.Drawing.Point(94, 77);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(267, 284);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfile.TabIndex = 9;
            this.pbProfile.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Book Information";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(471, 87);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 32);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Title";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(472, 315);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(24, 25);
            this.lblCategory.TabIndex = 18;
            this.lblCategory.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(473, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Book ID";
            // 
            // lblAccessionBase
            // 
            this.lblAccessionBase.AutoSize = true;
            this.lblAccessionBase.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessionBase.Location = new System.Drawing.Point(472, 226);
            this.lblAccessionBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccessionBase.Name = "lblAccessionBase";
            this.lblAccessionBase.Size = new System.Drawing.Size(85, 25);
            this.lblAccessionBase.TabIndex = 16;
            this.lblAccessionBase.Text = "LIB-0000";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.Gray;
            this.lblAuthor.Location = new System.Drawing.Point(473, 134);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(63, 23);
            this.lblAuthor.TabIndex = 15;
            this.lblAuthor.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(473, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(473, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Year";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(472, 396);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 25);
            this.lblYear.TabIndex = 20;
            this.lblYear.Text = "2000";
            // 
            // publisher
            // 
            this.publisher.AutoSize = true;
            this.publisher.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisher.ForeColor = System.Drawing.Color.Gray;
            this.publisher.Location = new System.Drawing.Point(945, 281);
            this.publisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(80, 23);
            this.publisher.TabIndex = 25;
            this.publisher.Text = "publisher";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(944, 315);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(24, 25);
            this.lblPublisher.TabIndex = 24;
            this.lblPublisher.Text = "A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(945, 193);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 23);
            this.label12.TabIndex = 23;
            this.label12.Text = "ISBN";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(944, 226);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(85, 25);
            this.lblISBN.TabIndex = 22;
            this.lblISBN.Text = "LIB-0000";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel4.BackColor = System.Drawing.Color.AliceBlue;
            this.panel4.Controls.Add(this.lblCopies);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(477, 439);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 121);
            this.panel4.TabIndex = 26;
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopies.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCopies.Location = new System.Drawing.Point(42, 61);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(27, 32);
            this.lblCopies.TabIndex = 4;
            this.lblCopies.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(33, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Copies";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.lblAvailable);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(816, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 121);
            this.panel2.TabIndex = 27;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblAvailable.Location = new System.Drawing.Point(41, 61);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(27, 32);
            this.lblAvailable.TabIndex = 4;
            this.lblAvailable.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Honeydew;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(33, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Available";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.Cornsilk;
            this.panel3.Controls.Add(this.lblBorrowed);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(1149, 439);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 121);
            this.panel3.TabIndex = 28;
            // 
            // lblBorrowed
            // 
            this.lblBorrowed.AutoSize = true;
            this.lblBorrowed.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBorrowed.Location = new System.Drawing.Point(41, 61);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Size = new System.Drawing.Size(27, 32);
            this.lblBorrowed.TabIndex = 4;
            this.lblBorrowed.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Cornsilk;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Olive;
            this.label11.Location = new System.Drawing.Point(33, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 28);
            this.label11.TabIndex = 3;
            this.label11.Text = "Borrowed";
            // 
            // flpCopyStatus
            // 
            this.flpCopyStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flpCopyStatus.AutoScroll = true;
            this.flpCopyStatus.BackColor = System.Drawing.Color.White;
            this.flpCopyStatus.Location = new System.Drawing.Point(3, 923);
            this.flpCopyStatus.Name = "flpCopyStatus";
            this.flpCopyStatus.Size = new System.Drawing.Size(1506, 413);
            this.flpCopyStatus.TabIndex = 0;
            // 
            // S_book_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBookSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "S_book_search";
            this.Size = new System.Drawing.Size(1533, 763);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.pnlBookSearch.ResumeLayout(false);
            this.pnlBookSearch.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlContainerA.ResumeLayout(false);
            this.pnlContainerA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel pnlBookSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlContainerA;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAccessionBase;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label publisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBorrowed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flpCopyStatus;
    }
}
