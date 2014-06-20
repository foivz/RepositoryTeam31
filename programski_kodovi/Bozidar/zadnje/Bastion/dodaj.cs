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
    public partial class dodaj : Form
    {
        public dodaj()
        {
            InitializeComponent();
            comboBox1.Items.Add("Administrator");
            comboBox1.Items.Add("Konobar");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = textBox1.Text;
            string prezime = textBox2.Text;
            string grad = textBox3.Text;
            string adresa = textBox4.Text;
            string telefon = textBox5.Text;
            string ziro_racun = textBox6.Text;
            string kor_ime = textBox7.Text;
            int ovlast_id = comboBox1.SelectedIndex + 1;
            string lozinka = textBoxLozinka.Text;
            //MessageBox.Show(ovlast_id.ToString());

            string upit = "insert into korisnik(idkorisnik,idovlasti,ime,prezime,broj_ziro,telefon,adresa,grad,username,password) values(null,'"+ovlast_id+"','"+ime+"','"+prezime+"','"+ziro_racun+"','"+telefon+"','"+adresa+"','"+grad+"','"+kor_ime+"','"+lozinka+"')";
            baza.Instance.IzvrsiUpit(upit);


        }
    }
}
