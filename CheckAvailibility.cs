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
    public partial class CheckAvailibility : Form
    {

        
        OracleDataAdapter adapter;
        string ordb = "data source = orcl; user id = hr; password = hr;";
        OracleConnection conn;

        OracleCommandBuilder builder;
        DataSet ds;
        public CheckAvailibility()
        {
            InitializeComponent();
        }
       
        private void CheckAvailibility_Load(object sender, EventArgs e)
        {
            int type;
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            string constr = "data source = orcl;user Id = hr;Password = hr;";
            string cmdstr = "select * from pending_events where status = 'n'";
            cmd.CommandText = "EVENTVALIDATION";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("type", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            type = Convert.ToInt32(cmd.Parameters["type"].Value.ToString());    
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            if (type == 0)
            {
                adapter.Fill(ds);
                pendingGridView.DataSource = ds.Tables[0];
            }
            conn.Close();
        }
        private void SaveStatustBtn_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            int rowindex = pendingGridView.CurrentCell.RowIndex;
            pendingGridView.Rows.RemoveAt(rowindex);

        }
    }
}
