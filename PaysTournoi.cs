using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class PaysTournoi : Form
    {
        connection c = new connection();
        
        public PaysTournoi()
        {
            InitializeComponent();
        }

        private void PaysTournoi_Load(object sender, EventArgs e)
        {
            try
            {
                c.sqlcon.Open();
                c.da = new SqlDataAdapter("select * from tournoi", c.sqlcon);
                c.da.Fill(c.ds, "tournoi");
                c.sqlcon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                c.da = new SqlDataAdapter("select Pays from tournoi", c.sqlcon);
                for(int i = 0; i < c.ds.Tables["tournoi"].Rows.Count; i++)
                {
                    comboBox1.Items.Add(c.ds.Tables["tournoi"].Rows[i]["Pays"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.da = new SqlDataAdapter("select * from tournoi where Pays='"+comboBox1.SelectedItem.ToString()+"'",c.sqlcon);
            c.da.Fill(c.ds, "tournoi");
            dataGridView1.DataSource = c.ds.Tables["tournoi"];
            
        }
    }
}
