using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemControl
{
    public class ClusterLabel
    {
        private int code;
        private string desc;
        private double[][] h;
        private int[] label;

        public int Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public string Desc
        {
            get
            {
                return desc;
            }

            set
            {
                desc = value;
            }
        }

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

