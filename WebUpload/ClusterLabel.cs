using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUpload
{
    public class ClusterLabel
    {
        private double[][] h;
        private int[] label;

        public double[][] H
        {
            get
            {
                return h;
            }

            set
            {
                h = value;
            }
        }

        public int[] Label
        {
            get
            {
                return label;
            }

            set
            {
                label = value;
            }
        }
    }
}
