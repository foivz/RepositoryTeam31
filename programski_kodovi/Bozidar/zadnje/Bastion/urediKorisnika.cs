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
    public partial class urediKorisnika : Form
    {
        int idOdabranoga = 0;
        List<dodavaj> artikli;
        string upit = "";

        public urediKorisnika()
        {
            InitializeComponent();
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void urediKorisnika_Load(object sender, EventArgs e)
        {
            List<dodavaj> artikli = dodavaj.select("korisnik", 2);  //2 mi je korisnik
            dataGridView1.DataSource = artikli;
            for (int i = 0; i < 4; i++)
                this.dataGridView1.Columns[i].Visible = false;
            foreach(dodavaj artikl in artikli)
            {
                comboBoxMoj.Items.Add("Ime: " + artikl.Ime + ", Prezime: " + artikl.Prezime);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void comboBoxMoj_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idOdabranoga = comboBoxMoj.SelectedIndex + 1;
            dataGridView1.DataSource = "";
            upit = "select* from korisnik where idkorisnik = '"+ this.idOdabranoga +"';";

            List<dodavaj> artikli2 = dodavaj.selectUrediPojedinogKorisnika("korisnik", 2, upit);  //2 mi je korisnik
            dataGridView1.DataSource = artikli2;
            for (int i = 0; i < 4; i++)
                this.dataGridView1.Columns[i].Visible = false;
            //dataGridView1.Hide();
            //label1.Hide();

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
            buttonSpremi.Text = "Spremi";
            buttonSpremi.Size = new Size(75,23);

            buttonSpremi.MouseClick += spremiPromjenu;
            
            this.Controls.Add(buttonSpremi);

        }

        private void spremiPromjenu(object sender, EventArgs e)
        {
            string upitUpdate = "update korisnik set ime = '" + this.textBox1.Text + "',prezime = '" + this.textBox2.Text + "',broj_ziro = '" + this.textBox6.Text + "',telefon = '" + this.textBox5.Text + "',adresa = '" + this.textBox4.Text + "',grad = '" + this.textBox3.Text + "' where idkorisnik = " + idOdabranoga + ";";
            baza.Instance.IzvrsiUpit(upitUpdate);

        }
    }
}
