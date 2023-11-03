using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApp2
{
    public partial class AddAdmin : Form
    {
        string ordb = "data source = orcl; user id = hr; password = hr;";
        OracleConnection conn;
        OracleCommand cmd;
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {
           conn = new OracleConnection(ordb);
           
           
        }

        private void AdminAdd_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "Add_Admin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Fname", AdminSignUpTextFname.Text);
            cmd.Parameters.Add("Lname", AdminSignUpTextLname.Text);
            cmd.Parameters.Add("Email", AdminSignUpTextEmail.Text);
            cmd.Parameters.Add("pass", AdminSignUpTextPass.Text);
            cmd.Parameters.Add("Address", AdminSignUpTextAddress.Text);
            cmd.Parameters.Add("Age", AdminSignUpTextAge.Text);
            if (AdminGenderMale.Checked)
            {
                cmd.Parameters.Add("gender", 'm');
            }
            else
            {
                cmd.Parameters.Add("gender", 'f');
            }
            cmd.Parameters.Add("date", DateTime.Now);
            cmd.ExecuteNonQuery();
            AdminSignUpTextFname.Clear();
            AdminSignUpTextLname.Clear();
            AdminSignUpTextEmail.Clear();
            AdminSignUpTextPass.Clear();
            AdminSignUpTextAddress.Clear();
            AdminSignUpTextAge.Clear();
            AdminGenderFemale.Checked = false;
            AdminGenderMale.Checked = false;
            conn.Close();
        }
    }
}
