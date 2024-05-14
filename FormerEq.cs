using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace PingPong
{
    public partial class FormerEq : Form
    {
        connection c = new connection();
        public FormerEq()
        {
            InitializeComponent();
        }

        private void FormerEq_Load(object sender, EventArgs e)
        {
            //Debugger.Break();
            try
            {
                c.sqlcon.Open();
                c.da = new SqlDataAdapter("select * from joueur", c.sqlcon);
                c.da.Fill(c.ds, "joueur");
                for (int i = 0; i < c.ds.Tables["joueur"].Rows.Count; i++)
                {
                    comboBox1.Items.Add(c.ds.Tables["joueur"].Rows[i][0]);
                    comboBox2.Items.Add(c.ds.Tables["joueur"].Rows[i][0]);
                }
                c.sqlcon.Close();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.da = new SqlDataAdapter("select * from joueur where Nojoueur='"+comboBox1.SelectedItem.ToString()+"'",c.sqlcon);
            c.da.Fill(c.ds, "joueur");
            for (int i = 0; i < c.ds.Tables["joueur"].Rows.Count; i++)
            {
                textBox2.Text= c.ds.Tables["joueur"].Rows[i][1].ToString();
                textBox3.Text= c.ds.Tables["joueur"].Rows[i][2].ToString();
                textBox4.Text= c.ds.Tables["joueur"].Rows[i][3].ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.da = new SqlDataAdapter("select * from joueur where Nojoueur='" + comboBox2.SelectedItem.ToString() + "'", c.sqlcon);
            c.da.Fill(c.ds, "joueur");
            for (int i = 0; i < c.ds.Tables["joueur"].Rows.Count; i++)
            {
                textBox6.Text = c.ds.Tables["joueur"].Rows[i][1].ToString();
                textBox7.Text = c.ds.Tables["joueur"].Rows[i][2].ToString();
                textBox8.Text = c.ds.Tables["joueur"].Rows[i][3].ToString();
            }
        }

        private void Former_Click(object sender, EventArgs e)
        {
            c.sqlcon.Open();
            c.da = new SqlDataAdapter("select * from equipe", c.sqlcon);
            c.da.Fill(c.ds, "equipe");
            c.sqlcon.Close();
            DataRow dr = c.ds.Tables["equipe"].NewRow();
            dr[0] = textBox1.Text;
            c.ds.Tables["equipe"].Rows.Add(dr);
            MessageBox.Show("nouveau equipe formee");
        }

        private void FormerEq_FormClosing(object sender, FormClosingEventArgs e)
        {
            c.da = new SqlDataAdapter("select * from equipe", c.sqlcon);
            SqlCommandBuilder eng = new SqlCommandBuilder(c.da);
            c.da.Update(c.ds, "equipe");
        }
    }
}
