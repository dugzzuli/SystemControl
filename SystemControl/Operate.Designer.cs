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
            this.Stepmethod = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.generate = new System.Windows.Forms.Button();
            this.opendb = new System.Windows.Forms.Button();
            this.openurl = new System.Windows.Forms.Button();
            this.openmat = new System.Windows.Forms.Button();
            this.openfile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLearningSource = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileDataName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.attributeLength = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.samplesNUm = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.graphInput = new ZedGraph.ZedGraphControl();
            this.Stepmethod.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearningSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Stepmethod
            // 
            this.Stepmethod.Controls.Add(this.tabPage1);
            this.Stepmethod.Controls.Add(this.tabPage2);
            this.Stepmethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stepmethod.Location = new System.Drawing.Point(0, 0);
            this.Stepmethod.Name = "Stepmethod";
            this.Stepmethod.SelectedIndex = 0;
            this.Stepmethod.Size = new System.Drawing.Size(772, 593);
            this.Stepmethod.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "预处理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(577, 21);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(82, 34);
            this.generate.TabIndex = 0;
            this.generate.Text = "生成数据";
            this.generate.UseVisualStyleBackColor = true;
            // 
            // opendb
            // 
            this.opendb.Location = new System.Drawing.Point(432, 21);
            this.opendb.Name = "opendb";
            this.opendb.Size = new System.Drawing.Size(93, 34);
            this.opendb.TabIndex = 0;
            this.opendb.Text = "从数据库打开";
            this.opendb.UseVisualStyleBackColor = true;
            // 
            // openurl
            // 
            this.openurl.Location = new System.Drawing.Point(286, 21);
            this.openurl.Name = "openurl";
            this.openurl.Size = new System.Drawing.Size(96, 34);
            this.openurl.TabIndex = 0;
            this.openurl.Text = "打开链接数据";
            this.openurl.UseVisualStyleBackColor = true;
            // 
            // openmat
            // 
            this.openmat.Location = new System.Drawing.Point(158, 21);
            this.openmat.Name = "openmat";
            this.openmat.Size = new System.Drawing.Size(82, 34);
            this.openmat.TabIndex = 0;
            this.openmat.Text = "打开Mat文件";
            this.openmat.UseVisualStyleBackColor = true;
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(20, 21);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(82, 34);
            this.openfile.TabIndex = 0;
            this.openfile.Text = "打开文件";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "聚类";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openfile);
            this.groupBox1.Controls.Add(this.generate);
            this.groupBox1.Controls.Add(this.openmat);
            this.groupBox1.Controls.Add(this.opendb);
            this.groupBox1.Controls.Add(this.openurl);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "训练数据";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLearningSource);
            this.groupBox2.Location = new System.Drawing.Point(9, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 380);
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
            this.dgvLearningSource.Size = new System.Drawing.Size(300, 360);
            this.dgvLearningSource.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.attributeLength);
            this.groupBox3.Controls.Add(this.samplesNUm);
            this.groupBox3.Controls.Add(this.fileDataName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 78);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据信息";
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
            // fileDataName
            // 
            this.fileDataName.AutoSize = true;
            this.fileDataName.Location = new System.Drawing.Point(77, 21);
            this.fileDataName.Name = "fileDataName";
            this.fileDataName.Size = new System.Drawing.Size(41, 12);
            this.fileDataName.TabIndex = 1;
            this.fileDataName.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "属性：";
            // 
            // attributeLength
            // 
            this.attributeLength.AutoSize = true;
            this.attributeLength.Location = new System.Drawing.Point(195, 45);
            this.attributeLength.Name = "attributeLength";
            this.attributeLength.Size = new System.Drawing.Size(41, 12);
            this.attributeLength.TabIndex = 1;
            this.attributeLength.Text = "label2";
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
            // samplesNUm
            // 
            this.samplesNUm.AutoSize = true;
            this.samplesNUm.Location = new System.Drawing.Point(77, 45);
            this.samplesNUm.Name = "samplesNUm";
            this.samplesNUm.Size = new System.Drawing.Size(41, 12);
            this.samplesNUm.TabIndex = 1;
            this.samplesNUm.Text = "label2";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(335, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(421, 199);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "当前属性";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.graphInput);
            this.groupBox5.Location = new System.Drawing.Point(335, 298);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(421, 255);
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
            this.graphInput.Size = new System.Drawing.Size(415, 235);
            this.graphInput.TabIndex = 5;
            this.graphInput.UseExtendedPrintDialog = true;
            this.graphInput.Load += new System.EventHandler(this.graphInput_Load);
            this.graphInput.Click += new System.EventHandler(this.graphInput_Click);
            // 
            // Operate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 593);
            this.Controls.Add(this.Stepmethod);
            this.Name = "Operate";
            this.Text = "Operate";
            this.Stepmethod.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearningSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Stepmethod;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button opendb;
        private System.Windows.Forms.Button openurl;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.Button openmat;
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
    }
}