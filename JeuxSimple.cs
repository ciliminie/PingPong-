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
    public partial class JeuxSimple : Form
    {
        connection c = new connection();
        public JeuxSimple()
        {
            InitializeComponent();
        }

        private void JeuxSimple_Load(object sender, EventArgs e)
        {
            try
            {
                c.sqlcon.Open();
                c.da = new SqlDataAdapter("select * from joueur", c.sqlcon);
                c.da.Fill(c.ds, "joueur");
                for (int i = 0; i < c.ds.Tables["joueur"].Rows.Count; i++)
                {
                    listBox1.Items.Add(c.ds.Tables["joueur"].Rows[i][0]);
                    //listBox2.Items.Add(c.ds.Tables["joueur"].Rows[i][0]);
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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.da = new SqlDataAdapter("select * from joueur where Nojoueur='" + listBox1.SelectedItem.ToString() + "'", c.sqlcon);
            c.da.Fill(c.ds, "joueur");
            for (int i = 0; i < c.ds.Tables["joueur"].Rows.Count; i++)
            {
                textBox1.Text = c.ds.Tables["joueur"].Rows[i][1].ToString();
                textBox2.Text = c.ds.Tables["joueur"].Rows[i][2].ToString();
                textBox3.Text = c.ds.Tables["joueur"].Rows[i][3].ToString();
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

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                c.sqlcon.Open();
                c.da = new SqlDataAdapter("select * from jeu_simple", c.sqlcon);
                c.da.Fill(c.ds, "jeu_simple");
                c.sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataRow dr = c.ds.Tables["jeu_simple"].NewRow();
            dr[0] = listBox1.SelectedItem.ToString();
            dr[1]= listBox2.SelectedItem.ToString();
            dr[2] = textBox8.Text;
            if(textBox8.Text == "")
            {
                MessageBox.Show("erreur remplir les champs");
            }
            else
            {
                c.ds.Tables["jeu_simple"].Rows.Add(dr);
                MessageBox.Show("Score Ajoutee");
            }
        }

        private void JeuxSimple_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Voulez-vous enregistrer les modifications?", "Enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                c.da = new SqlDataAdapter("select * from jeu_simple", c.sqlcon);
                SqlCommandBuilder eng = new SqlCommandBuilder(c.da);
                c.da.Update(c.ds, "jeu_simple");
            }
            else if(d == DialogResult.No)
            {
                this.Close();
                this.Close();
            }
        }
    }
}
