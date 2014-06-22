using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bastion
{
    public partial class Stol : Form
    {

        public int zalihaArtikla = 0;
        public string nazivArtikla = "";
        public int kolicinaArtikla = 0;

        int broj = 0;
        Thread t = null;
        public Stol(int brojStola)
        {
            broj = brojStola;
            InitializeComponent();
            this.AcceptButton = button1;
            
        }

        private void Stol_Load(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            textBox4.Text = broj.ToString();
            comboBox1.Items.Add("Gotovina");
            comboBox1.Items.Add("Kartica");
            comboBox1.SelectedIndex = 0;
            CheckForIllegalCrossThreadCalls = false;
            button1.Enabled = false;
            
        }
        
        float suma = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sifraArtikla = int.Parse(textBox1.Text);
                int kolicinaArtikla = int.Parse(textBox2.Text);
                string upit = "SELECT naziv,prodajna_cijena FROM artikl WHERE sifra_art=" + sifraArtikla;
                List<dodavaj> artikli = dodavaj.selectUrediPojedinogKorisnika("artikl", 7, upit);

                foreach (dodavaj art in artikli)
                {
                    /*this.dataGridView1.Rows[brojacRedova].Cells[0].Value = art.Naziv.ToString();
                    this.dataGridView1.Rows[brojacRedova].Cells[1].Value =  art.Naziv.ToString();
                    this.dataGridView1.Rows[brojacRedova].Cells[2].Value =  art.Naziv.ToString();
                     */

                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    
                    row.Cells[0].Value = art.Naziv.ToString();
                    row.Cells[1].Value = kolicinaArtikla.ToString();
                    row.Cells[2].Value = art.Prodajna_cijena.ToString();
                    //MessageBox.Show(art.Prodajna_cijena.ToString());
                    dataGridView1.Rows.Add(row);
                    suma += kolicinaArtikla * art.Prodajna_cijena;


                }

                textBox6.Text = suma.ToString() + " kn";






                textBox2.Text = "";
                textBox1.Text = "";
                textBox1.Focus();
            }
            catch
            {
                MessageBox.Show("Niste odabrali artikl!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            //MessageBox.Show("relissan!");
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool zastavica = false;

            if (textBox5.Text.ToString() != "")
            {

                string datum = this.textBox3.Text;
                int stol = int.Parse(this.textBox4.Text.ToString());
                int brojGostiju = int.Parse(this.textBox5.Text.ToString());
                string[] iznosRacuna1 = this.textBox6.Text.Split(' ');
                float iznosRacuna = float.Parse(iznosRacuna1[0]);
                int nacinPlacanja = 0;
                if (comboBox1.SelectedIndex == 0)
                {
                    nacinPlacanja = 1;
                }
                else
                {
                    nacinPlacanja = 2;
                }

                //kreiranje računa u bazu...
                string sqlProvjeri = "INSERT INTO racun (idracun,stol,idnacin_placanja,idkorisnik,broj_gostiju,iznos,datum_kreiranja) VALUES(null," + stol + "," + nacinPlacanja + ","+LOG.id+"," + brojGostiju + "," + iznosRacuna + ",'" + datum + "');";
                baza.Instance.IzvrsiUpit(sqlProvjeri);
                //

                //kreiranje stavki zadnjeg kreiranog računa
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    nazivArtikla = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    kolicinaArtikla = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    
                    //
                    /*
                    string nazivArtikla = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    int kolicinaArtikla = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    int zalihaArtikla = 0;
                    string upit3 = "SELECT zaliha FROM artikl WHERE sifra_art=(SELECT sifra_art FROM artikl WHERE naziv='" + nazivArtikla + "')";

                    List<dodavaj> artikli = dodavaj.selectUrediPojedinogKorisnika("artikl", 13, upit3);
                    foreach (dodavaj zaliha in artikli)
                    {
                        zalihaArtikla = int.Parse(zaliha.Narkol.ToString());
                    }*/
                    //
                    if ((zalihaArtikla - kolicinaArtikla) > 0)
                    {
                        string upit = "INSERT INTO stavke_racuna VALUES((SELECT MAX(idracun) FROM racun),(SELECT sifra_art FROM artikl WHERE naziv='" + nazivArtikla + "')," + kolicinaArtikla + ") ";

                        baza.Instance.IzvrsiUpit(upit);

                        string sqlUpdate = "UPDATE artikl SET zaliha=zaliha-" + kolicinaArtikla + " WHERE sifra_art=(SELECT sifra_art FROM artikl WHERE naziv='" + nazivArtikla + "');";
                        //MessageBox.Show(sqlUpdate);
                        baza.Instance.IzvrsiUpit(sqlUpdate);
                        zastavica = true;


                    }
                    else
                    {
                        MessageBox.Show("Naziv:"+nazivArtikla +"\n Trenutna količina: "+zalihaArtikla+"\n Unesena količina: "+kolicinaArtikla+"");
                        zastavica = false;
                    }

                }
                if(zastavica == true){
                MessageBox.Show("Račun je kreiran!");
                }

                this.textBox5.Clear();
                this.textBox6.Clear();
                dataGridView1.Rows.Clear();
                this.textBox1.Focus();

            }
            else
            {
                MessageBox.Show("Niste unijeli broj gostiju!");
            }

           
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            t = new Thread(provjeriZalihe);
            t.Start();
        }
        //dretva
        private void provjeriZalihe()
        {
            string upit3 = "SELECT zaliha FROM artikl WHERE sifra_art=" + textBox1.Text;

            List<dodavaj> artikli = dodavaj.selectUrediPojedinogKorisnika("artikl", 13, upit3);
            foreach (dodavaj zaliha in artikli)
            {
                zalihaArtikla = int.Parse(zaliha.Narkol.ToString());
            }
            int sadada=0;
            int.TryParse(textBox2.Text, out sadada);
            if (sadada > 0)
            {
                if (zalihaArtikla - sadada < 0)
                {
                    MessageBox.Show("Artikl: " + textBox1.Text + " Stanje na zalihama: " + zalihaArtikla.ToString(), "Pogreska", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    button1.Enabled = false;

                }
                else
                {
                    button1.Enabled = true;
                }
            }
            else
                button1.Enabled = false;

        }

        

    }
}
