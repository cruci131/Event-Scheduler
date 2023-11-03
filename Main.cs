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
    
    public partial class Main : Form
    {
        public static string e_mail;
        string ordb = "data source = orcl; user id = hr; password = hr;";
        OracleConnection conn;
        OracleCommand cmd;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb); 

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            int check;
            int type;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "Login";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("email", login_text_email.Text);
            cmd.Parameters.Add("pass", login_text_pass.Text);
            cmd.Parameters.Add("check", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("type", OracleDbType.Int32, ParameterDirection.Output);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                login_text_email.Clear();
                login_text_pass.Clear();
                MessageBox.Show("Invalid Login");
                
            }
            check = Convert.ToInt32(cmd.Parameters["check"].Value.ToString());
            type = Convert.ToInt32(cmd.Parameters["type"].Value.ToString());
            if (check == 0)
            {
                login_text_email.Clear();
                login_text_pass.Clear();
                MessageBox.Show("invalid Login");
            }
            else
            {
                e_mail = login_text_email.Text.ToString();
                switch (type)
                {
                    case 0:
                        {

                            MainPageAdmin mainPageAdmin = new MainPageAdmin();
                            mainPageAdmin.Show();
                            this.Hide();
                            break;
                        }
                    case 1:
                        {
                            MainPageClient mp = new MainPageClient();
                            mp.Show();
                            this.Hide();
                            break;
                        }
                    case 2:
                        {
                            MainPageManager mainPageManager = new MainPageManager();
                            mainPageManager.Show();
                            this.Hide();
                            break;
                        }
                }
            }

            conn.Close();
        }
        private void SignUp_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "User_Registeration";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Fname", SignUpTextFname.Text);
            cmd.Parameters.Add("Lname", SignUpTextLname.Text);
            cmd.Parameters.Add("Email", SignUpTextEmail.Text);
            cmd.Parameters.Add("pass", SignUpTextPass.Text);
            cmd.Parameters.Add("Address", SignUpTextAddress.Text);
            cmd.Parameters.Add("Age", SignUpTextAge.Text);
            if (GenderMale.Checked)
            {
                cmd.Parameters.Add("gender", 'm');
            }
            else
            {
                cmd.Parameters.Add("gender", 'f');
            }
            cmd.Parameters.Add("date", DateTime.Now);
            cmd.ExecuteNonQuery();
            SignUpTextFname.Clear();
            SignUpTextLname.Clear();
            SignUpTextEmail.Clear();
            SignUpTextPass.Clear();
            SignUpTextAddress.Clear();
            SignUpTextAge.Clear();
            GenderFemale.Checked = false;
            GenderMale.Checked = false;
            conn.Close();
        }

        private void SignInpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegDirect_Click(object sender, EventArgs e)
        {
            SignUppanel.BringToFront();
        }
    }
}
