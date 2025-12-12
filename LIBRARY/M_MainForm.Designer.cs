namespace LIBRARY
{
    partial class M_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_MainForm));
            this.pnlSidebar1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSidebar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar1
            // 
            this.pnlSidebar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pnlSidebar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSidebar1.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlSidebar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar1.Controls.Add(this.btnLogout);
            this.pnlSidebar1.Controls.Add(this.btnProfile);
            this.pnlSidebar1.Controls.Add(this.btnDashboard);
            this.pnlSidebar1.Controls.Add(this.btnBorrow);
            this.pnlSidebar1.Controls.Add(this.btnReserve);
            this.pnlSidebar1.Controls.Add(this.btnSearchBook);
            this.pnlSidebar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar1.Location = new System.Drawing.Point(0, 60);
            this.pnlSidebar1.Name = "pnlSidebar1";
            this.pnlSidebar1.Padding = new System.Windows.Forms.Padding(0, 40, 0, 50);
            this.pnlSidebar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlSidebar1.Size = new System.Drawing.Size(270, 995);
            this.pnlSidebar1.TabIndex = 22;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLogout.BackColor = System.Drawing.Color.SlateGray;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(11, 869);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(242, 70);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnProfile.BackColor = System.Drawing.Color.SlateGray;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(11, 63);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 30, 3, 20);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(242, 74);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "   Profile";
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDashboard.BackColor = System.Drawing.Color.SlateGray;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(11, 143);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnDashboard.Size = new System.Drawing.Size(242, 75);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "    Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBorrow.BackColor = System.Drawing.Color.SlateGray;
            this.btnBorrow.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnBorrow.FlatAppearance.BorderSize = 0;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.White;
            this.btnBorrow.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrow.Image")));
            this.btnBorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrow.Location = new System.Drawing.Point(11, 399);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(242, 77);
            this.btnBorrow.TabIndex = 0;
            this.btnBorrow.Text = "   Borrowed Books";
            this.btnBorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrow.UseVisualStyleBackColor = false;
            // 
            // btnReserve
            // 
            this.btnReserve.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReserve.BackColor = System.Drawing.Color.SlateGray;
            this.btnReserve.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnReserve.FlatAppearance.BorderSize = 0;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.Color.White;
            this.btnReserve.Image = ((System.Drawing.Image)(resources.GetObject("btnReserve.Image")));
            this.btnReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReserve.Location = new System.Drawing.Point(11, 311);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(242, 80);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "   Reservations";
            this.btnReserve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReserve.UseVisualStyleBackColor = false;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchBook.BackColor = System.Drawing.Color.SlateGray;
            this.btnSearchBook.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnSearchBook.FlatAppearance.BorderSize = 0;
            this.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBook.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.ForeColor = System.Drawing.Color.White;
            this.btnSearchBook.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchBook.Image")));
            this.btnSearchBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchBook.Location = new System.Drawing.Point(11, 223);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(242, 81);
            this.btnSearchBook.TabIndex = 2;
            this.btnSearchBook.Text = "   Search Books";
            this.btnSearchBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchBook.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 60);
            this.panel1.TabIndex = 23;
            // 
            // M_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pnlSidebar1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "M_MainForm";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.M_MainForm_Load);
            this.pnlSidebar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Panel panel1;
    }
}