namespace Member
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlSidebar1 = new System.Windows.Forms.Panel();
            this.btnProfile_Account = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBrowse_Catalog = new System.Windows.Forms.Button();
            this.btnMy_Books = new System.Windows.Forms.Button();
            this.btnBorrowingHistory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSidebar1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar1
            // 
            this.pnlSidebar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pnlSidebar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSidebar1.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlSidebar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar1.Controls.Add(this.btnProfile_Account);
            this.pnlSidebar1.Controls.Add(this.btnLogout);
            this.pnlSidebar1.Controls.Add(this.btnBrowse_Catalog);
            this.pnlSidebar1.Controls.Add(this.btnMy_Books);
            this.pnlSidebar1.Controls.Add(this.btnBorrowingHistory);
            this.pnlSidebar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar1.Location = new System.Drawing.Point(0, 49);
            this.pnlSidebar1.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSidebar1.Name = "pnlSidebar1";
            this.pnlSidebar1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 41);
            this.pnlSidebar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlSidebar1.Size = new System.Drawing.Size(203, 700);
            this.pnlSidebar1.TabIndex = 27;
            // 
            // btnProfile_Account
            // 
            this.btnProfile_Account.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProfile_Account.BackColor = System.Drawing.Color.SlateGray;
            this.btnProfile_Account.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProfile_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile_Account.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile_Account.ForeColor = System.Drawing.Color.White;
            this.btnProfile_Account.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile_Account.Image")));
            this.btnProfile_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile_Account.Location = new System.Drawing.Point(8, 51);
            this.btnProfile_Account.Margin = new System.Windows.Forms.Padding(2, 2, 2, 16);
            this.btnProfile_Account.Name = "btnProfile_Account";
            this.btnProfile_Account.Size = new System.Drawing.Size(182, 66);
            this.btnProfile_Account.TabIndex = 3;
            this.btnProfile_Account.Text = "   My Account";
            this.btnProfile_Account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile_Account.UseVisualStyleBackColor = false;
            this.btnProfile_Account.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLogout.BackColor = System.Drawing.Color.SlateGray;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(10, 623);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(182, 57);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnBrowse_Catalog
            // 
            this.btnBrowse_Catalog.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBrowse_Catalog.BackColor = System.Drawing.Color.SlateGray;
            this.btnBrowse_Catalog.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBrowse_Catalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse_Catalog.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse_Catalog.ForeColor = System.Drawing.Color.White;
            this.btnBrowse_Catalog.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse_Catalog.Image")));
            this.btnBrowse_Catalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse_Catalog.Location = new System.Drawing.Point(8, 135);
            this.btnBrowse_Catalog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 16);
            this.btnBrowse_Catalog.Name = "btnBrowse_Catalog";
            this.btnBrowse_Catalog.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.btnBrowse_Catalog.Size = new System.Drawing.Size(182, 61);
            this.btnBrowse_Catalog.TabIndex = 3;
            this.btnBrowse_Catalog.Text = "    Browse Catalog";
            this.btnBrowse_Catalog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowse_Catalog.UseVisualStyleBackColor = false;
            this.btnBrowse_Catalog.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnMy_Books
            // 
            this.btnMy_Books.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMy_Books.BackColor = System.Drawing.Color.SlateGray;
            this.btnMy_Books.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMy_Books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMy_Books.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMy_Books.ForeColor = System.Drawing.Color.White;
            this.btnMy_Books.Image = ((System.Drawing.Image)(resources.GetObject("btnMy_Books.Image")));
            this.btnMy_Books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMy_Books.Location = new System.Drawing.Point(8, 204);
            this.btnMy_Books.Margin = new System.Windows.Forms.Padding(2, 2, 2, 16);
            this.btnMy_Books.Name = "btnMy_Books";
            this.btnMy_Books.Size = new System.Drawing.Size(182, 63);
            this.btnMy_Books.TabIndex = 0;
            this.btnMy_Books.Text = "    My Books";
            this.btnMy_Books.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMy_Books.UseVisualStyleBackColor = false;
            this.btnMy_Books.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrowingHistory
            // 
            this.btnBorrowingHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrowingHistory.BackColor = System.Drawing.Color.SlateGray;
            this.btnBorrowingHistory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBorrowingHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowingHistory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowingHistory.ForeColor = System.Drawing.Color.White;
            this.btnBorrowingHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrowingHistory.Image")));
            this.btnBorrowingHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowingHistory.Location = new System.Drawing.Point(8, 285);
            this.btnBorrowingHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 16);
            this.btnBorrowingHistory.Name = "btnBorrowingHistory";
            this.btnBorrowingHistory.Size = new System.Drawing.Size(182, 66);
            this.btnBorrowingHistory.TabIndex = 2;
            this.btnBorrowingHistory.Text = "Borrowing History";
            this.btnBorrowingHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrowingHistory.UseVisualStyleBackColor = false;
            this.btnBorrowingHistory.Click += new System.EventHandler(this.btnBorrowingHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Location = new System.Drawing.Point(208, 54);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(2000, 788);
            this.panelMain.TabIndex = 28;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 49);
            this.panel1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.pnlSidebar1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlSidebar1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSidebar1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBrowse_Catalog;
        private System.Windows.Forms.Button btnMy_Books;
        private System.Windows.Forms.Button btnBorrowingHistory;
        private System.Windows.Forms.Button btnProfile_Account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
    }
}

