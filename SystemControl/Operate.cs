using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemControl
{
    public partial class Operate : Form
    {
        public Operate()
        {
            InitializeComponent();
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "文本文件|*.txt|csv文件|*.csv|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fName = openFileDialog.FileName;


                WebClient myWebClient = new WebClient();

                //UploadFileUtil.UploadFile(fName, "http://127.0.0.1:8080/SpringNMF/demo/upload");
                //myWebClient.UploadFile("http://localhost:8080/SpringNMF/demo/upload", "POST", fName);


                var url = "http://localhost:8080/SpringNMF/demo/upload";
                var log1 = fName;

                var formDatas = new List<FormItemModel>();
                //添加文件
                formDatas.Add(new FormItemModel()
                {
                    Key = "file",
                    Value = "",
                    FileName = "log1.txt",
                    FileContent = File.OpenRead(log1)
                });
              
                //提交表单
                var result =UploadFile.PostForm(url, formDatas);
  

                MessageBox.Show("已上传");
            }
        }
    }
}

