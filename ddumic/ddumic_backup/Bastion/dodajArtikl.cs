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
    public partial class dodajArtikl : Form
    {
        private dodavaj unesi = null;
        public dodajArtikl()
        {
            InitializeComponent();
            comboBox1.Items.Insert(0, "--Odaberite kategoriju--");
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOG log = null;
            if (unesi == null)
            {
                unesi = new dodavaj();
            }
            if (log == null)
            {
                log = new LOG();
            }
            //naziv artikla
            int kategorija = comboBox1.SelectedIndex;
            if (kategorija == 0)
            {
                //nije nista odabrano
                MessageBox.Show("Morate odabrati tip artikla!", "Pogreska",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            else
            {
                //odabrano je nesto!
                float cijena = 0;
                float.TryParse(textBox5.Text, out cijena);
                if (cijena != 0)
                {
                    if (log.provjera_username("artikl", textBox3.Text, "naziv") == 1)
                    {
                        MessageBox.Show("Artikl vec postoji!", "Pogreska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textBox3.Text != "") {
                        //unesena je prava cijena
                        //unesen je naziv
                        string naziv = textBox3.Text;
                        
                        unesi.dodajArtikl(kategorija,naziv,cijena);
                        MessageBox.Show("Artikl je dodan!","Dodano",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Morate unijeti naziv artikla!", "Pogreska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Cijena nije unesena u odgovarajucem formatu (xx,yy)!", "Pogreska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajArtikl_Load(object sender, EventArgs e)
        {

        }
    }
}
