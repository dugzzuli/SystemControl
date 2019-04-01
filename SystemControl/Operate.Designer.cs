namespace SystemControl
{
    partial class Operate
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Stepmethod = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.adjustView = new System.Windows.Forms.GroupBox();
            this.curView = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nextView = new System.Windows.Forms.Button();
            this.lastView = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.graphInput = new ZedGraph.ZedGraphControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDistributionMeasures = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.viewNum = new System.Windows.Forms.Label();
            this.cluterNum = new System.Windows.Forms.Label();
            this.dirLocal = new System.Windows.Forms.Label();
            this.attributeLength = new System.Windows.Forms.Label();
            this.samplesNUm = new System.Windows.Forms.Label();
            this.fileDataName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLearningSource = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openfile = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.opendb = new System.Windows.Forms.Button();
            this.openurl = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.clusterInc = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.graph = new ZedGraph.ZedGraphControl();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbBalanced = new System.Windows.Forms.CheckBox();
            this.btnSampleRunAnalysis = new System.Windows.Forms.Button();
            this.rbKMeans = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbGMM = new System.Windows.Forms.RadioButton();
            this.numGaussians = new System.Windows.Forms.NumericUpDown();
            this.numKMeans = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.openMat = new System.Windows.Forms.Button();
            this.Stepmethod.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.adjustView.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistributionMeasures)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearningSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clusterInc)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGaussians)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKMeans)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Stepmethod
            // 
            this.Stepmethod.Controls.Add(this.tabPage1);
            this.Stepmethod.Controls.Add(this.tabPage2);
            this.Stepmethod.Controls.Add(this.tabPage3);
            this.Stepmethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stepmethod.Location = new System.Drawing.Point(0, 0);
            this.Stepmethod.Name = "Stepmethod";
            this.Stepmethod.SelectedIndex = 0;
            this.Stepmethod.Size = new System.Drawing.Size(1166, 629);
            this.Stepmethod.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.adjustView);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1158, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "预处理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // adjustView
            // 
            this.adjustView.Controls.Add(this.curView);
            this.adjustView.Controls.Add(this.label9);
            this.adjustView.Controls.Add(this.nextView);
            this.adjustView.Controls.Add(this.lastView);
            this.adjustView.Location = new System.Drawing.Point(11, 380);
            this.adjustView.Name = "adjustView";
            this.adjustView.Size = new System.Drawing.Size(457, 54);
            this.adjustView.TabIndex = 6;
            this.adjustView.TabStop = false;
            this.adjustView.Text = "操作";
            // 
            // curView
            // 
            this.curView.AutoSize = true;
            this.curView.Location = new System.Drawing.Point(376, 26);
            this.curView.Name = "curView";
            this.curView.Size = new System.Drawing.Size(0, 12);
            this.curView.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "当前视角:";
            // 
            // nextView
            // 
            this.nextView.Enabled = false;
            this.nextView.Location = new System.Drawing.Point(187, 20);
            this.nextView.Name = "nextView";
            this.nextView.Size = new System.Drawing.Size(75, 23);
            this.nextView.TabIndex = 0;
            this.nextView.Text = "下一视角";
            this.nextView.UseVisualStyleBackColor = true;
            this.nextView.Click += new System.EventHandler(this.nextView_Click);
            // 
            // lastView
            // 
            this.lastView.Enabled = false;
            this.lastView.Location = new System.Drawing.Point(43, 21);
            this.lastView.Name = "lastView";
            this.lastView.Size = new System.Drawing.Size(75, 23);
            this.lastView.TabIndex = 0;
            this.lastView.Text = "上一视角";
            this.lastView.UseVisualStyleBackColor = true;
            this.lastView.Click += new System.EventHandler(this.lastView_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.graphInput);
            this.groupBox5.Location = new System.Drawing.Point(487, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(661, 425);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "可视化";
            // 
            // graphInput
            // 
            this.graphInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphInput.Location = new System.Drawing.Point(3, 17);
            this.graphInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.graphInput.Name = "graphInput";
            this.graphInput.ScrollGrace = 0D;
            this.graphInput.ScrollMaxX = 0D;
            this.graphInput.ScrollMaxY = 0D;
            this.graphInput.ScrollMaxY2 = 0D;
            this.graphInput.ScrollMinX = 0D;
            this.graphInput.ScrollMinY = 0D;
            this.graphInput.ScrollMinY2 = 0D;
            this.graphInput.Size = new System.Drawing.Size(655, 405);
            this.graphInput.TabIndex = 5;
            this.graphInput.UseExtendedPrintDialog = true;
            this.graphInput.Load += new System.EventHandler(this.graphInput_Load);
            this.graphInput.DoubleClick += new System.EventHandler(this.graphInput_DoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDistributionMeasures);
            this.groupBox4.Location = new System.Drawing.Point(11, 440);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1137, 155);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "当前属性";
            // 
            // dgvDistributionMeasures
            // 
            this.dgvDistributionMeasures.AllowUserToAddRows = false;
            this.dgvDistributionMeasures.AllowUserToDeleteRows = false;
            this.dgvDistributionMeasures.AllowUserToOrderColumns = true;
            this.dgvDistributionMeasures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDistributionMeasures.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDistributionMeasures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDistributionMeasures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDistributionMeasures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistributionMeasures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.colIndex,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.colMin,
            this.colLength});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Format = "N5";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDistributionMeasures.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDistributionMeasures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDistributionMeasures.Location = new System.Drawing.Point(3, 17);
            this.dgvDistributionMeasures.Name = "dgvDistributionMeasures";
            this.dgvDistributionMeasures.ReadOnly = true;
            this.dgvDistributionMeasures.RowHeadersVisible = false;
            this.dgvDistributionMeasures.Size = new System.Drawing.Size(1131, 135);
            this.dgvDistributionMeasures.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn6.HeaderText = "Column";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 62;
            // 
            // colIndex
            // 
            this.colIndex.DataPropertyName = "Index";
            this.colIndex.HeaderText = "Index";
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Mean";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mean";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "StandardDeviation";
            this.dataGridViewTextBoxColumn8.HeaderText = "Standard Deviation";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Median";
            this.dataGridViewTextBoxColumn9.HeaderText = "Median";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Mode";
            this.dataGridViewTextBoxColumn10.HeaderText = "Mode";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Variance";
            this.dataGridViewTextBoxColumn11.HeaderText = "Variance";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Max";
            this.dataGridViewTextBoxColumn12.HeaderText = "Max";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // colMin
            // 
            this.colMin.DataPropertyName = "Min";
            this.colMin.HeaderText = "Min";
            this.colMin.Name = "colMin";
            this.colMin.ReadOnly = true;
            // 
            // colLength
            // 
            this.colLength.DataPropertyName = "Length";
            dataGridViewCellStyle7.Format = "N";
            dataGridViewCellStyle7.NullValue = null;
            this.colLength.DefaultCellStyle = dataGridViewCellStyle7;
            this.colLength.HeaderText = "Length";
            this.colLength.Name = "colLength";
            this.colLength.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.viewNum);
            this.groupBox3.Controls.Add(this.cluterNum);
            this.groupBox3.Controls.Add(this.dirLocal);
            this.groupBox3.Controls.Add(this.attributeLength);
            this.groupBox3.Controls.Add(this.samplesNUm);
            this.groupBox3.Controls.Add(this.fileDataName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(8, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 78);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据信息";
            // 
            // viewNum
            // 
            this.viewNum.AutoSize = true;
            this.viewNum.Location = new System.Drawing.Point(401, 45);
            this.viewNum.Name = "viewNum";
            this.viewNum.Size = new System.Drawing.Size(0, 12);
            this.viewNum.TabIndex = 3;
            // 
            // cluterNum
            // 
            this.cluterNum.AutoSize = true;
            this.cluterNum.Location = new System.Drawing.Point(315, 45);
            this.cluterNum.Name = "cluterNum";
            this.cluterNum.Size = new System.Drawing.Size(0, 12);
            this.cluterNum.TabIndex = 2;
            // 
            // dirLocal
            // 
            this.dirLocal.AutoSize = true;
            this.dirLocal.Location = new System.Drawing.Point(215, 21);
            this.dirLocal.Name = "dirLocal";
            this.dirLocal.Size = new System.Drawing.Size(0, 12);
            this.dirLocal.TabIndex = 1;
            // 
            // attributeLength
            // 
            this.attributeLength.AutoSize = true;
            this.attributeLength.Location = new System.Drawing.Point(215, 45);
            this.attributeLength.Name = "attributeLength";
            this.attributeLength.Size = new System.Drawing.Size(0, 12);
            this.attributeLength.TabIndex = 1;
            // 
            // samplesNUm
            // 
            this.samplesNUm.AutoSize = true;
            this.samplesNUm.Location = new System.Drawing.Point(77, 45);
            this.samplesNUm.Name = "samplesNUm";
            this.samplesNUm.Size = new System.Drawing.Size(0, 12);
            this.samplesNUm.TabIndex = 1;
            // 
            // fileDataName
            // 
            this.fileDataName.AutoSize = true;
            this.fileDataName.Location = new System.Drawing.Point(77, 21);
            this.fileDataName.Name = "fileDataName";
            this.fileDataName.Size = new System.Drawing.Size(0, 12);
            this.fileDataName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "样本数目：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "位置：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "视角：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "簇个数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "属性：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件名称：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLearningSource);
            this.groupBox2.Location = new System.Drawing.Point(8, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 205);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "原始数据";
            // 
            // dgvLearningSource
            // 
            this.dgvLearningSource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLearningSource.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLearningSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLearningSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLearningSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLearningSource.Location = new System.Drawing.Point(3, 17);
            this.dgvLearningSource.Name = "dgvLearningSource";
            this.dgvLearningSource.RowTemplate.Height = 23;
            this.dgvLearningSource.Size = new System.Drawing.Size(457, 185);
            this.dgvLearningSource.TabIndex = 0;
            this.dgvLearningSource.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvLearningSource_RowPostPaint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openMat);
            this.groupBox1.Controls.Add(this.openfile);
            this.groupBox1.Controls.Add(this.generate);
            this.groupBox1.Controls.Add(this.opendb);
            this.groupBox1.Controls.Add(this.openurl);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "训练数据";
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(6, 21);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(82, 34);
            this.openfile.TabIndex = 0;
            this.openfile.Text = "打开文件";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(381, 21);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(82, 34);
            this.generate.TabIndex = 0;
            this.generate.Text = "生成数据";
            this.generate.UseVisualStyleBackColor = true;
            // 
            // opendb
            // 
            this.opendb.Location = new System.Drawing.Point(286, 21);
            this.opendb.Name = "opendb";
            this.opendb.Size = new System.Drawing.Size(93, 34);
            this.opendb.TabIndex = 0;
            this.opendb.Text = "从数据库打开";
            this.opendb.UseVisualStyleBackColor = true;
            // 
            // openurl
            // 
            this.openurl.Location = new System.Drawing.Point(184, 21);
            this.openurl.Name = "openurl";
            this.openurl.Size = new System.Drawing.Size(96, 34);
            this.openurl.TabIndex = 0;
            this.openurl.Text = "打开链接数据";
            this.openurl.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1158, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "单视角聚类";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.clusterInc);
            this.groupBox8.Location = new System.Drawing.Point(271, 501);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(879, 81);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "指标";
            // 
            // clusterInc
            // 
            this.clusterInc.BackgroundColor = System.Drawing.SystemColors.Window;
            this.clusterInc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clusterInc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clusterInc.GridColor = System.Drawing.SystemColors.Window;
            this.clusterInc.Location = new System.Drawing.Point(3, 17);
            this.clusterInc.Name = "clusterInc";
            this.clusterInc.RowTemplate.Height = 23;
            this.clusterInc.Size = new System.Drawing.Size(873, 61);
            this.clusterInc.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.graph);
            this.groupBox6.Location = new System.Drawing.Point(268, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(887, 494);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "可视化";
            // 
            // graph
            // 
            this.graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graph.Location = new System.Drawing.Point(3, 17);
            this.graph.Name = "graph";
            this.graph.ScrollGrace = 0D;
            this.graph.ScrollMaxX = 0D;
            this.graph.ScrollMaxY = 0D;
            this.graph.ScrollMaxY2 = 0D;
            this.graph.ScrollMinX = 0D;
            this.graph.ScrollMinY = 0D;
            this.graph.ScrollMinY2 = 0D;
            this.graph.Size = new System.Drawing.Size(881, 474);
            this.graph.TabIndex = 1;
            this.graph.UseExtendedPrintDialog = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbBalanced);
            this.groupBox7.Controls.Add(this.btnSampleRunAnalysis);
            this.groupBox7.Controls.Add(this.rbKMeans);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.rbGMM);
            this.groupBox7.Controls.Add(this.numGaussians);
            this.groupBox7.Controls.Add(this.numKMeans);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(265, 597);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "算法及设置";
            // 
            // cbBalanced
            // 
            this.cbBalanced.AutoSize = true;
            this.cbBalanced.Location = new System.Drawing.Point(44, 67);
            this.cbBalanced.Margin = new System.Windows.Forms.Padding(2);
            this.cbBalanced.Name = "cbBalanced";
            this.cbBalanced.Size = new System.Drawing.Size(72, 16);
            this.cbBalanced.TabIndex = 8;
            this.cbBalanced.Text = "Balanced";
            this.cbBalanced.UseVisualStyleBackColor = true;
            // 
            // btnSampleRunAnalysis
            // 
            this.btnSampleRunAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSampleRunAnalysis.Location = new System.Drawing.Point(6, 537);
            this.btnSampleRunAnalysis.Name = "btnSampleRunAnalysis";
            this.btnSampleRunAnalysis.Size = new System.Drawing.Size(253, 40);
            this.btnSampleRunAnalysis.TabIndex = 1;
            this.btnSampleRunAnalysis.Text = "Create clustering";
            this.btnSampleRunAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSampleRunAnalysis.UseVisualStyleBackColor = true;
            this.btnSampleRunAnalysis.Click += new System.EventHandler(this.btnSampleRunAnalysis_Click);
            // 
            // rbKMeans
            // 
            this.rbKMeans.AutoSize = true;
            this.rbKMeans.Checked = true;
            this.rbKMeans.Location = new System.Drawing.Point(19, 19);
            this.rbKMeans.Name = "rbKMeans";
            this.rbKMeans.Size = new System.Drawing.Size(65, 16);
            this.rbKMeans.TabIndex = 6;
            this.rbKMeans.TabStop = true;
            this.rbKMeans.Text = "K-Means";
            this.rbKMeans.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "Gaussians";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "K:";
            // 
            // rbGMM
            // 
            this.rbGMM.AutoSize = true;
            this.rbGMM.Location = new System.Drawing.Point(19, 99);
            this.rbGMM.Name = "rbGMM";
            this.rbGMM.Size = new System.Drawing.Size(119, 16);
            this.rbGMM.TabIndex = 6;
            this.rbGMM.Text = "Gaussian Mixture";
            this.rbGMM.UseVisualStyleBackColor = true;
            // 
            // numGaussians
            // 
            this.numGaussians.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numGaussians.Location = new System.Drawing.Point(107, 120);
            this.numGaussians.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGaussians.Name = "numGaussians";
            this.numGaussians.Size = new System.Drawing.Size(98, 21);
            this.numGaussians.TabIndex = 7;
            this.numGaussians.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numGaussians.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numKMeans
            // 
            this.numKMeans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numKMeans.Location = new System.Drawing.Point(107, 43);
            this.numKMeans.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numKMeans.Name = "numKMeans";
            this.numKMeans.Size = new System.Drawing.Size(98, 21);
            this.numKMeans.TabIndex = 7;
            this.numKMeans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numKMeans.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numKMeans.ValueChanged += new System.EventHandler(this.numKMeans_ValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1158, 603);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "多视角聚类";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 607);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1166, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(183, 17);
            this.lbStatus.Text = "Click on File > Open to begin!";
            // 
            // openMat
            // 
            this.openMat.Location = new System.Drawing.Point(94, 21);
            this.openMat.Name = "openMat";
            this.openMat.Size = new System.Drawing.Size(82, 34);
            this.openMat.TabIndex = 0;
            this.openMat.Text = "打开Mat文件";
            this.openMat.UseVisualStyleBackColor = true;
            this.openMat.Click += new System.EventHandler(this.openMat_Click);
            // 
            // Operate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 629);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Stepmethod);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Operate";
            this.Text = "Operate";
            this.Stepmethod.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.adjustView.ResumeLayout(false);
            this.adjustView.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistributionMeasures)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearningSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clusterInc)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGaussians)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKMeans)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Stepmethod;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button opendb;
        private System.Windows.Forms.Button openurl;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLearningSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label attributeLength;
        private System.Windows.Forms.Label samplesNUm;
        private System.Windows.Forms.Label fileDataName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private ZedGraph.ZedGraphControl graphInput;
        private System.Windows.Forms.DataGridView dgvDistributionMeasures;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLength;
        private System.Windows.Forms.Label dirLocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cbBalanced;
        private System.Windows.Forms.Button btnSampleRunAnalysis;
        private System.Windows.Forms.RadioButton rbKMeans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbGMM;
        private System.Windows.Forms.NumericUpDown numGaussians;
        private System.Windows.Forms.NumericUpDown numKMeans;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private ZedGraph.ZedGraphControl graph;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cluterNum;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView clusterInc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox adjustView;
        private System.Windows.Forms.Button nextView;
        private System.Windows.Forms.Button lastView;
        private System.Windows.Forms.Label viewNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label curView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button openMat;
    }
}