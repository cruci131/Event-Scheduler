using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApp2
{
    public partial class MainPageManager : Form
    {
        public MainPageManager()
        {
            InitializeComponent();
        }

        private void AddAdminBtn_Click(object sender, EventArgs e)
        {
            AddAdmin addAdmin = new AddAdmin();
            addAdmin.Show();
        }

        private void viewReportsBtn_Click(object sender, EventArgs e)
        {
            report1 report = new report1();
            report.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eventTypesGrouped g = new eventTypesGrouped();
            g.Show();
        }

        private void MainPageManager_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            man_Events w = new man_Events();
            w.Show();
        }
    }
}
