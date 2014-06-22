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
    public partial class kreirajNarudzbu : Form
    {
        public kreirajNarudzbu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kreirajNarudzbu_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
            string upit = "SELECT *FROM artikl";
            List<dodavaj> artikli = dodavaj.selectUrediPojedinogKorisnika("artikl",1,upit);
            foreach(dodavaj artikl in artikli)
            {
                comboBox1.Items.Add(artikl.Naziv);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
            string artiklNaziv = comboBox1.SelectedItem.ToString();
            string upit = "SELECT *FROM artikl WHERE naziv='"+artiklNaziv+"'; ";
            //MessageBox.Show(upit);
            
            List<dodavaj> idArtikl = dodavaj.selectUrediPojedinogKorisnika("artikl",1,upit);
            foreach(dodavaj artikl in idArtikl)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = int.Parse(artikl.Sifra_art.ToString());
                row.Cells[1].Value = artikl.Naziv;
                row.Cells[2].Value = artikl.Prodajna_cijena;
                row.Cells[3].Value = int.Parse(textBox1.Text.ToString());
                dataGridView1.Rows.Add(row);
            }
            button2.Enabled = true;

            }else
             {
                 MessageBox.Show("Niste unjeli količinu artikla");
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
                string datum = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                string upit = "INSERT INTO narudzbenica VALUES(null,'" + datum + "')";
                baza.Instance.IzvrsiUpit(upit);

                //kreiranje stavki zadnjeg kreiranog računa
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    int idArtikla = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    int kolicinaArtikla = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());

                    string sqlProvjeri = "INSERT INTO narucena_kolicina VALUES((SELECT MAX(idnarudzbenica) FROM narudzbenica),(SELECT sifra_art FROM artikl WHERE sifra_art=" + idArtikla + ")," + kolicinaArtikla + ") ";

                    baza.Instance.IzvrsiUpit(sqlProvjeri);

                    string sqlUpdate = "UPDATE artikl SET zaliha=zaliha+" + kolicinaArtikla + " WHERE sifra_art=" + idArtikla + "";
                    baza.Instance.IzvrsiUpit(sqlUpdate);
                }
                MessageBox.Show("Narudžbenica je kreirana!");


                dataGridView1.Rows.Clear();

           
           


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
