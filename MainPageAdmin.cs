using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainPageAdmin : Form
    {
        public MainPageAdmin()
        {
            InitializeComponent();
        }

        private void MainPageAdmin_Load(object sender, EventArgs e)
        {

        }

        private void ManipulateLocationBtn_Click(object sender, EventArgs e)
        {
            ManipulateLocations manipulateLocations = new ManipulateLocations();
            manipulateLocations.Show();
        }

        private void AdminCheckAvailableEvents_Click(object sender, EventArgs e)
        {
            CheckAvailibility checkAvailibility = new CheckAvailibility();
            checkAvailibility.Show();
            
        }
    }
}
