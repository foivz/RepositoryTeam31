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
    public partial class listaKorisnikacs : Form
    {
        public listaKorisnikacs()
        {
            InitializeComponent();
        }

        private void listaKorisnikacs_Load(object sender, EventArgs e)
        {
            List<dodavaj> artikli = dodavaj.select("korisnik",2);
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
