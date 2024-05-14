using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Tournoi : Form
    {
        public Tournoi()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MAJ_Click(object sender, EventArgs e)
        {
            MAJoueur maj = new MAJoueur();
            maj.Show();
        }

        private void FormerEq_Click(object sender, EventArgs e)
        {
            FormerEq frm = new FormerEq();
            frm.Show();
        }

        private void JeuS_Click(object sender, EventArgs e)
        {
            JeuxSimple js = new JeuxSimple();
            js.Show();
        }

        private void JeuD_Click(object sender, EventArgs e)
        {
            JeuDouble jd = new JeuDouble();
            jd.Show();
        }

        private void PaysT_Click(object sender, EventArgs e)
        {
            PaysTournoi p = new PaysTournoi();
            p.Show();
        }
    }
}
