using Accord.Controls;
using Accord.IO;
using Accord.Math;
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
using ZedGraph;

namespace SystemControl
{
    public partial class Operate : Form
    {

        string[] columnNames; // stores the column names for the loaded data
        double[,] sourceMatrix;

        public Operate()
        {
            InitializeComponent();
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "文本文件|*.txt|csv文件|*.csv|Excel文件|*.xls|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fName = openFileDialog.FileName;
                string extension = Path.GetExtension(fName);
                if (extension == ".csv")
                {
                    CsvReader csvR = new CsvReader(fName, false);

                    DataTable tableSource = csvR.ToTable();

                   sourceMatrix = tableSource.ToMatrix(out columnNames);



                    // Detect the kind of problem loaded.
                    if (sourceMatrix.GetLength(1) == 2)
                    {
                        MessageBox.Show("Missing class column.");
                    }
                    else
                    {
                        this.dgvLearningSource.DataSource = tableSource;
                        CreateScatterplot(graphInput, sourceMatrix);
                      
                    }

                }


                if (extension == ".xls" || extension == ".xlsx")
                {
                    ExcelReader db = new ExcelReader(fName, true, false);
                    TableSelectDialog t = new TableSelectDialog(db.GetWorksheetList());
                    if (t.ShowDialog(this) == DialogResult.OK)
                    {

                        DataTable tableSource = db.GetWorksheet(t.Selection);

                        sourceMatrix = tableSource.ToMatrix(out columnNames);



                        // Detect the kind of problem loaded.
                        if (sourceMatrix.GetLength(1) == 2)
                        {
                            MessageBox.Show("Missing class column.");
                        }
                        else
                        {
                            this.dgvLearningSource.DataSource = tableSource;
                          


                            CreateScatterplot(graphInput, sourceMatrix);
                        }
                    }
                }
            }
            //uploadFile(fName);
        }

      
        public void CreateScatterplot(ZedGraphControl zgc, double[,] graph)
        {
            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();

            // Set the titles
            myPane.Title.IsVisible = false;
            myPane.XAxis.Title.Text = columnNames[0];
            myPane.YAxis.Title.Text = columnNames[1];


            // Classification problem
            PointPairList list1 = new PointPairList(); // Z = -1
            PointPairList list2 = new PointPairList(); // Z = +1

            int lastIndex = graph.GetLength(1)-1;
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[i, lastIndex] == -1)
                    list1.Add(graph[i, 0], graph[i, 1]);
                if (graph[i, lastIndex] == 1)
                    list2.Add(graph[i, 0], graph[i, 1]);
            }

            // Add the curve
            LineItem myCurve = myPane.AddCurve("G1", list1, Color.Blue, SymbolType.Diamond);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Blue);

            myCurve = myPane.AddCurve("G2", list2, Color.Green, SymbolType.Diamond);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Green);


            myPane.Fill = new Fill(Color.WhiteSmoke);

            zgc.AxisChange();
            zgc.Invalidate();
        }

        private static void uploadFile(string fName)
        {
            string url = "http://localhost:8080/SpringNMF/demo/upload";

            List<FormItemModel> formDatas = new List<FormItemModel>();
            //添加文件
            formDatas.Add(new FormItemModel()
            {
                Key = "file",
                Value = "",
                FileName = Path.GetFileName(fName),
                FileContent = File.OpenRead(fName)
            });

            //提交表单
            string result = UploadFile.PostForm(url, formDatas);


            MessageBox.Show("已上传" + "   返回信息：" + result.ToString());
        }

        private void graphInput_Load(object sender, EventArgs e)
        {
          
        }

        private void graphInput_Click(object sender, EventArgs e)
        {
            ScatterplotBox.Show("大图", sourceMatrix.GetColumns(0, 1), sourceMatrix.GetColumn(3).ToInt32()).Hold();
        }
    }


}


