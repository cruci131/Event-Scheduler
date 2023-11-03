using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace WindowsFormsApp2
{
    public partial class report1 : Form
    {
        Reprots r;
        public report1()
        {
            InitializeComponent();

        }

        private void report1_Load(object sender, EventArgs e)
        {
            r = new Reprots();
            foreach(ParameterDiscreteValue v in r.ParameterFields[0].DefaultValues)
            {
                creationDateBox.Items.Add(v.Value);
            }
        }

        private void GenerateReportBtn_Click(object sender, EventArgs e)
        {
            r.SetParameterValue(0, creationDateBox.Text);
            crystalReportViewer1.ReportSource = r;
        }
    }
}
