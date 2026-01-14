namespace LIBRARY.ADashboard
{
    partial class FullInventory_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullInventory_UC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTypes = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.dgvInventoryGrid = new System.Windows.Forms.DataGridView();
            this.BookDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.cmbStatus);
            this.panel9.Controls.Add(this.pictureBox5);
            this.panel9.Controls.Add(this.txtSearch);
            this.panel9.Controls.Add(this.lblTypes);
            this.panel9.Controls.Add(this.cmbCategory);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1617, 117);
            this.panel9.TabIndex = 33;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1339, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(1341, 60);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(217, 24);
            this.cmbStatus.TabIndex = 9;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(55, 41);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(101, 41);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(869, 43);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypes.Location = new System.Drawing.Point(1041, 41);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(74, 19);
            this.lblTypes.TabIndex = 3;
            this.lblTypes.Text = "Categories";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(1044, 60);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(217, 24);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // dgvInventoryGrid
            // 
            this.dgvInventoryGrid.AllowUserToAddRows = false;
            this.dgvInventoryGrid.AllowUserToResizeColumns = false;
            this.dgvInventoryGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvInventoryGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryGrid.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookDetails,
            this.Category,
            this.StockStatus,
            this.Condition,
            this.AddCol,
            this.DeleteCol});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInventoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventoryGrid.Location = new System.Drawing.Point(0, 117);
            this.dgvInventoryGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInventoryGrid.Name = "dgvInventoryGrid";
            this.dgvInventoryGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvInventoryGrid.RowHeadersVisible = false;
            this.dgvInventoryGrid.RowHeadersWidth = 51;
            this.dgvInventoryGrid.RowTemplate.Height = 40;
            this.dgvInventoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryGrid.Size = new System.Drawing.Size(1617, 647);
            this.dgvInventoryGrid.TabIndex = 34;
            this.dgvInventoryGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryGrid_CellContentClick);
            this.dgvInventoryGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInventoryGrid_CellFormatting_1);
            // 
            // BookDetails
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.BookDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.BookDetails.FillWeight = 123.6588F;
            this.BookDetails.HeaderText = "Book Details";
            this.BookDetails.MinimumWidth = 6;
            this.BookDetails.Name = "BookDetails";
            this.BookDetails.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Category.DefaultCellStyle = dataGridViewCellStyle4;
            this.Category.FillWeight = 123.6588F;
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // StockStatus
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.StockStatus.DefaultCellStyle = dataGridViewCellStyle5;
            this.StockStatus.FillWeight = 123.6588F;
            this.StockStatus.HeaderText = "Stock Status";
            this.StockStatus.MinimumWidth = 6;
            this.StockStatus.Name = "StockStatus";
            this.StockStatus.ReadOnly = true;
            // 
            // Condition
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Condition.DefaultCellStyle = dataGridViewCellStyle6;
            this.Condition.FillWeight = 123.6588F;
            this.Condition.HeaderText = "Condition";
            this.Condition.MinimumWidth = 6;
            this.Condition.Name = "Condition";
            this.Condition.ReadOnly = true;
            // 
            // AddCol
            // 
            this.AddCol.FillWeight = 57.15382F;
            this.AddCol.HeaderText = "Actions";
            this.AddCol.MinimumWidth = 6;
            this.AddCol.Name = "AddCol";
            this.AddCol.ReadOnly = true;
            this.AddCol.Text = "Add";
            this.AddCol.UseColumnTextForButtonValue = true;
            // 
            // DeleteCol
            // 
            this.DeleteCol.FillWeight = 48.12835F;
            this.DeleteCol.HeaderText = "";
            this.DeleteCol.MinimumWidth = 6;
            this.DeleteCol.Name = "DeleteCol";
            this.DeleteCol.Text = "Delete";
            this.DeleteCol.UseColumnTextForButtonValue = true;
            // 
            // FullInventory_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.dgvInventoryGrid);
            this.Controls.Add(this.panel9);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FullInventory_UC";
            this.Size = new System.Drawing.Size(1617, 764);
            this.Load += new System.EventHandler(this.FullInventory_UC_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridView dgvInventoryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewButtonColumn AddCol;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteCol;
    }
}
