using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class JeuDouble : Form
    {
        connection c = new connection();
        public JeuDouble()
        {
            InitializeComponent();
        }

        private void JeuDouble_Load(object sender, EventArgs e)
        {
            try
            {
                c.sqlcon.Open();
                c.da = new SqlDataAdapter("select * from tournoi", c.sqlcon);
                c.da.Fill(c.ds, "tournoi");
                for (int i = 0; i < c.ds.Tables["tournoi"].Rows.Count; i++)
                {
                    listBox2.Items.Add(c.ds.Tables["tournoi"].Rows[i][0]);

                }
                c.sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                c.sqlcon.Open();
                c.da = new SqlDataAdapter("select * from equipe", c.sqlcon);
                c.da.Fill(c.ds, "equipe");
                for (int i = 0; i < c.ds.Tables["equipe"].Rows.Count; i++)
                {
                    comboBox1.Items.Add(c.ds.Tables["equipe"].Rows[i][0]);

                }
                c.sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                c.sqlcon.Open();
                c.da = new SqlDataAdapter("select * from jeu_double", c.sqlcon);
                c.da.Fill(c.ds, "jeu_double");
                c.sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.da = new SqlDataAdapter("select * from tournoi where Notournoi='" + listBox2.SelectedItem.ToString() + "'", c.sqlcon);
            c.da.Fill(c.ds, "tournoi");
            for (int i = 0; i < c.ds.Tables["tournoi"].Rows.Count; i++)
            {
                textBox4.Text = c.ds.Tables["tournoi"].Rows[i][1].ToString();
                textBox5.Text = c.ds.Tables["tournoi"].Rows[i][2].ToString();
                textBox6.Text = c.ds.Tables["tournoi"].Rows[i][3].ToString();
                textBox7.Text = c.ds.Tables["tournoi"].Rows[i][4].ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                c.sqlcon.Open();
                c.da = new SqlDataAdapter("select * from joueur", c.sqlcon);
                c.da.Fill(c.ds, "joueur");
                c.sqlcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Debugger.Break();
            c.da = new SqlDataAdapter("select top 1 j.Nomjoueur,j.Noequipe from joueur j where j.Noequipe=(select Noequipe from equipe where Noequipe='" + comboBox1.SelectedItem.ToString() + "')", c.sqlcon);
            c.da.Fill(c.ds, "joueur");
            for (int i = 0; i < c.ds.Tables["joueur"].Rows.Count; i++)
            {
                textBox1.Text = c.ds.Tables["joueur"].Rows[i][1].ToString();
                //textBox2.Text = c.ds.Tables["joueur"].Rows[i][1].ToString();
            }
            c.da = new SqlDataAdapter("select top 1 j.Nomjoueur,j.Noequipe from joueur j where j.Noequipe=(select Noequipe from equipe where Noequipe='" + comboBox1.SelectedItem.ToString() + "')", c.sqlcon);
            c.da.Fill(c.ds, "joueur");
            for (int i = 1; i < c.ds.Tables["joueur"].Rows.Count; i++)
            {
                //textBox1.Text = c.ds.Tables["joueur"].Rows[i][1].ToString();
                textBox2.Text = c.ds.Tables["joueur"].Rows[i][1].ToString();

            }
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            DataRow dr = c.ds.Tables["jeu_double"].NewRow();
            dr[0] = comboBox1.SelectedItem.ToString();
            dr[1] = listBox2.SelectedItem.ToString();
            dr[2] = textBox8.Text;
            c.ds.Tables["jeu_double"].Rows.Add(dr);
        }

        private void JeuDouble_FormClosing(object sender, FormClosingEventArgs e)
        {
                c.da = new SqlDataAdapter("select * from jeu_double", c.sqlcon);
                SqlCommandBuilder eng = new SqlCommandBuilder(c.da);
                c.da.Update(c.ds, "jeu_double");
        }
    }
}
