namespace ModelProject
{
    partial class ModelPro
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series33 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series34 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series35 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series36 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series40 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.edtHighestTemp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtRadius = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtPowerTemp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtDivisionCounter = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThreadbyFreq = new System.Windows.Forms.Button();
            this.indexUpDown = new System.Windows.Forms.NumericUpDown();
            this.reportBtn = new System.Windows.Forms.Button();
            this.collectAnalysBtn = new System.Windows.Forms.Button();
            this.analyseBtn = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mScheme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tab = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.selector = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indexUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Highest temperature (by [Kelvin])";
            // 
            // edtHighestTemp
            // 
            this.edtHighestTemp.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHighestTemp.Location = new System.Drawing.Point(6, 26);
            this.edtHighestTemp.Name = "edtHighestTemp";
            this.edtHighestTemp.Size = new System.Drawing.Size(189, 29);
            this.edtHighestTemp.TabIndex = 2;
            this.edtHighestTemp.Text = "10000";
            this.edtHighestTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Radius (by [cm])";
            // 
            // edtRadius
            // 
            this.edtRadius.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtRadius.Location = new System.Drawing.Point(6, 134);
            this.edtRadius.Name = "edtRadius";
            this.edtRadius.Size = new System.Drawing.Size(189, 29);
            this.edtRadius.TabIndex = 2;
            this.edtRadius.Text = "0.35";
            this.edtRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Power in formula temperature";
            // 
            // edtPowerTemp
            // 
            this.edtPowerTemp.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtPowerTemp.Location = new System.Drawing.Point(6, 79);
            this.edtPowerTemp.Name = "edtPowerTemp";
            this.edtPowerTemp.Size = new System.Drawing.Size(189, 29);
            this.edtPowerTemp.TabIndex = 2;
            this.edtPowerTemp.Text = "4.0";
            this.edtPowerTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Division counter";
            // 
            // edtDivisionCounter
            // 
            this.edtDivisionCounter.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtDivisionCounter.Location = new System.Drawing.Point(110, 229);
            this.edtDivisionCounter.Name = "edtDivisionCounter";
            this.edtDivisionCounter.Size = new System.Drawing.Size(85, 29);
            this.edtDivisionCounter.TabIndex = 2;
            this.edtDivisionCounter.Text = "80";
            this.edtDivisionCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThreadbyFreq);
            this.panel1.Controls.Add(this.indexUpDown);
            this.panel1.Controls.Add(this.reportBtn);
            this.panel1.Controls.Add(this.collectAnalysBtn);
            this.panel1.Controls.Add(this.analyseBtn);
            this.panel1.Controls.Add(this.btnExecute);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.edtHighestTemp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.edtRadius);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.edtPowerTemp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.edtDivisionCounter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 607);
            this.panel1.TabIndex = 3;
            // 
            // btnThreadbyFreq
            // 
            this.btnThreadbyFreq.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThreadbyFreq.Location = new System.Drawing.Point(6, 545);
            this.btnThreadbyFreq.Name = "btnThreadbyFreq";
            this.btnThreadbyFreq.Size = new System.Drawing.Size(189, 54);
            this.btnThreadbyFreq.TabIndex = 8;
            this.btnThreadbyFreq.Text = "Thread by frequency";
            this.btnThreadbyFreq.UseVisualStyleBackColor = true;
            this.btnThreadbyFreq.Click += new System.EventHandler(this.btnThreadbyFreq_Click);
            // 
            // indexUpDown
            // 
            this.indexUpDown.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexUpDown.Location = new System.Drawing.Point(110, 260);
            this.indexUpDown.Maximum = new decimal(new int[] {
            192,
            0,
            0,
            0});
            this.indexUpDown.Name = "indexUpDown";
            this.indexUpDown.Size = new System.Drawing.Size(85, 29);
            this.indexUpDown.TabIndex = 7;
            this.indexUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // reportBtn
            // 
            this.reportBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.Location = new System.Drawing.Point(6, 485);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(189, 54);
            this.reportBtn.TabIndex = 6;
            this.reportBtn.Text = "Divergence of Thread Report";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // collectAnalysBtn
            // 
            this.collectAnalysBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectAnalysBtn.Location = new System.Drawing.Point(6, 425);
            this.collectAnalysBtn.Name = "collectAnalysBtn";
            this.collectAnalysBtn.Size = new System.Drawing.Size(189, 54);
            this.collectAnalysBtn.TabIndex = 6;
            this.collectAnalysBtn.Text = "Collect mScheme";
            this.collectAnalysBtn.UseVisualStyleBackColor = true;
            this.collectAnalysBtn.Click += new System.EventHandler(this.collectAnalysBtn_Click);
            // 
            // analyseBtn
            // 
            this.analyseBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyseBtn.Location = new System.Drawing.Point(6, 365);
            this.analyseBtn.Name = "analyseBtn";
            this.analyseBtn.Size = new System.Drawing.Size(189, 54);
            this.analyseBtn.TabIndex = 6;
            this.analyseBtn.Text = "Analyse";
            this.analyseBtn.UseVisualStyleBackColor = true;
            this.analyseBtn.Click += new System.EventHandler(this.analyseBtn_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(6, 305);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(189, 54);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.mScheme);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 60);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Differential scheme  ";
            // 
            // mScheme
            // 
            this.mScheme.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mScheme.Location = new System.Drawing.Point(75, 23);
            this.mScheme.Name = "mScheme";
            this.mScheme.Size = new System.Drawing.Size(114, 29);
            this.mScheme.TabIndex = 9;
            this.mScheme.Text = "0.786163522";
            this.mScheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mScheme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mScheme_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mscheme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Frequency index";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tab);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(202, 430);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 177);
            this.panel3.TabIndex = 5;
            // 
            // tab
            // 
            this.tab.AllowUserToAddRows = false;
            this.tab.AllowUserToDeleteRows = false;
            this.tab.AllowUserToResizeRows = false;
            this.tab.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.tab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.ReadOnly = true;
            this.tab.RowHeadersVisible = false;
            this.tab.Size = new System.Drawing.Size(862, 175);
            this.tab.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Index";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 45;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Distance";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "K";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Up";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "U(exact)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "U(scheme)";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "DivF (e)";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "DivF (s)";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "divergence of Thread";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Silver;
            this.chart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart.BorderlineWidth = 0;
            this.chart.BorderSkin.BackColor = System.Drawing.Color.DarkGreen;
            chartArea5.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea5);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chart.Legends.Add(legend5);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series33.ChartArea = "ChartArea1";
            series33.Legend = "Legend1";
            series33.Name = "Up";
            series34.ChartArea = "ChartArea1";
            series34.Legend = "Legend1";
            series34.Name = "U(e)";
            series35.ChartArea = "ChartArea1";
            series35.Legend = "Legend1";
            series35.Name = "U(s)";
            series36.ChartArea = "ChartArea1";
            series36.Legend = "Legend1";
            series36.Name = "DivF(e)";
            series37.ChartArea = "ChartArea1";
            series37.Legend = "Legend1";
            series37.Name = "DivF(s)";
            series38.ChartArea = "ChartArea1";
            series38.Legend = "Legend1";
            series38.Name = "mScheme (analys type 1)";
            series39.ChartArea = "ChartArea1";
            series39.Legend = "Legend1";
            series39.Name = "divergence of Thread";
            series40.ChartArea = "ChartArea1";
            series40.Legend = "Legend1";
            series40.Name = "deltaThread";
            this.chart.Series.Add(series33);
            this.chart.Series.Add(series34);
            this.chart.Series.Add(series35);
            this.chart.Series.Add(series36);
            this.chart.Series.Add(series37);
            this.chart.Series.Add(series38);
            this.chart.Series.Add(series39);
            this.chart.Series.Add(series40);
            this.chart.Size = new System.Drawing.Size(679, 430);
            this.chart.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(202, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.selector);
            this.splitContainer1.Size = new System.Drawing.Size(864, 430);
            this.splitContainer1.SplitterDistance = 679;
            this.splitContainer1.TabIndex = 6;
            // 
            // selector
            // 
            this.selector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selector.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selector.FormattingEnabled = true;
            this.selector.Items.AddRange(new object[] {
            "Up",
            "U (exact solution)",
            "U (scheme solution)",
            "Divergence (exact solution)",
            "Divergence (scheme solution)",
            "mScheme",
            "divergence of Thread",
            "deltaThread"});
            this.selector.Location = new System.Drawing.Point(0, 0);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(181, 430);
            this.selector.TabIndex = 9;
            // 
            // ModelPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1066, 607);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ModelPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modeling ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indexUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtHighestTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtRadius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtPowerTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtDivisionCounter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridView tab;
        private System.Windows.Forms.NumericUpDown indexUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mScheme;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox selector;
        private System.Windows.Forms.Button analyseBtn;
        private System.Windows.Forms.Button collectAnalysBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button btnThreadbyFreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

