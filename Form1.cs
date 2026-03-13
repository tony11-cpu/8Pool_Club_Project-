using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPoolClubProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlPoolStation1_OnGameFinish_1(object sender, clsUtils.cls8PoolEventArgs e)
        {
            StringBuilder TableResults = new StringBuilder();

            TableResults.Append("Time Consumed " + e.TimeConsumed);
            TableResults.Append(", Total Seconds= " + e.TotalSeconds);
            TableResults.Append(", HourlyRate = " + e.HoulyRate.ToString());
            TableResults.Append(", Total Fees=" + e.TotalFees.ToString());

            MessageBox.Show(TableResults.ToString());
        }
    }
}
