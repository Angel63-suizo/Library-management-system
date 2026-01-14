namespace LIBRARY.ADashboard
{
    partial class A_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartTrends = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBooksBorrowed = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblOverdueBooks = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblActiveStaff = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btn = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTotalBooks);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(79, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 148);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBooks.ForeColor = System.Drawing.Color.Black;
            this.lblTotalBooks.Location = new System.Drawing.Point(155, 76);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(32, 35);
            this.lblTotalBooks.TabIndex = 5;
            this.lblTotalBooks.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(55, 44);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(67, 62);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(155, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total  Books";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chartTrends
            // 
            this.chartTrends.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chartTrends.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chartTrends.Legends.Add(legend1);
            this.chartTrends.Location = new System.Drawing.Point(76, 446);
            this.chartTrends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartTrends.Name = "chartTrends";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Borrowed";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Returned";
            this.chartTrends.Series.Add(series1);
            this.chartTrends.Series.Add(series2);
            this.chartTrends.Size = new System.Drawing.Size(805, 452);
            this.chartTrends.TabIndex = 27;
            this.chartTrends.Text = "chart1";
            this.chartTrends.Click += new System.EventHandler(this.chartTrends_Click);
            this.chartTrends.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // chartCategory
            // 
            this.chartCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            chartArea2.Name = "ChartArea1";
            this.chartCategory.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCategory.Legends.Add(legend2);
            this.chartCategory.Location = new System.Drawing.Point(920, 446);
            this.chartCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartCategory.Name = "chartCategory";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Label = "#VALX #PERCENT";
            series3.Legend = "Legend1";
            series3.Name = "Default";
            series3.XValueMember = "Category";
            series3.YValueMembers = "TotalCount";
            this.chartCategory.Series.Add(series3);
            this.chartCategory.Size = new System.Drawing.Size(811, 452);
            this.chartCategory.TabIndex = 28;
            this.chartCategory.Text = "chart2";
            this.chartCategory.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblBooksBorrowed);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(653, 32);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(504, 148);
            this.panel4.TabIndex = 29;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // lblBooksBorrowed
            // 
            this.lblBooksBorrowed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBooksBorrowed.AutoSize = true;
            this.lblBooksBorrowed.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksBorrowed.ForeColor = System.Drawing.Color.Black;
            this.lblBooksBorrowed.Location = new System.Drawing.Point(155, 76);
            this.lblBooksBorrowed.Name = "lblBooksBorrowed";
            this.lblBooksBorrowed.Size = new System.Drawing.Size(32, 35);
            this.lblBooksBorrowed.TabIndex = 5;
            this.lblBooksBorrowed.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(55, 44);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(67, 62);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.MediumOrchid;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(155, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Books Borrowed";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTotalMembers);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(1227, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 148);
            this.panel2.TabIndex = 30;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMembers.ForeColor = System.Drawing.Color.Black;
            this.lblTotalMembers.Location = new System.Drawing.Point(155, 76);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(32, 35);
            this.lblTotalMembers.TabIndex = 5;
            this.lblTotalMembers.Text = "0";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Location = new System.Drawing.Point(55, 44);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(67, 62);
            this.panel6.TabIndex = 4;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(155, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total  Members";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.lblOverdueBooks);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(1227, 238);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(504, 148);
            this.panel7.TabIndex = 31;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // lblOverdueBooks
            // 
            this.lblOverdueBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOverdueBooks.AutoSize = true;
            this.lblOverdueBooks.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdueBooks.ForeColor = System.Drawing.Color.Black;
            this.lblOverdueBooks.Location = new System.Drawing.Point(155, 76);
            this.lblOverdueBooks.Name = "lblOverdueBooks";
            this.lblOverdueBooks.Size = new System.Drawing.Size(32, 35);
            this.lblOverdueBooks.TabIndex = 5;
            this.lblOverdueBooks.Text = "0";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Crimson;
            this.panel8.Controls.Add(this.pictureBox4);
            this.panel8.Location = new System.Drawing.Point(55, 44);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(67, 62);
            this.panel8.TabIndex = 4;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 11);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(155, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Overdue Books";
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.lblTotalRevenue);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Location = new System.Drawing.Point(653, 238);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(504, 148);
            this.panel9.TabIndex = 32;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRevenue.Location = new System.Drawing.Point(155, 76);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(32, 35);
            this.lblTotalRevenue.TabIndex = 5;
            this.lblTotalRevenue.Text = "0";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Orange;
            this.panel10.Controls.Add(this.pictureBox5);
            this.panel10.Location = new System.Drawing.Point(55, 44);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(67, 62);
            this.panel10.TabIndex = 4;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Orange;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 11);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(155, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 28);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total Revenue";
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.lblActiveStaff);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.label12);
            this.panel11.Location = new System.Drawing.Point(79, 238);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(504, 148);
            this.panel11.TabIndex = 33;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // lblActiveStaff
            // 
            this.lblActiveStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActiveStaff.AutoSize = true;
            this.lblActiveStaff.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveStaff.ForeColor = System.Drawing.Color.Black;
            this.lblActiveStaff.Location = new System.Drawing.Point(155, 76);
            this.lblActiveStaff.Name = "lblActiveStaff";
            this.lblActiveStaff.Size = new System.Drawing.Size(32, 35);
            this.lblActiveStaff.TabIndex = 5;
            this.lblActiveStaff.Text = "0";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel12.Controls.Add(this.pictureBox6);
            this.panel12.Location = new System.Drawing.Point(55, 44);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(67, 62);
            this.panel12.TabIndex = 4;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 11);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(155, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 28);
            this.label12.TabIndex = 2;
            this.label12.Text = "Active Staff";
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.btn);
            this.panel13.Controls.Add(this.btnGenerateReport);
            this.panel13.Controls.Add(this.btnAddBook);
            this.panel13.Controls.Add(this.btnAddMember);
            this.panel13.Controls.Add(this.label13);
            this.panel13.Location = new System.Drawing.Point(76, 934);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1653, 201);
            this.panel13.TabIndex = 34;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // btn
            // 
            this.btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Image = ((System.Drawing.Image)(resources.GetObject("btn.Image")));
            this.btn.Location = new System.Drawing.Point(1269, 86);
            this.btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(325, 86);
            this.btn.TabIndex = 4;
            this.btn.Text = "    System Settings";
            this.btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            this.btn.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateReport.Image")));
            this.btnGenerateReport.Location = new System.Drawing.Point(865, 86);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(331, 86);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "    Generate Report";
            this.btnGenerateReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // btnAddBook
            // 
            this.btnAddBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBook.Image")));
            this.btnAddBook.Location = new System.Drawing.Point(459, 86);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(325, 86);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "    View Resources";
            this.btnAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            this.btnAddBook.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // btnAddMember
            // 
            this.btnAddMember.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMember.Image")));
            this.btnAddMember.Location = new System.Drawing.Point(57, 86);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(327, 86);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "    View Member";
            this.btnAddMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            this.btnAddMember.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCustomBorder);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(43, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Quick Actions";
            // 
            // A_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.chartCategory);
            this.Controls.Add(this.chartTrends);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "A_dashboard";
            this.Size = new System.Drawing.Size(1807, 1158);
            this.Load += new System.EventHandler(this.A_dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrends;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblBooksBorrowed;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblOverdueBooks;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblActiveStaff;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}
