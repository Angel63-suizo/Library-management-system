namespace LIBRARY
{
    partial class L_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(L_MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSidebar1 = new System.Windows.Forms.Panel();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnCirculation = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 60);
            this.panel1.TabIndex = 24;
            // 
            // pnlSidebar1
            // 
            this.pnlSidebar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pnlSidebar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSidebar1.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlSidebar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar1.Controls.Add(this.btnSearchBooks);
            this.pnlSidebar1.Controls.Add(this.btnLogout);
            this.pnlSidebar1.Controls.Add(this.btnProfile);
            this.pnlSidebar1.Controls.Add(this.btnDashboard);
            this.pnlSidebar1.Controls.Add(this.btnMembers);
            this.pnlSidebar1.Controls.Add(this.btnInventory);
            this.pnlSidebar1.Controls.Add(this.btnCirculation);
            this.pnlSidebar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar1.Location = new System.Drawing.Point(0, 60);
            this.pnlSidebar1.Name = "pnlSidebar1";
            this.pnlSidebar1.Padding = new System.Windows.Forms.Padding(0, 40, 0, 50);
            this.pnlSidebar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlSidebar1.Size = new System.Drawing.Size(270, 995);
            this.pnlSidebar1.TabIndex = 25;
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearchBooks.BackColor = System.Drawing.Color.SlateGray;
            this.btnSearchBooks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBooks.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBooks.ForeColor = System.Drawing.Color.White;
            this.btnSearchBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchBooks.Image")));
            this.btnSearchBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchBooks.Location = new System.Drawing.Point(11, 483);
            this.btnSearchBooks.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(242, 80);
            this.btnSearchBooks.TabIndex = 16;
            this.btnSearchBooks.Text = "   Search Books";
            this.btnSearchBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchBooks.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLogout.BackColor = System.Drawing.Color.SlateGray;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
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
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(11, 61);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 30, 3, 20);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(242, 74);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "   Profile";
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDashboard.BackColor = System.Drawing.Color.SlateGray;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
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
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnMembers
            // 
            this.btnMembers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMembers.BackColor = System.Drawing.Color.SlateGray;
            this.btnMembers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.Image")));
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(11, 224);
            this.btnMembers.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(242, 77);
            this.btnMembers.TabIndex = 0;
            this.btnMembers.Text = "   Members";
            this.btnMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembers.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            this.btnInventory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnInventory.BackColor = System.Drawing.Color.SlateGray;
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(11, 395);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(242, 80);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "   Inventory";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnCirculation
            // 
            this.btnCirculation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCirculation.BackColor = System.Drawing.Color.SlateGray;
            this.btnCirculation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCirculation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCirculation.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCirculation.ForeColor = System.Drawing.Color.White;
            this.btnCirculation.Image = ((System.Drawing.Image)(resources.GetObject("btnCirculation.Image")));
            this.btnCirculation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCirculation.Location = new System.Drawing.Point(11, 307);
            this.btnCirculation.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnCirculation.Name = "btnCirculation";
            this.btnCirculation.Size = new System.Drawing.Size(242, 81);
            this.btnCirculation.TabIndex = 2;
            this.btnCirculation.Text = "   Circulation";
            this.btnCirculation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCirculation.UseVisualStyleBackColor = false;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Black;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(270, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1654, 995);
            this.pnlContent.TabIndex = 27;
            // 
            // L_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "L_MainForm";
            this.Text = "L_MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.L_MainForm_Load);
            this.pnlSidebar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSidebar1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnCirculation;
        private System.Windows.Forms.Button btnSearchBooks;
        private System.Windows.Forms.Panel pnlContent;
    }
}