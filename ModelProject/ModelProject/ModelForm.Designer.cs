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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.selector = new System.Windows.Forms.CheckedListBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Highest temperature (by [Kelvin])";
            // 
            // edtHighestTemp
            // 
            this.edtHighestTemp.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHighestTemp.Location = new System.Drawing.Point(8, 32);
            this.edtHighestTemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtHighestTemp.Name = "edtHighestTemp";
            this.edtHighestTemp.Size = new System.Drawing.Size(251, 34);
            this.edtHighestTemp.TabIndex = 2;
            this.edtHighestTemp.Text = "10000";
            this.edtHighestTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Radius (by [cm])";
            // 
            // edtRadius
            // 
            this.edtRadius.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtRadius.Location = new System.Drawing.Point(8, 165);
            this.edtRadius.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtRadius.Name = "edtRadius";
            this.edtRadius.Size = new System.Drawing.Size(251, 34);
            this.edtRadius.TabIndex = 2;
            this.edtRadius.Text = "0.35";
            this.edtRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Power in formula temperature";
            // 
            // edtPowerTemp
            // 
            this.edtPowerTemp.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtPowerTemp.Location = new System.Drawing.Point(8, 97);
            this.edtPowerTemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtPowerTemp.Name = "edtPowerTemp";
            this.edtPowerTemp.Size = new System.Drawing.Size(251, 34);
            this.edtPowerTemp.TabIndex = 2;
            this.edtPowerTemp.Text = "4.0";
            this.edtPowerTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Division counter";
            // 
            // edtDivisionCounter
            // 
            this.edtDivisionCounter.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtDivisionCounter.Location = new System.Drawing.Point(147, 282);
            this.edtDivisionCounter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtDivisionCounter.Name = "edtDivisionCounter";
            this.edtDivisionCounter.Size = new System.Drawing.Size(112, 34);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 747);
            this.panel1.TabIndex = 3;
            // 
            // btnThreadbyFreq
            // 
            this.btnThreadbyFreq.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThreadbyFreq.Location = new System.Drawing.Point(8, 671);
            this.btnThreadbyFreq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThreadbyFreq.Name = "btnThreadbyFreq";
            this.btnThreadbyFreq.Size = new System.Drawing.Size(252, 66);
            this.btnThreadbyFreq.TabIndex = 8;
            this.btnThreadbyFreq.Text = "Thread by frequency";
            this.btnThreadbyFreq.UseVisualStyleBackColor = true;
            this.btnThreadbyFreq.Click += new System.EventHandler(this.btnThreadbyFreq_Click);
            // 
            // indexUpDown
            // 
            this.indexUpDown.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexUpDown.Location = new System.Drawing.Point(147, 320);
            this.indexUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.indexUpDown.Maximum = new decimal(new int[] {
            192,
            0,
            0,
            0});
            this.indexUpDown.Name = "indexUpDown";
            this.indexUpDown.Size = new System.Drawing.Size(113, 34);
            this.indexUpDown.TabIndex = 7;
            this.indexUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // reportBtn
            // 
            this.reportBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.Location = new System.Drawing.Point(8, 597);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(252, 66);
            this.reportBtn.TabIndex = 6;
            this.reportBtn.Text = "Divergence of Thread Report";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // collectAnalysBtn
            // 
            this.collectAnalysBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectAnalysBtn.Location = new System.Drawing.Point(8, 523);
            this.collectAnalysBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.collectAnalysBtn.Name = "collectAnalysBtn";
            this.collectAnalysBtn.Size = new System.Drawing.Size(252, 66);
            this.collectAnalysBtn.TabIndex = 6;
            this.collectAnalysBtn.Text = "Collect mScheme";
            this.collectAnalysBtn.UseVisualStyleBackColor = true;
            this.collectAnalysBtn.Click += new System.EventHandler(this.collectAnalysBtn_Click);
            // 
            // analyseBtn
            // 
            this.analyseBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyseBtn.Location = new System.Drawing.Point(8, 449);
            this.analyseBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.analyseBtn.Name = "analyseBtn";
            this.analyseBtn.Size = new System.Drawing.Size(252, 66);
            this.analyseBtn.TabIndex = 6;
            this.analyseBtn.Text = "Analyse";
            this.analyseBtn.UseVisualStyleBackColor = true;
            this.analyseBtn.Click += new System.EventHandler(this.analyseBtn_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(8, 375);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(252, 66);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 207);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(252, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Differential scheme  ";
            // 
            // mScheme
            // 
            this.mScheme.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mScheme.Location = new System.Drawing.Point(100, 28);
            this.mScheme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mScheme.Name = "mScheme";
            this.mScheme.Size = new System.Drawing.Size(151, 34);
            this.mScheme.TabIndex = 9;
            this.mScheme.Text = "0.786163522";
            this.mScheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mScheme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mScheme_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mscheme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Frequency index";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tab);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(269, 530);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1152, 217);
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
            this.Column21,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab.Name = "tab";
            this.tab.ReadOnly = true;
            this.tab.RowHeadersVisible = false;
            this.tab.Size = new System.Drawing.Size(1150, 215);
            this.tab.TabIndex = 0;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Silver;
            this.chart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart.BorderlineWidth = 0;
            this.chart.BorderSkin.BackColor = System.Drawing.Color.DarkGreen;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Up";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "U(e)";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "U(s)";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "DivF(e)";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "DivF(s)";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "mScheme (analys type 1)";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "divergence of Thread";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "deltaThread";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Series.Add(series5);
            this.chart.Series.Add(series6);
            this.chart.Series.Add(series7);
            this.chart.Series.Add(series8);
            this.chart.Size = new System.Drawing.Size(905, 530);
            this.chart.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(269, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.splitContainer1.Size = new System.Drawing.Size(1152, 530);
            this.splitContainer1.SplitterDistance = 905;
            this.splitContainer1.SplitterWidth = 5;
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
            this.selector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(242, 530);
            this.selector.TabIndex = 9;
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
            // Column21
            // 
            this.Column21.HeaderText = "Temperature";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
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
            // ModelPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1421, 747);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

