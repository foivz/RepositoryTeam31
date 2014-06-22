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
    public partial class Stol : Form
    {

        int broj = 0;
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
            
        }
        
        float suma = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int sifraArtikla = int.Parse(textBox1.Text);
            int kolicinaArtikla = int.Parse(textBox2.Text);
            string upit = "SELECT naziv,prodajna_cijena FROM artikl WHERE sifra_art="+sifraArtikla;
            List<dodavaj> artikli = dodavaj.selectUrediPojedinogKorisnika("artikl", 7,upit);
            
            foreach(dodavaj art in artikli)
            {
                /*this.dataGridView1.Rows[brojacRedova].Cells[0].Value = art.Naziv.ToString();
                this.dataGridView1.Rows[brojacRedova].Cells[1].Value =  art.Naziv.ToString();
                this.dataGridView1.Rows[brojacRedova].Cells[2].Value =  art.Naziv.ToString();
                 */

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = art.Naziv.ToString();
                row.Cells[1].Value = kolicinaArtikla.ToString();
                row.Cells[2].Value = art.Prodajna_cijena.ToString();
                dataGridView1.Rows.Add(row);
                suma += kolicinaArtikla * art.Prodajna_cijena;
                

            }

            textBox6.Text = suma.ToString() + " kn";
            
            
            
            
           
        
            textBox2.Text = "";
            textBox1.Text = "";
            textBox1.Focus();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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
                string sqlProvjeri = "INSERT INTO racun (idracun,stol,idnacin_placanja,idkorisnik,broj_gostiju,iznos,datum_kreiranja) VALUES(null," + stol + "," + nacinPlacanja + ",1," + brojGostiju + "," + iznosRacuna + ",'" + datum + "');";
                baza.Instance.IzvrsiUpit(sqlProvjeri);
                //

                //kreiranje stavki zadnjeg kreiranog računa
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string nazivArtikla = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    int kolicinaArtikla = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());

                    string upit = "INSERT INTO stavke_racuna VALUES((SELECT MAX(idracun) FROM racun),(SELECT sifra_art FROM artikl WHERE naziv='" + nazivArtikla + "')," + kolicinaArtikla + ") ";

                    baza.Instance.IzvrsiUpit(upit);

                    string sqlUpdate = "UPDATE artikl SET zaliha=zaliha-" + kolicinaArtikla + " WHERE sifra_art=(SELECT sifra_art FROM artikl WHERE naziv='" + nazivArtikla + "');";
                    MessageBox.Show(sqlUpdate);
                    baza.Instance.IzvrsiUpit(sqlUpdate);


                }
                MessageBox.Show("Račun je kreiran!");

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
    }
}
