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
    public partial class urediArtkl : Form
    {

        string upit = "";
        int odabraniArtiklID = 0;
       
        Form formaPopis;

        public urediArtkl()
        {
            InitializeComponent();
        }

        public urediArtkl(int idArtikla, Form otvorenaForma)
        {
            InitializeComponent();
            this.odabraniArtiklID = idArtikla;
            this.formaPopis = otvorenaForma;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void urediArtkl_Load(object sender, EventArgs e)
        {

          //  MessageBox.Show(odabraniArtiklID.ToString()); 



            upit = "select idtip, naziv from tip_artikla";
            List<dodavaj> artikl2 = dodavaj.selectUrediPojedinogKorisnika("tip_artikla", 9, upit);


            foreach (dodavaj item in artikl2)
            {
                listBox1.Items.Add(item.TipArtikla);

            }

            upit = "Select a.sifra_art as sifra_art,a.naziv as naziv, a.prodajna_cijena as prodajna_cijena,t.naziv as Tip from artikl a LEFT JOIN tip_artikla t ON a.tip_artikla=t.idtip where a.sifra_art = " + odabraniArtiklID;



            List<dodavaj> artikl = dodavaj.selectUrediPojedinogKorisnika("artikl", 6, upit);

            foreach (dodavaj redak in artikl)
            {

                textBox1.Text = redak.Naziv;
                textBox2.Text = redak.Prodajna_cijena.ToString();
                textBox3.Text = redak.TipArtikla.ToString();
            }

            listBox1.SelectedItem = textBox3.Text;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //SIFRA_ARTIKLA -->odabraniArtiklID
            //SIFRA_TIPA_ARTIKLA --> (listBox1.SelectedIndex+1)
            int tip_artikla = listBox1.SelectedIndex + 1; //odabrani art dohvacam preko indexa odabranog item-a u list-boxu
            string naziv = textBox1.Text;
            float prodajna_cijena = float.Parse(textBox2.Text);
            //MessageBox.Show(tip_artikla.ToString());

            string upitUpdate = "update artikl set tip_artikla = " + tip_artikla + ",naziv = '" + naziv + "',prodajna_cijena = " + prodajna_cijena + " where sifra_art = " + odabraniArtiklID + ";";
            baza.Instance.IzvrsiUpit(upitUpdate);

            //radi update-a data grid-view-a zatvaram postojeci i radim novi upit
            formaPopis.Close();
            popisArtikala popis = new popisArtikala();
            popis.kreirajDataGrid();
            popis.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = listBox1.Text;
        }
    }
}
