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
    public partial class ManipulateLocations : Form
    {
        string ordb = "data source = orcl; user id = hr; password = hr;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public ManipulateLocations()
        {
            InitializeComponent();
        }

        private void ManipulateLocations_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            string constr = "data source = orcl;user Id = hr;Password = hr;";
            string cmdstr = "select * from locations";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            locationGridview.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void locationGridview_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {
            
        }
        public void BindGrid()
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void locationGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            int rowindex = locationGridview.CurrentCell.RowIndex;
            locationGridview.Rows.RemoveAt(rowindex);
            OracleCommand cmd = new OracleCommand("delete locations where l_id ='" + rowindex + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succesfully deleted");
            conn.Close();
            BindGrid();
        }
    }
}
