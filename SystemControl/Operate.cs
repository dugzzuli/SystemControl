using Accord;
using Accord.Controls;
using Accord.IO;
using Accord.MachineLearning;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Distributions.Fitting;
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

using TClustering = Accord.MachineLearning.IMulticlassClassifier<double[], int>;
using TLearning = Accord.MachineLearning.IUnsupervisedLearning<
    Accord.MachineLearning.IMulticlassClassifier<double[], int>, double[], int>;

namespace SystemControl
{
    public partial class Operate : Form
    {
        /// <summary>
        /// 访问dugking的算法网站
        /// </summary>
        public static string Url_DUG = "http://localhost:8080/SpringNMF/demo/getClusterInc";

        /// <summary>
        /// 面板颜色选择
        /// </summary>
        ColorSequenceCollection colors = new ColorSequenceCollection();
        /// <summary>
        /// 存储列名
        /// </summary>
        string[] columnNames; // stores the column names for the loaded data

        /// <summary>
        /// 原始数据矩阵
        /// </summary>
        double[,] sourceMatrix = null;
        string fName = string.Empty;
        /// <summary>
        /// 初始聚类个数
        /// </summary>
        int k = 0;
        /// <summary>
        /// 获取当前数据的一些属性 例如平均值 中值等
        /// </summary>
        private DescriptiveAnalysis sda;
        double[][] observations; // the data points containing the mixture
        /// <summary>
        /// 默认视角个数
        /// </summary>
        public int viewNumSum = 1;
        int currcentView = 0;
        int multiViewFlag = 0;
        public int Columnns = 5;
        TLearning learning;
        TClustering clustering;

        public Operate()
        {
            InitializeComponent();
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel文件|*.xls|csv文件|*.csv|文本文件|*.txt|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fName = openFileDialog.FileName;
                string extension = Path.GetExtension(fName);

                fileDataName.Text = Path.GetFileName(fName);
                dirLocal.Text = Path.GetDirectoryName(fName);

                #region 加载csv文件
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
                        // Create and compute a new Simple Descriptive Analysis
                        if (columnNames.GetTotalLength() > 0)
                        {
                            sda = new DescriptiveAnalysis(columnNames).Learn(sourceMatrix.ToJagged());
                            dgvDistributionMeasures.DataSource = sda.Measures;
                        }
                    }
                    viewNumSum = 1;

                }
                #endregion

                #region 加载excel
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
                            if (columnNames.GetTotalLength() > 0)
                            {
                                sda = new DescriptiveAnalysis(columnNames).Learn(sourceMatrix.ToJagged());
                                dgvDistributionMeasures.DataSource = sda.Measures;
                            }
                        }

                    }
                    viewNumSum = 1;
                }

                #endregion

                if (multiViewFlag == 1)
                {
                    setLNView();
                }
                else
                {
                    nextView.Enabled = false;
                    lastView.Enabled = false;
                }

                var target = sourceMatrix.GetColumn(sourceMatrix.GetLength(1) - 1);
                cluterNum.Text = target.Distinct().Count().ToString();
                numKMeans.Value = target.Distinct().Count();
                numGaussians.Value = target.Distinct().Count();
                samplesNUm.Text = sourceMatrix.GetLength(0).ToString();
                viewNum.Text = viewNumSum.ToString();
                curView.Text = (currcentView + 1).ToString();
                attributeLength.Text = sourceMatrix.GetLength(1).ToString();

                if (viewNumSum == 1)
                {
                    adjustView.Enabled = false;
                }
                else
                {
                    adjustView.Enabled = true;
                }
            }
            //uploadFile(fName);
        }

        private void setLNView()
        {
            if (currcentView == 0)
            {
                lastView.Enabled = false;
                nextView.Enabled = true;
            }
            else if (currcentView == viewNumSum - 1)
            {
                lastView.Enabled = true;
                nextView.Enabled = false;
            }
            else
            {
                lastView.Enabled = true;
                nextView.Enabled = true;
            }



        }
        /// <summary>
        /// 读取
        /// </summary>
        private MatNode readMatData(out int attribute)
        {
            var reader = new MatReader(fName);
            MatNode data = reader["data"];
            viewNumSum = data.Count;
            multiViewFlag = 1;
            byte[,] data1 = (byte[,])data[currcentView].Value;
            DataTable tableSource = new DataTable();
            data1 = data1.Transpose();
            DataTable dt = new DataTable();
            attribute = data1.GetLength(0);
            for (int i = 0; i < Columnns; i++)
            {
                dt.Columns.Add(new DataColumn((i + 1).ToString()));
            }

            for (int i = 0; i < data1.GetLength(0); i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < Columnns; j++)
                {
                    dr[j] = data1[i, j];
                }
                dt.Rows.Add(dr);

            }

            tableSource = dt;
            sourceMatrix = tableSource.ToMatrix(out columnNames);

            this.dgvLearningSource.DataSource = tableSource;

            CreateScatterplot(graphInput, sourceMatrix);
            if (columnNames.GetTotalLength() > 0)
            {
                sda = new DescriptiveAnalysis(columnNames).Learn(sourceMatrix.ToJagged());
                dgvDistributionMeasures.DataSource = sda.Measures;
            }
            return reader["truelabel"];
        }

        /// <summary>
        /// 画散点图
        /// </summary>
        /// <param name="zgc"></param>
        /// <param name="graph"></param>
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

            int lastIndex = graph.GetLength(1) - 1;

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[i, lastIndex] == -1)
                    list1.Add(graph[i, 0], graph[i, 1]);
                if (graph[i, lastIndex] == 1)
                    list2.Add(graph[i, 0], graph[i, 1]);
            }



            // Add the curve
            LineItem myCurve = myPane.AddCurve("G1", list1, Color.Red, SymbolType.Diamond);
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

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="fName"></param>
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

        private void graphInput_DoubleClick(object sender, EventArgs e)
        {
            if (sourceMatrix != null && sourceMatrix.GetTotalLength() > 0)
            {
                ScatterplotBox.Show("大图", sourceMatrix.GetColumns(0, 1), sourceMatrix.GetColumn(3).ToInt32()).Hold();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnSampleRunAnalysis_Click(object sender, EventArgs e)
        {

            if (rbKMeans.Checked)
            {
                k = (int)numKMeans.Value;

            }
            if (rbGMM.Checked)
            {
                k = (int)numGaussians.Value;
            }
            if (dgvLearningSource.DataSource == null)
            {
                MessageBox.Show("Please load some data first.");
                return;
            }
            // Finishes and save any pending changes to the given data
            dgvLearningSource.EndEdit();



            // Creates a matrix from the entire source data table
            double[,] table = (dgvLearningSource.DataSource as DataTable).ToMatrix(out columnNames);

            // Get only the input vector values (first two columns)
            //用来进行可视化的维度展示
            double[][] inputs = table.GetColumns(0, 1).ToJagged();
            //用来进行训练的数据
            double[,] table2 = table;
            observations = table2.RemoveColumn(table.GetLength(1) - 1).ToJagged();

            try
            {
                // Create and run the specified algorithm
                this.learning = createClustering(observations);

                this.clustering = this.learning.Learn(observations);

                lbStatus.Text = "聚类完成.....";

                // Update the scatter plot
                CreateScatterplot(graph, inputs, k);

                // Classify all instances in mixture data
                int[] classifications = clustering.Decide(observations);


                updateGraph(classifications);


                int[] expected = table.GetColumn(table.GetLength(1) - 1).ToInt32();
                ;

                StringBuilder sb = new StringBuilder();
                expected.ToList().ForEach(u =>
                {
                    sb.Append(u + ",");
                });

                StringBuilder sb2 = new StringBuilder();
                classifications.ToList().ForEach(u =>
                {
                    sb2.Append(u + ",");
                });
                String Predicted = sb2.ToString().Trim(',');
                String Expected = sb.ToString().Trim(',');

                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("Predicted", Predicted);
                dic.Add("Expected", Expected);
                String jsonResult = WebUtil.Post3(Url_DUG, dic);

                MessageBox.Show(jsonResult);
            }
            catch (ConvergenceException)
            {
                lbStatus.Text = "Convergence could not be attained. " +
                    "The learned clustering might still be usable.";
            }


        }

        private void updateGraph(int[] classifications)
        {

            // Paint the clusters accordingly
            for (int i = 0; i < k + 1; i++)
                graph.GraphPane.CurveList[i].Clear();

            for (int j = 0; j < observations.Length; j++)
            {
                int c = classifications[j];

                var curveList = graph.GraphPane.CurveList[c + 1];
                double[] point = observations[j];
                curveList.AddPoint(point[0], point[1]);
            }

            graph.Invalidate();
        }


        /// <summary>
        ///   Creates the clustering algorithm.
        /// </summary>
        /// 
        private TLearning createClustering(double[][] data)
        {
            if (rbKMeans.Checked)
            {
                if (cbBalanced.Checked)
                {
                    return new BalancedKMeans((int)numKMeans.Value)
                    {
                        MaxIterations = 1000,
                    };
                }

                return new KMeans((int)numKMeans.Value);
            }


            if (rbGMM.Checked)
            {
                return new GaussianMixtureModel((int)numGaussians.Value)
                {
                    Options = new NormalOptions()
                    {
                        Regularization = 1e-10
                    }
                };
            }

            throw new InvalidOperationException("Invalid options");
        }

        private void numKMeans_ValueChanged(object sender, EventArgs e)
        {
            this.k = (int)numKMeans.Value;
        }

        public void CreateScatterplot(ZedGraphControl zgc, double[][] graph, int n)
        {
            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();

            // Set graph pane object
            // Set the titles
            myPane.Title.Text = fileDataName.Text;
            myPane.XAxis.Title.Text = columnNames[0];
            myPane.YAxis.Title.Text = columnNames[1];
            //myPane.XAxis.Scale.Max = 10;
            //myPane.XAxis.Scale.Min = -10;
            //myPane.YAxis.Scale.Max = 10;
            //myPane.YAxis.Scale.Min = -10;
            myPane.XAxis.IsAxisSegmentVisible = true;
            myPane.YAxis.IsAxisSegmentVisible = true;
            myPane.YAxis.IsVisible = true;
            myPane.XAxis.IsVisible = true;
            myPane.Border.IsVisible = true;


            // Create mixture pairs
            PointPairList list = new PointPairList();
            for (int i = 0; i < graph.Length; i++)
                list.Add(graph[i][0], graph[i][1]);


            // Add the curve for the mixture points
            LineItem myCurve = myPane.AddCurve("Mixture", list, Color.Gray, SymbolType.Diamond);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Gray);

            for (int i = 0; i < n; i++)
            {
                // Add curves for the clusters to be detected
                Color color = colors[i];
                myCurve = myPane.AddCurve("D" + (i + 1), new PointPairList(), color, SymbolType.Diamond);
                myCurve.Line.IsVisible = false;
                myCurve.Symbol.Border.IsVisible = false;
                myCurve.Symbol.Fill = new Fill(color);
            }

            // Fill the background of the chart rect and pane
            myPane.Fill = new Fill(Color.WhiteSmoke);

            zgc.AxisChange();
            zgc.Invalidate();
        }

        private void lastView_Click(object sender, EventArgs e)
        {
            int attribute = 0;
            currcentView = currcentView - 1;
            if (currcentView < int.Parse(viewNum.Text) && currcentView >= 0)
            {
                readMatData(out attribute);
                curView.Text = (currcentView + 1).ToString();
                setLNView();
            }
        }

        private void nextView_Click(object sender, EventArgs e)
        {
            int attribute = 0;
            currcentView = currcentView + 1;
            if (currcentView < int.Parse(viewNum.Text) && currcentView >= 0)
            {
                readMatData(out attribute);
                curView.Text = (currcentView + 1).ToString();
                setLNView();
            }
        }

        private void openMat_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Mat文件|*.mat";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fName = openFileDialog.FileName;
                string extension = Path.GetExtension(fName);

                fileDataName.Text = Path.GetFileName(fName);
                dirLocal.Text = Path.GetDirectoryName(fName);

                MatNode gnd = null;
                int attribute = 0;
                #region 读取mat文件
                if (extension == ".mat")
                {
                    gnd = readMatData(out attribute);
                }
                #endregion

                if (multiViewFlag == 1)
                {
                    setLNView();
                }
                else
                {
                    nextView.Enabled = false;
                    lastView.Enabled = false;
                }
                byte[,] data1 = (byte[,])gnd[0].Value; ;
                var target = data1.Transpose().To<int[,]>().GetColumn(0);
                cluterNum.Text = target.Distinct().Count().ToString();
                numKMeans.Value = target.Distinct().Count();
                numGaussians.Value = target.Distinct().Count();
                samplesNUm.Text = sourceMatrix.GetLength(1).ToString();
                viewNum.Text = viewNumSum.ToString();
                curView.Text = (currcentView + 1).ToString();
                attributeLength.Text = attribute.ToString();

                if (viewNumSum == 1)
                {
                    adjustView.Enabled = false;
                }
                else
                {
                    adjustView.Enabled = true;
                }
            }
        }

        private void dgvLearningSource_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
       e.RowBounds.Location.Y,
       dgvLearningSource.RowHeadersWidth - 4,
       e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics,
                  (e.RowIndex + 1).ToString(),
                   dgvLearningSource.RowHeadersDefaultCellStyle.Font,
                   rectangle,
                   dgvLearningSource.RowHeadersDefaultCellStyle.ForeColor,
                   TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
    }


}


