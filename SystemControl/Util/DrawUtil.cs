using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace SystemControl.Util
{
    public class DrawUtil
    {
        public static void CreateScatterplot(ZedGraphControl zgc, double[,] sourceMatrix)
        {
            var Y = ReadMatData.getYOthres(sourceMatrix);
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
    }
}
