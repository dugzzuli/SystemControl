using Accord.IO;
using Accord.Statistics.Analysis;
using MathWorks.MATLAB.NET.Arrays;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WebUpload
{
    class Program
    {

        static void Main(string[] args)
        {
            string str = File.ReadAllText(@"txt.txt");
          
            JsonReader reader = new JsonTextReader(new StringReader(str));

            while (reader.Read())
            {
                Console.WriteLine(reader.TokenType + "\t\t" + reader.ValueType + "\t\t" + reader.Value + "\r\n");
            }

            ClusterLabel json=JsonConvert.DeserializeObject<ClusterLabel>(str);

        }

        private static void NewMethod()
        {
            string localPath = "3sources.mat";

            // Create a .MAT reader for the file:
            var reader = new MatReader(localPath);
            MatNode data = reader["data"];
            byte[,] data1 = (byte[,])data[0].Value;
            Console.WriteLine(data1);
            double[,] mat = new double[data1.GetLength(0), data1.GetLength(1)];
            for (int i = 0; i < data1.GetLength(0); i++)
            {
                for (int j = 0; j < data1.GetLength(1); j++)
                {
                    mat[i, j] = data1[i, j];
                }

            }
        }

        /// <summary>  
        /// byte数组转int数组  
        /// </summary>  
        /// <param name="src">源byte数组</param>  
        /// <param name="offset">起始位置</param>  
        /// <returns></returns>  
        public static int[] bytesToInt(byte[] src, int offset)
        {
            int[] values = new int[src.Length / 4];
            for (int i = 0; i < src.Length / 4; i++)
            {
                int value = (int)((src[offset] & 0xFF)
                        | ((src[offset + 1] & 0xFF) << 8)
                        | ((src[offset + 2] & 0xFF) << 16)
                        | ((src[offset + 3] & 0xFF) << 24));
                values[i] = value;

                offset += 4;
            }
            return values;
        }




        private static void matlabGet()
        {
            MatlabDemo.MeasureTools demo = new MatlabDemo.MeasureTools();


            int[,] list = { { 1 }, { 2 } }; //列向量
            int[,] list2 = { { 1 }, { 1 } }; //列向量
            MWArray a = 1;
            MWArray array = new MWNumericArray(list);
            MWArray array2 = new MWNumericArray(list2);
            MWArray[] d = demo.CalcMetrics(3, array, array2);
        }

        private static void getPreAcc()
        {
            // The correct and expected output values (as confirmed by a Gold
            //  standard rule, actual experiment or true verification)
            int[] expected = { 1, 1, 1, 0, 0, 0 };

            // The values as predicted by the decision system or
            //  the test whose performance is being measured.
            int[] predicted = { -1, -1, -1, 1, 1, 1 };

            PALabel p = new PALabel();
            StringBuilder sb = new StringBuilder();
            expected.ToList().ForEach(u =>
            {
                sb.Append(u + ",");
            });

            StringBuilder sb2 = new StringBuilder();
            predicted.ToList().ForEach(u =>
            {
                sb2.Append(u + ",");
            });

            p.Predicted = sb2.ToString().Trim(',');
            p.Expected = sb.ToString().Trim(',');

            Console.WriteLine(JsonConvert.SerializeObject(p));
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Predicted", p.Predicted);
            dic.Add("Expected", p.Expected);
            //// Create a new confusion matrix using the given parameters
            //ConfusionMatrix matrix = new ConfusionMatrix(predicted, expected);
            //Console.WriteLine(matrix.NormalizedMutualInformation);
            Console.WriteLine(Post3("http://localhost:8080/SpringNMF/demo/getClusterInc", dic));
        }

        public  static string Post2(string Url, string jsonParas)
        {
            string strURL = Url ;

            //创建一个HTTP请求  
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
            //Post请求方式  
            request.Method = "POST";
            //内容类型
            request.ContentType = "application/x-www-form-urlencoded";

            //设置参数，并进行URL编码  
            //虽然我们需要传递给服务器端的实际参数是JsonParas(格式：[{\"UserID\":\"0206001\",\"UserName\":\"ceshi\"}])，
            //但是需要将该字符串参数构造成键值对的形式（注："paramaters=[{\"UserID\":\"0206001\",\"UserName\":\"ceshi\"}]"），
            //其中键paramaters为WebService接口函数的参数名，值为经过序列化的Json数据字符串
            //最后将字符串参数进行Url编码
            string paraUrlCoded = System.Web.HttpUtility.UrlEncode("paramaters");
            paraUrlCoded += "=" + System.Web.HttpUtility.UrlEncode(jsonParas);

            byte[] payload;
            //将Json字符串转化为字节  
            payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
            //设置请求的ContentLength   
            request.ContentLength = payload.Length;
            //发送请求，获得请求流  

            Stream writer;
            try
            {
                writer = request.GetRequestStream();//获取用于写入请求数据的Stream对象
            }
            catch (Exception)
            {
                writer = null;
                Console.Write("连接服务器失败!");
            }
            //将请求参数写入流
            writer.Write(payload, 0, payload.Length);
            writer.Close();//关闭请求流

            String strValue = "";//strValue为http响应所返回的字符流
            HttpWebResponse response;
            try
            {
                //获得响应流
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                response = ex.Response as HttpWebResponse;
            }

            Stream s = response.GetResponseStream();

            //服务器端返回的是一个XML格式的字符串，XML的Content才是我们所需要的Json数据
            XmlTextReader Reader = new XmlTextReader(s);
            Reader.MoveToContent();
            strValue = Reader.ReadInnerXml();//取出Content中的Json数据
            Reader.Close();
            s.Close();

            return strValue;//返回Json数据
        }

        /// <summary>
        /// 指定Post地址使用Get 方式获取全部字符串
        /// </summary>
        /// <param name="url">请求后台地址</param>
        /// <returns></returns>
        public static string Post3(string url, Dictionary<string, string> dic)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            #region 添加Post 参数
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (var item in dic)
            {
                if (i > 0)
                    builder.Append("&");
                builder.AppendFormat("{0}={1}", item.Key, item.Value);
                i++;
            }
            byte[] data = Encoding.UTF8.GetBytes(builder.ToString());
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            #endregion
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        /// <summary>
        /// 指定Post地址使用Get 方式获取全部字符串
        /// </summary>
        /// <param name="url">请求后台地址</param>
        /// <returns></returns>
        public static string Post(string url,Dictionary<string,string> dic)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            #region 添加Post 参数
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (var item in dic)
            {
                if (i > 0)
                    builder.Append("&");
                builder.AppendFormat("{0}={1}", item.Key, item.Value);
                i++;
            }
            byte[] data = Encoding.UTF8.GetBytes(builder.ToString());
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            #endregion
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        public static string Post(string Url, string jsonParas)
        {
            string strURL = Url;

            //创建一个HTTP请求  
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
            //Post请求方式  
            request.Method = "POST";
            //内容类型
            request.ContentType = "application/x-www-form-urlencoded";

            //设置参数，并进行URL编码 

            string paraUrlCoded = jsonParas;//System.Web.HttpUtility.UrlEncode(jsonParas);   

            byte[] payload;
            //将Json字符串转化为字节  
            payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
            //设置请求的ContentLength   
            request.ContentLength = payload.Length;
            //发送请求，获得请求流 

            Stream writer;
            try
            {
                writer = request.GetRequestStream();//获取用于写入请求数据的Stream对象
            }
            catch (Exception)
            {
                writer = null;
                Console.Write("连接服务器失败!");
            }
            //将请求参数写入流
            writer.Write(payload, 0, payload.Length);
            writer.Close();//关闭请求流

            String strValue = "";//strValue为http响应所返回的字符流
            HttpWebResponse response;
            try
            {
                //获得响应流
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                response = ex.Response as HttpWebResponse;
            }

            Stream s = response.GetResponseStream();
            StreamReader sRead = new StreamReader(s);
            string postContent = sRead.ReadToEnd();
            sRead.Close();


            return postContent;//返回Json数据
        }

     }
    class PALabel {
       string expected;
       string predicted;

        public string Expected
        {
            get
            {
                return expected;
            }

            set
            {
                expected = value;
            }
        }

        public string Predicted
        {
            get
            {
                return predicted;
            }

            set
            {
                predicted = value;
            }
        }
    }
}
