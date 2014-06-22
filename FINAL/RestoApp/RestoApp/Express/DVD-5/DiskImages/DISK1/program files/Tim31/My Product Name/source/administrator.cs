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
            //treba otvorit folder di su svi PDF-ovi
            System.Diagnostics.Process.Start(@"Potvrde\");
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

        private void izbrisiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            briasnjeArtikl brisi = new briasnjeArtikl();
            //this.IsMdiContainer = true;
           // brisi.Parent = this;
            brisi.Show();
        }

        private void urediToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            urediArtkl uredi = new urediArtkl();
            uredi.Show();
        }

        private void naruciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            naruciArtikl naruci = new naruciArtikl();
            naruci.Show();
        }

        private void urediToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            urediKorisnika urediGa = new urediKorisnika();
            urediGa.Show();
        }

        private void izbrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brisiKorisnika korisnikBrisi = new brisiKorisnika();
            korisnikBrisi.Show();
        }

        private void kreirajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kreirajNarudzbu narudzba = new kreirajNarudzbu();
            narudzba.Show();
        }

        private void popisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            popisNarudzbi popisNar = new popisNarudzbi();
            popisNar.Show();
        }

        private void obracuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obracun obracuni = new obracun();
            obracuni.Show();
        }

        private void brojGostijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statkor stat = new statkor();
            stat.Show();
        }

        private void zaradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            promet p = new promet();
            //this.IsMdiContainer = true;
            //p.MdiParent = this;
            //p.StartPosition = CenterToParent();
            //p.Enabled = false;
            p.Show();
            //p.ShowDialog(this);
        }

        private void najprodavanijiArtiklToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodartikl nkk = new prodartikl();
            nkk.Show();
        }

        private void pOMOĆF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"Korisnicka dokumentacija\Korisnicka dokumentacija.pdf");
            }
            catch
            {

            }
        }

        private void administrator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                
                    try
            {
                System.Diagnostics.Process.Start(@"Korisnicka dokumentacija\Korisnicka dokumentacija.pdf");
            }
            catch
            {

            }

            }
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kONOBARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
