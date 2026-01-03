namespace LIBRARY.ADashboard
{
    partial class A_GridViewMember
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_GridViewMember));
            this.dgvMemberGrid = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnLibraryStaff = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblTypes = new System.Windows.Forms.Label();
            this.cmbMemberType = new System.Windows.Forms.ComboBox();
            this.colCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBooksOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ViewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberGrid)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMemberGrid
            // 
            this.dgvMemberGrid.AllowUserToAddRows = false;
            this.dgvMemberGrid.AllowUserToResizeColumns = false;
            this.dgvMemberGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvMemberGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMemberGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvMemberGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberGrid.BackgroundColor = System.Drawing.Color.White;
            this.dgvMemberGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMemberGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCardNumber,
            this.colName,
            this.colContact,
            this.colStatus,
            this.colBooksOut,
            this.colFines,
            this.EditCol,
            this.ViewCol,
            this.DeleteCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMemberGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMemberGrid.Location = new System.Drawing.Point(6, 135);
            this.dgvMemberGrid.Name = "dgvMemberGrid";
            this.dgvMemberGrid.RowHeadersVisible = false;
            this.dgvMemberGrid.RowHeadersWidth = 51;
            this.dgvMemberGrid.RowTemplate.Height = 40;
            this.dgvMemberGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberGrid.Size = new System.Drawing.Size(1605, 634);
            this.dgvMemberGrid.TabIndex = 30;
            this.dgvMemberGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberGrid_CellContentClick);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.pictureBox5);
            this.panel9.Controls.Add(this.btnLibraryStaff);
            this.panel9.Controls.Add(this.txtSearch);
            this.panel9.Controls.Add(this.btnAddMember);
            this.panel9.Controls.Add(this.lblStatus);
            this.panel9.Controls.Add(this.cmbStatus);
            this.panel9.Controls.Add(this.lblTypes);
            this.panel9.Controls.Add(this.cmbMemberType);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1611, 117);
            this.panel9.TabIndex = 31;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(42, 41);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // btnLibraryStaff
            // 
            this.btnLibraryStaff.BackColor = System.Drawing.Color.SlateGray;
            this.btnLibraryStaff.FlatAppearance.BorderSize = 0;
            this.btnLibraryStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibraryStaff.ForeColor = System.Drawing.Color.White;
            this.btnLibraryStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryStaff.Image")));
            this.btnLibraryStaff.Location = new System.Drawing.Point(1169, 41);
            this.btnLibraryStaff.Name = "btnLibraryStaff";
            this.btnLibraryStaff.Size = new System.Drawing.Size(184, 43);
            this.btnLibraryStaff.TabIndex = 7;
            this.btnLibraryStaff.Text = "  Library Staff";
            this.btnLibraryStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibraryStaff.UseVisualStyleBackColor = false;
            this.btnLibraryStaff.Click += new System.EventHandler(this.btnLibraryStaff_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(90, 41);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(605, 43);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.SlateGray;
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMember.Image")));
            this.btnAddMember.Location = new System.Drawing.Point(1392, 41);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(184, 43);
            this.btnAddMember.TabIndex = 6;
            this.btnAddMember.Text = "   Add Member";
            this.btnAddMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(943, 41);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(946, 60);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(129, 24);
            this.cmbStatus.TabIndex = 4;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Location = new System.Drawing.Point(756, 41);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(46, 16);
            this.lblTypes.TabIndex = 3;
            this.lblTypes.Text = "Types";
            // 
            // cmbMemberType
            // 
            this.cmbMemberType.FormattingEnabled = true;
            this.cmbMemberType.Location = new System.Drawing.Point(759, 60);
            this.cmbMemberType.Name = "cmbMemberType";
            this.cmbMemberType.Size = new System.Drawing.Size(129, 24);
            this.cmbMemberType.TabIndex = 2;
            this.cmbMemberType.SelectedIndexChanged += new System.EventHandler(this.cmbMemberType_SelectedIndexChanged);
            // 
            // colCardNumber
            // 
            this.colCardNumber.DataPropertyName = "Card Number";
            this.colCardNumber.FillWeight = 123.6588F;
            this.colCardNumber.HeaderText = "Card Number";
            this.colCardNumber.MinimumWidth = 6;
            this.colCardNumber.Name = "colCardNumber";
            this.colCardNumber.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.FillWeight = 123.6588F;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colContact
            // 
            this.colContact.DataPropertyName = "Contact #";
            this.colContact.FillWeight = 123.6588F;
            this.colContact.HeaderText = "Contact #";
            this.colContact.MinimumWidth = 6;
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.FillWeight = 123.6588F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colBooksOut
            // 
            this.colBooksOut.DataPropertyName = "Books Out";
            this.colBooksOut.FillWeight = 123.6588F;
            this.colBooksOut.HeaderText = "Books Out";
            this.colBooksOut.MinimumWidth = 6;
            this.colBooksOut.Name = "colBooksOut";
            this.colBooksOut.ReadOnly = true;
            // 
            // colFines
            // 
            this.colFines.DataPropertyName = "Fines";
            this.colFines.FillWeight = 123.6588F;
            this.colFines.HeaderText = "Fines";
            this.colFines.MinimumWidth = 6;
            this.colFines.Name = "colFines";
            this.colFines.ReadOnly = true;
            // 
            // EditCol
            // 
            this.EditCol.FillWeight = 57.15382F;
            this.EditCol.HeaderText = "Actions";
            this.EditCol.MinimumWidth = 6;
            this.EditCol.Name = "EditCol";
            this.EditCol.ReadOnly = true;
            this.EditCol.Text = "Edit";
            this.EditCol.UseColumnTextForButtonValue = true;
            // 
            // ViewCol
            // 
            this.ViewCol.FillWeight = 52.76507F;
            this.ViewCol.HeaderText = "";
            this.ViewCol.MinimumWidth = 6;
            this.ViewCol.Name = "ViewCol";
            this.ViewCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ViewCol.Text = "View";
            this.ViewCol.UseColumnTextForButtonValue = true;
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
            // A_GridViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvMemberGrid);
            this.Controls.Add(this.panel9);
            this.Name = "A_GridViewMember";
            this.Size = new System.Drawing.Size(1611, 781);
            this.Load += new System.EventHandler(this.A_GridViewMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberGrid)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMemberGrid;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnLibraryStaff;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.ComboBox cmbMemberType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBooksOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFines;
        private System.Windows.Forms.DataGridViewButtonColumn EditCol;
        private System.Windows.Forms.DataGridViewButtonColumn ViewCol;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteCol;
    }
}
