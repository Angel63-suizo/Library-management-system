namespace LIBRARY.ADashboard
{
    partial class Reports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTypes = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.chartCirculationTrends = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chartMemberActivity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCirculationTrends)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMemberActivity)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.panel2);
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Controls.Add(this.lblStatus);
            this.panel9.Controls.Add(this.lblTypes);
            this.panel9.Location = new System.Drawing.Point(7, 14);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1655, 117);
            this.panel9.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpEndDate);
            this.panel2.Location = new System.Drawing.Point(335, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 43);
            this.panel2.TabIndex = 10;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MM/dd/yyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(3, 3);
            this.dtpEndDate.MaxDate = new System.DateTime(2026, 1, 14, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(209, 30);
            this.dtpEndDate.TabIndex = 8;
            this.dtpEndDate.Value = new System.DateTime(2026, 1, 14, 0, 0, 0, 0);
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpStartDate);
            this.panel1.Location = new System.Drawing.Point(39, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 43);
            this.panel1.TabIndex = 9;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MM/dd/yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(3, 3);
            this.dtpStartDate.MaxDate = new System.DateTime(2026, 1, 14, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(209, 30);
            this.dtpStartDate.TabIndex = 8;
            this.dtpStartDate.Value = new System.DateTime(2026, 1, 14, 0, 0, 0, 0);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(331, 21);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 19);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "End Date";
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypes.Location = new System.Drawing.Point(35, 21);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(75, 19);
            this.lblTypes.TabIndex = 3;
            this.lblTypes.Text = "Start Date ";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.chartCirculationTrends);
            this.panel3.Location = new System.Drawing.Point(7, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 511);
            this.panel3.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Circulation Trends";
            // 
            // chartCirculationTrends
            // 
            chartArea3.AxisX.MajorGrid.Interval = 1D;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.Name = "ChartArea1";
            this.chartCirculationTrends.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCirculationTrends.Legends.Add(legend3);
            this.chartCirculationTrends.Location = new System.Drawing.Point(20, 76);
            this.chartCirculationTrends.Name = "chartCirculationTrends";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.DarkBlue;
            series7.Legend = "Legend1";
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series7.Name = "Checkouts";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.HotPink;
            series8.Legend = "Legend1";
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series8.Name = "Returns";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Orange;
            series9.Legend = "Legend1";
            series9.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series9.Name = "Reservations";
            this.chartCirculationTrends.Series.Add(series7);
            this.chartCirculationTrends.Series.Add(series8);
            this.chartCirculationTrends.Series.Add(series9);
            this.chartCirculationTrends.Size = new System.Drawing.Size(760, 409);
            this.chartCirculationTrends.TabIndex = 0;
            this.chartCirculationTrends.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.chartMemberActivity);
            this.panel4.Location = new System.Drawing.Point(854, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(808, 511);
            this.panel4.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Member Activity Type";
            // 
            // chartMemberActivity
            // 
            chartArea4.Name = "ChartArea1";
            this.chartMemberActivity.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartMemberActivity.Legends.Add(legend4);
            this.chartMemberActivity.Location = new System.Drawing.Point(30, 76);
            this.chartMemberActivity.Name = "chartMemberActivity";
            series10.ChartArea = "ChartArea1";
            series10.Color = System.Drawing.Color.DarkBlue;
            series10.Legend = "Legend1";
            series10.Name = "Student";
            series11.ChartArea = "ChartArea1";
            series11.Color = System.Drawing.Color.HotPink;
            series11.Legend = "Legend1";
            series11.Name = "Faculty";
            series12.ChartArea = "ChartArea1";
            series12.Color = System.Drawing.Color.LightSeaGreen;
            series12.Legend = "Legend1";
            series12.Name = "Staff";
            this.chartMemberActivity.Series.Add(series10);
            this.chartMemberActivity.Series.Add(series11);
            this.chartMemberActivity.Series.Add(series12);
            this.chartMemberActivity.Size = new System.Drawing.Size(756, 409);
            this.chartMemberActivity.TabIndex = 0;
            this.chartMemberActivity.Text = "chart2";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(7, 706);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1655, 291);
            this.panel5.TabIndex = 35;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.button5);
            this.panel10.Controls.Add(this.button7);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Location = new System.Drawing.Point(1261, 42);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(376, 205);
            this.panel10.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SlateGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::LIBRARY.Properties.Resources.Icon__32_;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(25, 122);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 53);
            this.button5.TabIndex = 11;
            this.button5.Text = "  Excel";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(200, 122);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 53);
            this.button7.TabIndex = 10;
            this.button7.Text = "Preview";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Current stock levels and availability";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 28);
            this.label10.TabIndex = 4;
            this.label10.Text = "Inventory Status Report";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.button2);
            this.panel8.Controls.Add(this.button4);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(852, 42);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(376, 205);
            this.panel8.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::LIBRARY.Properties.Resources.Icon__32_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(25, 122);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 53);
            this.button2.TabIndex = 11;
            this.button2.Text = "  Excel";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(202, 122);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 53);
            this.button4.TabIndex = 10;
            this.button4.Text = "Preview";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Member borrowing patterns and statistics";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Member Activity Report";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.button3);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(432, 42);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(380, 205);
            this.panel7.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::LIBRARY.Properties.Resources.Icon__32_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(25, 122);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 53);
            this.button3.TabIndex = 11;
            this.button3.Text = "  Excel";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(198, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "Preview";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "List of all overdue books and fines";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Overdue Books Reports";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnPreview);
            this.panel6.Controls.Add(this.btnExcel);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(20, 42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(379, 205);
            this.panel6.TabIndex = 0;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.White;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.Black;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreview.Location = new System.Drawing.Point(200, 122);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(147, 53);
            this.btnPreview.TabIndex = 10;
            this.btnPreview.Text = "Preview";
            this.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.SlateGray;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Image = global::LIBRARY.Properties.Resources.Icon__32_;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.Location = new System.Drawing.Point(25, 122);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(147, 53);
            this.btnExcel.TabIndex = 9;
            this.btnExcel.Text = "  Excel";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Books borrowed and returned this month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monthly Circulation Report";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel9);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1665, 1055);
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCirculationTrends)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMemberActivity)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCirculationTrends;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMemberActivity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
