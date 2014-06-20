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
    public partial class brisiKorisnika : Form
    {

        int idOdabranoga = 0;
        List<dodavaj> artikli;
        string upit = "";
        public brisiKorisnika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMoj_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idOdabranoga = comboBoxMoj.SelectedIndex + 1;
            upit = "select* from korisnik where idkorisnik = '" + this.idOdabranoga + "';";
            List<dodavaj> artikli2 = dodavaj.selectUrediPojedinogKorisnika("korisnik", 2, upit);  //2 mi je korisnik


            foreach (dodavaj podatak in artikli2)
            {
                this.textBox1.Text = podatak.Ime;
                this.textBox2.Text = podatak.Prezime;
                this.textBox3.Text = podatak.Grad;
                this.textBox4.Text = podatak.Adresa;
                this.textBox5.Text = podatak.Telefon;
                this.textBox6.Text = podatak.Broj_ziro;
            }
            Button buttonSpremi = new Button();
            buttonSpremi.Location = new Point(label5.Location.X, label5.Location.Y + 50);
            buttonSpremi.Text = "Obrisi";
            buttonSpremi.Size = new Size(75, 23);

            buttonSpremi.MouseClick += obrisiPromjenu;

            this.Controls.Add(buttonSpremi);
        }

        private void brisiKorisnika_Load(object sender, EventArgs e)
        {
            List<dodavaj> artikli = dodavaj.select("korisnik", 2);  //2 mi je korisnik
            foreach (dodavaj artikl in artikli)
            {
                comboBoxMoj.Items.Add("Ime: " + artikl.Ime + ", Prezime: " + artikl.Prezime);
            }
        }

        private void obrisiPromjenu(object sender, EventArgs e)
        {
            string upit = "delete from korisnik where idkorisnik = " + idOdabranoga;

            baza.Instance.IzvrsiUpit(upit);

            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";


        }
    }
}
