using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bastion
{
    public partial class administrator : Form
    {
        public administrator()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Form RefToLogin
        {
            get;
            set;
        }

        private void administrator_Load(object sender, EventArgs e)
        {
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oDJAVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToLogin.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dodaj dodajKorisnika = new dodaj();
            dodajKorisnika.Show();
        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dodajArtikl Dodajartikl = new dodajArtikl();
            Dodajartikl.Show();
        }

        private void popisArtikalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            popisArtikala popis = new popisArtikala();
            popis.Show();
        }

        private void popisDjelatnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaKorisnikacs lista = new listaKorisnikacs();
            lista.Show();
        }

        private void obracuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obracun Obracun = new obracun();
            Obracun.Show();
        }

        private void popisNarudzbiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Popis_narudzbenica pb = new Popis_narudzbenica();
            pb.Show();
        }

        private void najprodavanijiArtiklToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodartikl nkk = new prodartikl();
            nkk.Show();
        }

        private void zaradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            promet p = new promet();
            this.IsMdiContainer = true;
            p.MdiParent = this;
            //p.StartPosition = CenterToParent();
            //p.Enabled = false;
            p.Show();
            //p.ShowDialog(this);
            
        }

        private void brojGostijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statkor qq = new statkor();
            qq.Show();
        }
    }
}
