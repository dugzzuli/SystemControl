using Accord.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Math;
using System.Data;
using Accord.MachineLearning.Clustering;

namespace SystemControl.Util
{
    public class ReadMatData
    {
        public static string[] columnNames = new string[] { "X", "Y", "Z", "K", "J" }; // stores the column names for the loaded data

        /// <summary>
        /// 文件路径
        /// </summary>
        private string fName;
        /// <summary>
        /// 路径文件
        /// </summary>
        public string FName
        {
            get
            {
                return fName;
            }

            set
            {
                fName = value;
            }
        }
        /// <summary>
        /// 属性个数
        /// </summary>
        public int Attribute
        {
            get
            {
                return attribute;
            }

            set
            {
                attribute = value;
            }
        }
        /// <summary>
        /// 训练数据键
        /// </summary>
        public string DataKey
        {
            get
            {
                return dataKey;
            }

            set
            {
                dataKey = value;
            }
        }
        /// <summary>
        /// 获取targetkey
        /// </summary>
        public string targetKey = "truelabel";
        /// <summary>
        /// 读取训练数据
        /// </summary>
        public MatNode DataTrain
        {
            get
            {
                return dataTrain;
            }

            set
            {
                dataTrain = value;
            }
        }

        /// <summary>
        /// mat文件读取器
        /// </summary>
        public MatReader Reader
        {
            get
            {
                return reader;
            }

            set
            {
                reader = value;
            }
        }

        public static int ViewNumSum
        {
            get
            {
                return viewNumSum;
            }

            set
            {
                viewNumSum = value;
            }
        }

        public bool MultiViewFlag
        {
            get
            {
                return multiViewFlag;
            }

            set
            {
                multiViewFlag = value;
            }
        }

        /// <summary>
        /// 训练数据键
        /// </summary>
        private string dataKey = "data";
        /// <summary>
        /// 属性个数
        /// </summary>
        private int attribute;
        MatNode dataTrain;
        //读取matlab数据
        MatReader reader;


        /// <summary>
        /// //获取视角个数
        /// </summary>
        private static int viewNumSum;
        private bool multiViewFlag;

        public ReadMatData(string fName)
        {
            this.fName = fName;
        }

        /// <summary>
        /// 初始化 reader
        /// </summary>
        public void initReader()
        {
            if (string.IsNullOrEmpty(FName))
            {
                MessageBox.Show("文件路径未初始化......");
            }
            initReader(FName);
        }
        /// <summary>
        /// 初始化reader
        /// </summary>
        /// <param name="fName">文件路径</param>
        public void initReader(string fName)
        {
            dict.Clear();
            this.FName = fName;
            Reader = new MatReader(fName);
            DataTrain = Reader[DataKey];
            ViewNumSum = DataTrain.Count;
            if (ViewNumSum > 0)
            {
                MultiViewFlag = true;
            }
            else
            {
                MultiViewFlag = false;
            }
        }
        /// <summary>
        /// 获取第几个视图  行为样本 列为属性
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns></returns>
        public byte[,] getDataView(int index = 0, Boolean tran = true)
        {

            if (Reader == null)
            {
                this.initReader();
                DataTrain = Reader[DataKey];
            }
            byte[,] dataRe = (byte[,])DataTrain[index].Value;
            if (tran)
                dataRe = dataRe.Transpose();
            return dataRe;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="display"></param>
        /// <returns></returns>
        public DataTable getDataTableByIndex(int index, int display)
        {
            byte[,] dataDT = getDataView(index, true);
            DataTable dt = new DataTable();
            //建立Columnns数目的列
            for (int i = 0; i < display; i++)
            {
                dt.Columns.Add(new DataColumn((i + 1).ToString()));
            }
            for (int i = 0; i < dataDT.GetLength(0); i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < display; j++)
                {
                    dr[j] = dataDT[i, j];
                }
                dt.Rows.Add(dr);
            }

            return dt;
        }


        public DataTable getDataTableAll(int index)
        {
            byte[,] dataDT = getDataView(index, true);
            DataTable dt = new DataTable();
            //建立Columnns数目的列
            for (int i = 0; i < dataDT.GetLength(1); i++)
            {
                dt.Columns.Add(new DataColumn((i + 1).ToString()));
            }
            for (int i = 0; i < dataDT.GetLength(0); i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dataDT.GetLength(1); j++)
                {
                    dr[j] = dataDT[i, j];
                }
                dt.Rows.Add(dr);
            }

            return dt;
        }

        /// <summary>
        /// 获取第index个视图的属性
        /// </summary>
        /// <param name="index"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public int getDataViewAttribute(int index = 0, Boolean tran = true)
        {

            if (Reader == null)
            {
                this.initReader();
                DataTrain = Reader[DataKey];
            }
            byte[,] dataRe = (byte[,])DataTrain[index].Value;
            if (tran)
                dataRe = dataRe.Transpose();
            return dataRe.GetLength(1);
        }

        /// <summary>
        /// 获取第index个视图的属性
        /// </summary>
        /// <param name="index"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public int getDataViewGndLength(int index = 0, Boolean tran = true)
        {

            if (Reader == null)
            {
                this.initReader();
            }
            byte[,] dataTarget = (byte[,])reader[targetKey][index].Value; ;
            var target = dataTarget.Transpose().To<int[,]>().GetColumn(0);

            return target.Length;
        }

        /// <summary>
        /// 获取目标变量
        /// </summary>
        /// <param name="index"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public int[] getDataViewGnd(int index, Boolean tran = true)
        {

            if (Reader == null)
            {
                this.initReader();
            }
            byte[,] dataTarget = (byte[,])reader[targetKey][index].Value; ;
            var target = dataTarget.Transpose().To<int[,]>().GetColumn(0);

            return target;
        }

        public Dictionary<int, double[,]> dict = new Dictionary<int, double[,]>();

        public double[][] getY(double[,] graph, int index)
        {
            if (graph.GetLength(1) == 2)
            {
                return graph.ToJagged();
            }

            double[][] Y;
            TSNE tSNE = new TSNE()
            {
                Perplexity = 1.5
            };

            if (dict.ContainsKey(index))
            {
                Y = dict[index].ToJagged();
            }
            else
                Y = tSNE.Transform(graph.ToJagged());

            return Y;
        }

        public static double[][] getYOthres(double[,] graph)
        {
            if (graph.GetLength(1) == 2)
            {
                return graph.ToJagged();
            }

            double[][] Y;
            TSNE tSNE = new TSNE()
            {
                Perplexity = 1.5
            };
            Y = tSNE.Transform(graph.ToJagged());
          
            return Y;
        }

    }
}
