namespace LIBRARY.MDashboard
{
    partial class M_browse_catalog
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.pnlCombo = new System.Windows.Forms.Panel();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel20.SuspendLayout();
            this.pnlCombo.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(51, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search and discover books available in the library";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "Browse Catalog";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(9, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1120, 22);
            this.txtSearch.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel20);
            this.panel1.Controls.Add(this.pnlCombo);
            this.panel1.Location = new System.Drawing.Point(4, 144);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1520, 79);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.txtSearch);
            this.panel20.Location = new System.Drawing.Point(15, 17);
            this.panel20.Margin = new System.Windows.Forms.Padding(4);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(1143, 41);
            this.panel20.TabIndex = 6;
            this.panel20.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCombo_Paint);
            // 
            // pnlCombo
            // 
            this.pnlCombo.Controls.Add(this.cmbSearch);
            this.pnlCombo.Location = new System.Drawing.Point(1169, 17);
            this.pnlCombo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCombo.Name = "pnlCombo";
            this.pnlCombo.Size = new System.Drawing.Size(228, 41);
            this.pnlCombo.TabIndex = 7;
            this.pnlCombo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCombo_Paint);
            // 
            // cmbSearch
            // 
            this.cmbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(7, 5);
            this.cmbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(213, 29);
            this.cmbSearch.TabIndex = 6;
            this.cmbSearch.Text = "All Categories";
            this.cmbSearch.TextChanged += new System.EventHandler(this.cmbSearch_TextChanged);
            this.cmbSearch.Leave += new System.EventHandler(this.cmbCategory_Leave);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1099);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1524, 54);
            this.panel2.TabIndex = 23;
            // 
            // flowLayoutPanelBooks
            // 
            this.flowLayoutPanelBooks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanelBooks.AutoScroll = true;
            this.flowLayoutPanelBooks.Location = new System.Drawing.Point(55, 244);
            this.flowLayoutPanelBooks.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelBooks.Name = "flowLayoutPanelBooks";
            this.flowLayoutPanelBooks.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelBooks.Size = new System.Drawing.Size(1417, 855);
            this.flowLayoutPanelBooks.TabIndex = 24;
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Controls.Add(this.flowLayoutPanelBooks);
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.panel2);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1524, 1153);
            this.pnlContent.TabIndex = 25;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // M_browse_catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.pnlContent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "M_browse_catalog";
            this.Size = new System.Drawing.Size(1524, 1153);
            this.panel1.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.pnlCombo.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBooks;
        private System.Windows.Forms.Panel pnlCombo;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Panel pnlContent;
    }
}
