
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApp2
{
    public partial class Client : Form
    {
        string ordb = "data source = orcl;user Id = hr;Password = hr;";
        OracleConnection conn;
        DataSet ds;
        OracleDataAdapter adapter;
        

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load_1(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select distinct area from locations";
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                user_AreaCombox.Items.Add(dr[0]);
            }
            dr.Close();
            cmd.CommandText = "select distinct event_type from supported_event_types";
            OracleDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                user_eventTypeCombox.Items.Add(dr1[0]);
            }
            dr1.Close();
            conn.Close();
        }

       

        private void user_search_Click(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select_Location";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("eventType", user_eventTypeCombox.Text);
            cmd.Parameters.Add("capacity", user_capacityText.Text);
            cmd.Parameters.Add("budget", user_budgetText.Text);
            cmd.Parameters.Add("area", user_AreaCombox.Text);
            cmd.Parameters.Add("time", user_TimeText.Text);
            cmd.Parameters.Add("date", Convert.ToDateTime(user_dateSelection.Text));
            cmd.Parameters.Add("LocationsList", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                l_name_box.Items.Add(reader[0]);
            }
            reader.Close();
            if(l_name_box.Items.Count == 0)
            {
                user_eventTypeCombox.SelectedIndex = -1;
                user_AreaCombox.SelectedIndex = -1;
                user_capacityText.Clear();
                user_budgetText.Clear();
                user_TimeText.Clear();
                user_dateSelection.Clear();
                MessageBox.Show("No Available Locations");
            }
            conn.Close();
        }
        private void l_name_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "select budget, capacity from locations where lname= :location";
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("location", l_name_box.Text.ToString());
            OracleDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                l_budget_text.Text = reader1[0].ToString();
                l_capacity_text.Text = reader1[1].ToString();
            }
            reader1.Close();
            conn.Close();
        }

        private void RegEventBtn_Click_1(object sender, EventArgs e)
        {

            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Register_event";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("name", l_name_box.SelectedItem.ToString());
            cmd.Parameters.Add("email", Main.e_mail);
            cmd.Parameters.Add("date", Convert.ToDateTime(user_dateSelection.Text));
            cmd.Parameters.Add("time", user_TimeText.Text);
            cmd.Parameters.Add("event_type", user_eventTypeCombox.SelectedItem.ToString());
            cmd.Parameters.Add("capacity", Convert.ToInt32(user_capacityText.Text));
            cmd.Parameters.Add("budget", Convert.ToInt32(user_budgetText.Text));
            cmd.Parameters.Add("area", user_AreaCombox.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Event info successfully added");
            conn.Close();
            EditEventClient.BringToFront();
       
            string cmdstr = "select p.LOCATION_ID, p.DATE_, p.TIME_, p.EVENT_TYPE, p.CAPACITY, p.BUDGET, p.AREA from pending_events p where p.EMAIL = :name";
            
            string constr = "data source = orcl;user Id = hr;Password = hr;";
            
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("name", Main.e_mail);
            ds = new DataSet();
            adapter.Fill(ds);
            editEventGridView.DataSource = ds.Tables[0];
        }

        private void EditEventClient_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
