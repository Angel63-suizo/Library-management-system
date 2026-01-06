namespace LIBRARY.ADashboard
{
    partial class InventoryMovements_UC
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
            this.pnlInventoryContent = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlInventoryContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInventoryContent
            // 
            this.pnlInventoryContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInventoryContent.Controls.Add(this.lblDate);
            this.pnlInventoryContent.Controls.Add(this.lblAction);
            this.pnlInventoryContent.Controls.Add(this.lblUser);
            this.pnlInventoryContent.Controls.Add(this.lblDetails);
            this.pnlInventoryContent.Controls.Add(this.lblTitle);
            this.pnlInventoryContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInventoryContent.ForeColor = System.Drawing.Color.Black;
            this.pnlInventoryContent.Location = new System.Drawing.Point(0, 0);
            this.pnlInventoryContent.Name = "pnlInventoryContent";
            this.pnlInventoryContent.Size = new System.Drawing.Size(669, 150);
            this.pnlInventoryContent.TabIndex = 1;
            this.pnlInventoryContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInventoryContent_Paint);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(594, 97);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 18);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // lblAction
            // 
            this.lblAction.BackColor = System.Drawing.Color.Honeydew;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.ForeColor = System.Drawing.Color.Green;
            this.lblAction.Location = new System.Drawing.Point(594, 23);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(49, 18);
            this.lblAction.TabIndex = 6;
            this.lblAction.Text = "Added";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUser.Location = new System.Drawing.Point(34, 94);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(49, 18);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Admin";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(33, 62);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(72, 20);
            this.lblDetails.TabIndex = 4;
            this.lblDetails.Text = "3 copies";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(29, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(105, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Clean Code";
            // 
            // InventoryMovements_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlInventoryContent);
            this.Name = "InventoryMovements_UC";
            this.Size = new System.Drawing.Size(669, 150);
            this.pnlInventoryContent.ResumeLayout(false);
            this.pnlInventoryContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInventoryContent;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblTitle;
    }
}
