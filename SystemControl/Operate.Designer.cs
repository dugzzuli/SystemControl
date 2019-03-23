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
            this.Stepmethod = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openfile = new System.Windows.Forms.Button();
            this.openurl = new System.Windows.Forms.Button();
            this.opendb = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.openmat = new System.Windows.Forms.Button();
            this.Stepmethod.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.Stepmethod.Size = new System.Drawing.Size(772, 552);
            this.Stepmethod.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.generate);
            this.tabPage1.Controls.Add(this.opendb);
            this.tabPage1.Controls.Add(this.openurl);
            this.tabPage1.Controls.Add(this.openmat);
            this.tabPage1.Controls.Add(this.openfile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "预处理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "聚类";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(26, 19);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(82, 34);
            this.openfile.TabIndex = 0;
            this.openfile.Text = "打开文件";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // openurl
            // 
            this.openurl.Location = new System.Drawing.Point(238, 19);
            this.openurl.Name = "openurl";
            this.openurl.Size = new System.Drawing.Size(96, 34);
            this.openurl.TabIndex = 0;
            this.openurl.Text = "打开链接数据";
            this.openurl.UseVisualStyleBackColor = true;
            // 
            // opendb
            // 
            this.opendb.Location = new System.Drawing.Point(360, 19);
            this.opendb.Name = "opendb";
            this.opendb.Size = new System.Drawing.Size(93, 34);
            this.opendb.TabIndex = 0;
            this.opendb.Text = "从数据库打开";
            this.opendb.UseVisualStyleBackColor = true;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(493, 19);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(82, 34);
            this.generate.TabIndex = 0;
            this.generate.Text = "生成数据";
            this.generate.UseVisualStyleBackColor = true;
            // 
            // openmat
            // 
            this.openmat.Location = new System.Drawing.Point(131, 19);
            this.openmat.Name = "openmat";
            this.openmat.Size = new System.Drawing.Size(82, 34);
            this.openmat.TabIndex = 0;
            this.openmat.Text = "打开Mat文件";
            this.openmat.UseVisualStyleBackColor = true;
            // 
            // Operate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 552);
            this.Controls.Add(this.Stepmethod);
            this.Name = "Operate";
            this.Text = "Operate";
            this.Stepmethod.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
    }
}