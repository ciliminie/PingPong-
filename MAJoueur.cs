using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PingPong
{
    public partial class MAJoueur : Form
    {
        connection c = new connection();
        int pos = -1,position;
        public MAJoueur()
        {
            InitializeComponent();
        }
        public void naviguer()
        {
            textBox1.Text = c.ds.Tables["joueur"].Rows[position][0].ToString();
            textBox2.Text= c.ds.Tables["joueur"].Rows[position][1].ToString();
            textBox3.Text= c.ds.Tables["joueur"].Rows[position][2].ToString();
            textBox4.Text= c.ds.Tables["joueur"].Rows[position][3].ToString();
        }

        private void Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            DataRow dr = c.ds.Tables["joueur"].NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = textBox4.Text;
            c.ds.Tables["joueur"].Rows.Add(dr);
            MessageBox.Show("Ajoutee");
        }

        private void MAJoueur_Load(object sender, EventArgs e)
        {
            c.sqlcon.Open();
            c.da = new SqlDataAdapter("select * from joueur", c.sqlcon);
            c.da.Fill(c.ds, "joueur");
            c.sqlcon.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            c.sqlcon.Open();
            c.da = new SqlDataAdapter("select * from joueur", c.sqlcon);
            SqlCommandBuilder eng = new SqlCommandBuilder(c.da);
            c.da.Update(c.ds, "joueur");
            MessageBox.Show("bien enregistrer");
            c.sqlcon.Close();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            for(int i=0;i< c.ds.Tables["joueur"].Rows.Count; i++)
            {
                if(textBox1.Text == c.ds.Tables["joueur"].Rows[i][0].ToString())
                {
                    pos = i;
                    break;
                }
                if(pos == -1)
                {
                    MessageBox.Show("Erreur");
                }
                else
                {
                    c.ds.Tables["joueur"].Rows[pos][0] = textBox1.Text;
                    c.ds.Tables["joueur"].Rows[pos][1] = textBox2.Text;
                    c.ds.Tables["joueur"].Rows[pos][2] = textBox3.Text;
                    c.ds.Tables["joueur"].Rows[pos][3] = textBox4.Text;
                    MessageBox.Show("Modification Reussie");
                }
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < c.ds.Tables["joueur"].Rows.Count; i++)
            {
                if (textBox1.Text == c.ds.Tables["joueur"].Rows[i][0].ToString())
                {
                    pos = i;
                    break;
                }
                if (pos == -1)
                {
                    MessageBox.Show("Erreur");
                }
                else
                {
                    c.ds.Tables["joueur"].Rows[pos].Delete();
                    MessageBox.Show("Supprimer Reussie");
                }
            }
        }

        private void Precedente_Click(object sender, EventArgs e)
        {
            position -= 1;
            naviguer();
        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            position += 1;
            naviguer();
        }

        private void Dernier_Click(object sender, EventArgs e)
        {
            position = c.ds.Tables["joueur"].Rows.Count - 1;
            naviguer();
        }

        private void Premier_Click(object sender, EventArgs e)
        {
            position = 0;
            naviguer();
        }
    }
}
