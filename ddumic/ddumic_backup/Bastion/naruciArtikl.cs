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
    public partial class naruciArtikl : Form
    {
        public naruciArtikl()
        {
            InitializeComponent();
        }

        private void naruciArtikl_Load(object sender, EventArgs e)
        {
            dodavaj dodaj = new dodavaj();
            List<dodavaj> lista = dodavaj.dohvatiNarudzbe();
            foreach (var s in lista)
            {
                comboBox1.Items.Add(s.NazivA);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dodavaj dodaj = new dodavaj();
            List<dodavaj> lista = dodavaj.dohvatiNarudzbe();
            foreach (var s in lista)
            {
                //comboBox1.Items.Add(s.NazivA);
                if (String.Compare(comboBox1.Text, s.NazivA) == 0)
                    textBox2.Text = s.CijenaA.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox2.Text) * numericUpDown1.Value).ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox2.Text) * numericUpDown1.Value).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namirnica = comboBox1.Text;
            int kolicina = (int)numericUpDown1.Value;
            if (namirnica != "")
            {
                if (kolicina != 0)
                {
                    dodavaj a = new dodavaj();
                    a.dodajNamirnicu(namirnica, kolicina);
                    MessageBox.Show("Uspjesno dodana narudzbenica!");
                    comboBox1.SelectedIndex = 0;
                    textBox2.Text = "";
                    numericUpDown1.Value = 0;
                    textBox1.Text = "";
                }
                else
                    MessageBox.Show("Kolicina mora biti veca od 0!");
            }
            else
                MessageBox.Show("Morate odabrati namirnicu!");

        }
    }
}
