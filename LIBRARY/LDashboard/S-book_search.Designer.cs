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
            this.flpCopyStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlContainerA = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCopies = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.publisher = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccessionBase = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.pnlBookSearch.SuspendLayout();
            this.pnlContainerA.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(450, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 17);
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
            this.panel7.Location = new System.Drawing.Point(17, 245);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1130, 340);
            this.panel7.TabIndex = 34;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::LIBRARY.Properties.Resources.Icon__29_;
            this.pictureBox7.Location = new System.Drawing.Point(515, 81);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 18);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(63, 62);
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(417, 161);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 0, 3, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(276, 21);
            this.label19.TabIndex = 2;
            this.label19.Text = "Enter a Book ID, title, or ISBN to search";
            // 
            // pnlBookSearch
            // 
            this.pnlBookSearch.AutoScroll = true;
            this.pnlBookSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlBookSearch.Controls.Add(this.panel5);
            this.pnlBookSearch.Controls.Add(this.flpCopyStatus);
            this.pnlBookSearch.Controls.Add(this.pnlContainerA);
            this.pnlBookSearch.Controls.Add(this.panel7);
            this.pnlBookSearch.Controls.Add(this.panel6);
            this.pnlBookSearch.Controls.Add(this.label8);
            this.pnlBookSearch.Controls.Add(this.label9);
            this.pnlBookSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBookSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlBookSearch.Name = "pnlBookSearch";
            this.pnlBookSearch.Size = new System.Drawing.Size(1180, 1140);
            this.pnlBookSearch.TabIndex = 35;
            this.pnlBookSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBookSearch_Paint);
            // 
            // flpCopyStatus
            // 
            this.flpCopyStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flpCopyStatus.AutoScroll = true;
            this.flpCopyStatus.BackColor = System.Drawing.Color.White;
            this.flpCopyStatus.Location = new System.Drawing.Point(17, 750);
            this.flpCopyStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpCopyStatus.Name = "flpCopyStatus";
            this.flpCopyStatus.Size = new System.Drawing.Size(1130, 336);
            this.flpCopyStatus.TabIndex = 0;
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
            this.pnlContainerA.Location = new System.Drawing.Point(17, 245);
            this.pnlContainerA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlContainerA.Name = "pnlContainerA";
            this.pnlContainerA.Size = new System.Drawing.Size(1130, 477);
            this.pnlContainerA.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.Cornsilk;
            this.panel3.Controls.Add(this.lblBorrowed);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(862, 357);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 98);
            this.panel3.TabIndex = 28;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // lblBorrowed
            // 
            this.lblBorrowed.AutoSize = true;
            this.lblBorrowed.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBorrowed.Location = new System.Drawing.Point(31, 50);
            this.lblBorrowed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Size = new System.Drawing.Size(23, 25);
            this.lblBorrowed.TabIndex = 4;
            this.lblBorrowed.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Cornsilk;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Olive;
            this.label11.Location = new System.Drawing.Point(25, 17);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "Borrowed";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.lblAvailable);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(612, 357);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 98);
            this.panel2.TabIndex = 27;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblAvailable.Location = new System.Drawing.Point(31, 50);
            this.lblAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(23, 25);
            this.lblAvailable.TabIndex = 4;
            this.lblAvailable.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Honeydew;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(25, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Available";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel4.BackColor = System.Drawing.Color.AliceBlue;
            this.panel4.Controls.Add(this.lblCopies);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(358, 357);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 98);
            this.panel4.TabIndex = 26;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopies.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCopies.Location = new System.Drawing.Point(32, 50);
            this.lblCopies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(23, 25);
            this.lblCopies.TabIndex = 4;
            this.lblCopies.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(25, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Copies";
            // 
            // publisher
            // 
            this.publisher.AutoSize = true;
            this.publisher.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisher.ForeColor = System.Drawing.Color.Gray;
            this.publisher.Location = new System.Drawing.Point(709, 228);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(65, 19);
            this.publisher.TabIndex = 25;
            this.publisher.Text = "publisher";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(708, 256);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(19, 20);
            this.lblPublisher.TabIndex = 24;
            this.lblPublisher.Text = "A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(709, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "ISBN";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(708, 184);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(67, 20);
            this.lblISBN.TabIndex = 22;
            this.lblISBN.Text = "LIB-0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(355, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Year";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(354, 322);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(41, 20);
            this.lblYear.TabIndex = 20;
            this.lblYear.Text = "2000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(355, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Category";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(354, 256);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(19, 20);
            this.lblCategory.TabIndex = 18;
            this.lblCategory.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(355, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Book ID";
            // 
            // lblAccessionBase
            // 
            this.lblAccessionBase.AutoSize = true;
            this.lblAccessionBase.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessionBase.Location = new System.Drawing.Point(354, 184);
            this.lblAccessionBase.Name = "lblAccessionBase";
            this.lblAccessionBase.Size = new System.Drawing.Size(67, 20);
            this.lblAccessionBase.TabIndex = 16;
            this.lblAccessionBase.Text = "LIB-0000";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.Gray;
            this.lblAuthor.Location = new System.Drawing.Point(355, 109);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(52, 19);
            this.lblAuthor.TabIndex = 15;
            this.lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(353, 71);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 25);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Book Information";
            // 
            // pbProfile
            // 
            this.pbProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pbProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbProfile.ImageLocation = "";
            this.pbProfile.Location = new System.Drawing.Point(70, 63);
            this.pbProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(200, 231);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfile.TabIndex = 9;
            this.pbProfile.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.btnSearch);
            this.panel6.Location = new System.Drawing.Point(12, 110);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1144, 112);
            this.panel6.TabIndex = 30;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(25, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 51);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(9, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(972, 26);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SlateGray;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1029, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 51);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Book Search";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(13, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Check for books and check availability";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 1086);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1163, 100);
            this.panel5.TabIndex = 35;
            // 
            // S_book_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBookSearch);
            this.Name = "S_book_search";
            this.Size = new System.Drawing.Size(1180, 1140);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.pnlBookSearch.ResumeLayout(false);
            this.pnlBookSearch.PerformLayout();
            this.pnlContainerA.ResumeLayout(false);
            this.pnlContainerA.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel5;
    }
}
