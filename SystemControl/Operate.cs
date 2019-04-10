using Accord;
using Accord.Controls;
using Accord.IO;
using Accord.MachineLearning;
using Accord.MachineLearning.Clustering;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Distributions.Fitting;
using Newtonsoft.Json;
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
using SystemControl.Util;
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
        public static string Url_DUG = "http://localhost:8080/SpringNMF/demo/getMVCLuster";
        private static string uploadUrl = "http://localhost:8080/SpringNMF/demo/upload";
        /// <summary>
        /// 面板颜色选择
        /// </summary>
        ColorSequenceCollection colors = new ColorSequenceCollection();
        /// <summary>
        /// 初始聚类个数
        /// </summary>
        int k = 0;
        /// <summary>
        /// 获取当前数据的一些属性 例如平均值 中值等
        /// </summary>
        private DescriptiveAnalysis sda;
        /// <summary>
        /// 默认视角个数
        /// </summary>
        int currcentView = 0;
        private ReadOfficeFile readOfficeFile;


        ReadMatData readMatDataUtil;
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
                string fName = null;
                fName = openFileDialog.FileName;
                readOfficeFile = new ReadOfficeFile(fName);
                readOfficeFile.initReader(this);
                fileDataName.Text = readOfficeFile.FileDataName;
                dirLocal.Text = readOfficeFile.DirLocal;
                var target = readOfficeFile.getMatrixTarget();
                cluterNum.Text = target.Distinct().Count().ToString();
                numKMeans.Value = target.Distinct().Count();
                numGaussians.Value = target.Distinct().Count();
                samplesNUm.Text = readOfficeFile.getMatrixTargetLength().ToString();
                viewNum.Text = ReadMatData.ViewNumSum.ToString();
                curView.Text = (currcentView + 1).ToString();
                attributeLength.Text = readOfficeFile.getMatrixTrainLength().ToString();

                this.dgvLearningSource.DataSource = readOfficeFile.TableSource;

                DrawUtil.CreateScatterplot(graphInput, readOfficeFile.getMatrixTrain());

                if (ReadMatData.columnNames.GetTotalLength() > 0)
                {
                    sda = new DescriptiveAnalysis(ReadMatData.columnNames).Learn(readOfficeFile.getMatrixTrain().ToJagged());
                    dgvDistributionMeasures.DataSource = sda.Measures;
                }

                if (ReadMatData.ViewNumSum == 1)
                {
                    setLNView();
                }
                else
                {
                    nextView.Enabled = false;
                    lastView.Enabled = false;
                }



                if (ReadMatData.ViewNumSum == 1)
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
            else if (currcentView == ReadMatData.ViewNumSum - 1)
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
        /// mat图绘制
        /// </summary>
        /// <param name="zgc"></param>
        /// <param name="graph"></param>
        /// <param name="target"></param>
        private void CreateScatterplot(ZedGraphControl zgc, double[,] graph, int[] target)
        {
            var Y = readMatDataUtil.getY(graph, currcentView);
            //为空则不进行操作
            if (Y != null)
            {
                GraphPane myPane = zgc.GraphPane;
                myPane.CurveList.Clear();
                // Set the titles
                myPane.Title.IsVisible = false;
                myPane.XAxis.Title.Text = ReadMatData.columnNames[0];
                myPane.YAxis.Title.Text = ReadMatData.columnNames[1];
                // Classification problem
                PointPairList list1 = new PointPairList(); // Z = -1

                for (int i = 0; i < Y.GetLength(0); i++)
                {
                    list1.Add(Y[i][0], Y[i][1]);
                }
                // Add the curve
                LineItem myCurve = myPane.AddCurve("散点图", list1, Color.Red, SymbolType.Diamond);

                myCurve.Line.IsVisible = false;
                myCurve.Symbol.Border.IsVisible = false;
                myCurve.Symbol.Fill = new Fill(Color.Blue);

                myPane.Fill = new Fill(Color.WhiteSmoke);

                zgc.AxisChange();
                zgc.Invalidate();
            }
        }


        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="fName"></param>
        private static void uploadFile(string fName)
        {
            string url = uploadUrl;

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
            //if (sourceMatrix != null && sourceMatrix.GetTotalLength() > 0)
            //{
            //    ScatterplotBox.Show("大图", sourceMatrix.GetColumns(0, 1), sourceMatrix.GetColumn(3).ToInt32()).Hold();
            //}
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
        double[][] observations;


        private void btnSampleRunAnalysis_Click(object sender, EventArgs e)
        {
            string extension = Path.GetExtension(fileDataName.Text);

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

            double[,] table = null;
            int[] expected = null;
            if (extension == ".csv" || extension == ".xls" || extension == ".xlsx")
            {
                table = readOfficeFile.getMatrixTrain();
                expected = readOfficeFile.getMatrixTarget().ToInt32();
            }
            else
            {
                table = readMatDataUtil.getDataView(currcentView).ToDouble();
                expected = readMatDataUtil.getDataViewGnd(currcentView);
            }


            // Get only the input vector values (first two columns)
            //用来进行可视化的维度展示
            double[][] inputs = table.ToJagged();

            //用来进行训练的数据

            observations = inputs;
            try
            {
                // Create and run the specified algorithm
                this.learning = createClustering(observations);

                this.clustering = this.learning.Learn(observations);



                // Update the scatter plot
                CreateScatterplot(graph, inputs, k);

                // Classify all instances in mixture data
                int[] classifications = clustering.Decide(observations);


                updateGraph(classifications);


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
                //String jsonResult = WebUtil.Post3(Url_DUG, dic);
                //String jsonResult = WebUtil.Post3(http://localhost:8080/SpringNMF/demo/getMVCLuster?method=MNMF&maxIter=100&relarErr=1, dic);

                //MessageBox.Show(jsonResult);
            }
            catch (ConvergenceException)
            {
                //lbStatus.Text = "Convergence could not be attained. " +
                //    "The learned clustering might still be usable.";
            }


        }

        private void updateGraph(int[] classifications)
        {
            observations = ReadMatData.getYOthres(observations.ToMatrix());
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

        private void updateGraph(ZedGraphControl mvCluster, double[][] observations2, int[] classifications)
        {
            observations2 = ReadMatData.getYOthres(observations2.ToMatrix());
            // Paint the clusters accordingly
            for (int i = 0; i < k + 1; i++)
                mvCluster.GraphPane.CurveList[i].Clear();


            for (int j = 0; j < observations2.Length; j++)
            {
                int c = classifications[j];

                var curveList = mvCluster.GraphPane.CurveList[c + 1];
                double[] point = observations2[j];
                curveList.AddPoint(point[0], point[1]);
            }

            mvCluster.Invalidate();
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

        public void CreateScatterplot(ZedGraphControl zgc, double[][] graphs, int n)
        {

            var graph = ReadMatData.getYOthres(graphs.ToMatrix());

            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();

            // Set graph pane object
            // Set the titles
            myPane.Title.Text = fileDataName.Text;
            myPane.XAxis.Title.Text = ReadMatData.columnNames[0];
            myPane.YAxis.Title.Text = ReadMatData.columnNames[1];
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
            currcentView = currcentView - 1;
            if (currcentView < int.Parse(viewNum.Text) && currcentView >= 0)
            {
                //前五个属性进行展示
                this.dgvLearningSource.DataSource = readMatDataUtil.getDataTableByIndex(currcentView, ReadMatData.columnNames.Length);

                //columnNames为列名，本项目直接进行初始化，因为大部分的列属性信息都比较多。
                if (ReadMatData.columnNames.GetTotalLength() > 0)
                {
                    sda = new DescriptiveAnalysis(ReadMatData.columnNames).Learn(readMatDataUtil.getDataTableByIndex(currcentView, ReadMatData.columnNames.Length).ToJagged());
                    dgvDistributionMeasures.DataSource = sda.Measures;
                }
                CreateScatterplot(graphInput, readMatDataUtil.getDataTableAll(currcentView).ToMatrix(), readMatDataUtil.getDataViewGnd(currcentView));
                curView.Text = (currcentView + 1).ToString();
                setLNView();
            }
        }

        private void nextView_Click(object sender, EventArgs e)
        {
            currcentView = currcentView + 1;
            if (currcentView < int.Parse(viewNum.Text) && currcentView >= 0)
            {
                //前五个属性进行展示
                this.dgvLearningSource.DataSource = readMatDataUtil.getDataTableByIndex(currcentView, ReadMatData.columnNames.Length);

                //columnNames为列名，本项目直接进行初始化，因为大部分的列属性信息都比较多。
                if (ReadMatData.columnNames.GetTotalLength() > 0)
                {
                    sda = new DescriptiveAnalysis(ReadMatData.columnNames).Learn(readMatDataUtil.getDataTableByIndex(currcentView, ReadMatData.columnNames.Length).ToJagged());
                    dgvDistributionMeasures.DataSource = sda.Measures;
                }
                CreateScatterplot(graphInput, readMatDataUtil.getDataTableAll(currcentView).ToMatrix(), readMatDataUtil.getDataViewGnd(currcentView));
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
                var fName = openFileDialog.FileName;
                string extension = Path.GetExtension(fName);
                fileDataName.Text = Path.GetFileName(fName);
                dirLocal.Text = Path.GetDirectoryName(fName);
                if (extension != ".mat")
                {
                    MessageBox.Show("请输入matlab文件...");
                    return;
                }
                readMatDataUtil = new ReadMatData(fName);
                readMatDataUtil.initReader();
                int[] target = readMatDataUtil.getDataViewGnd(0);
                cluterNum.Text = target.Distinct().Count().ToString();
                numKMeans.Value = target.Distinct().Count();
                numGaussians.Value = target.Distinct().Count();
                samplesNUm.Text = target.Length.ToString();
                viewNum.Text = ReadMatData.ViewNumSum.ToString();
                curView.Text = (currcentView + 1).ToString();
                attributeLength.Text = readMatDataUtil.getDataViewAttribute().ToString();

                //前五个属性进行展示
                this.dgvLearningSource.DataSource = readMatDataUtil.getDataTableByIndex(0, ReadMatData.columnNames.Length);

                //columnNames为列名，本项目直接进行初始化，因为大部分的列属性信息都比较多。
                if (ReadMatData.columnNames.GetTotalLength() > 0)
                {
                    sda = new DescriptiveAnalysis(ReadMatData.columnNames).Learn(readMatDataUtil.getDataTableByIndex(0, ReadMatData.columnNames.Length).ToJagged());
                    dgvDistributionMeasures.DataSource = sda.Measures;
                }
                CreateScatterplot(graphInput, readMatDataUtil.getDataTableAll(0).ToMatrix(), target);

                if (readMatDataUtil.MultiViewFlag)
                {
                    setLNView();
                }
                else
                {
                    nextView.Enabled = false;
                    lastView.Enabled = false;
                }




                if (ReadMatData.ViewNumSum == 1)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = readMatDataUtil.FName;
            //uploadFile(fname);

            if (MNMF.Checked)
            {

            }
            else
            {

            }
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("datasets", "3sources.mat");
            dic.Add("method", "MNMF");
            dic.Add("maxIter", "100");
            dic.Add("relarErr", "1");
            String jsonResult = WebUtil.Post3(Url_DUG, dic);
            ClusterLabel json = JsonConvert.DeserializeObject<ClusterLabel>(jsonResult);
            CreateScatterplot(mvCluster, json.H, Convert.ToInt32(numericUpDown2.Value));
            int[] classifications = json.Label;
            updateGraph(mvCluster, json.H, classifications);
        }
    }


}


