using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemControl
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void datacluster_Click(object sender, EventArgs e)
        {
            Operate openCluster = new Operate();
            openCluster.ShowDialog();
        }

        private void hnetwork_Click(object sender, EventArgs e)
        {
          
        }
    }
}
