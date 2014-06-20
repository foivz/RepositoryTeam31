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

        private void urediToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            urediKorisnika urediGa= new urediKorisnika();
            urediGa.Show();
        }

        private void izbrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brisiKorisnika brisiGa = new brisiKorisnika();
            brisiGa.Show();
        }

        private void dodajToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            unesiNamirnicu dodajNamirnicu = new unesiNamirnicu();
            dodajNamirnicu.Show();
        }
    }
}
