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
        public int idOdabranoga = 0;


        public urediKorisnika()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void urediKorisnika_Load(object sender, EventArgs e)
        {
            List<dodavaj> artikli = dodavaj.select("korisnik", 2);  //2 mi je korisnik
            

            
            foreach (dodavaj korisnik in artikli)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = korisnik.Id.ToString();
                row.Cells[1].Value = korisnik.Idovlasti.ToString();
                row.Cells[2].Value = korisnik.Ime.ToString();
                row.Cells[3].Value = korisnik.Prezime.ToString();
                row.Cells[4].Value = korisnik.Broj_ziro.ToString();
                row.Cells[5].Value = korisnik.Telefon.ToString();
                row.Cells[6].Value = korisnik.Adresa.ToString();
                row.Cells[7].Value = korisnik.Grad.ToString();
                row.Cells[8].Value = korisnik.Username.ToString();
                row.Cells[9].Value = korisnik.Password.ToString();
                dataGridView1.Rows.Add(row);
            }
            dataGridView1.AllowUserToAddRows = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void comboBoxMoj_SelectedIndexChanged(object sender, EventArgs e)
        {



             

        }

     

    

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //odabirem readk za korisnika i ispisujem podatke
            string upit = "";
            if (dataGridView1.RowCount > 1)
            {
                    idOdabranoga = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

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
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string upitUpdate = "update korisnik set ime = '" + this.textBox1.Text + "',prezime = '" + this.textBox2.Text + "',broj_ziro = '" + this.textBox6.Text + "',telefon = '" + this.textBox5.Text + "',adresa = '" + this.textBox4.Text + "',grad = '" + this.textBox3.Text + "' where idkorisnik = " + idOdabranoga + ";";
            baza.Instance.IzvrsiUpit(upitUpdate);

            urediKorisnika urediGa = new urediKorisnika();
            urediGa.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
