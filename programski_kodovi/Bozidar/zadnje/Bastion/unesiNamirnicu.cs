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
    public partial class unesiNamirnicu : Form
    {
        public unesiNamirnicu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string naziv = this.textBoxNaziv.Text;
            int kolicina = int.Parse(this.textBoxKolicina.Text);
            float cijena = float.Parse(this.textBoxCijena.Text);
            string mjera = this.textBoxMjera.Text;


            //pregled dali namirnica postoji
            LOG instancaLOG = new LOG();



            if (instancaLOG.provjera_username("namirnice", naziv, "naziv") == 0)
            {
                string upit = "insert into namirnice(sifra_nam,naziv,kolicina,nabavna_cijena,jed_mjera) values(null,'" + naziv + "','" + kolicina + "','" + cijena + "','" + mjera + "');";
                baza.Instance.IzvrsiUpit(upit);
            }
            else 
            {
                this.textBoxNaziv.Text = "";
                this.textBoxKolicina.Text = "";
                this.textBoxMjera.Text = "";
                this.textBoxCijena.Text = "";
                MessageBox.Show(naziv + " vec postoji u bazi!");
            }

            

            
            
        }
    }
}
