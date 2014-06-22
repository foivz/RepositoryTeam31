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
    public partial class popisNarudzbi : Form
    {
        public popisNarudzbi()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void popisNarudzbi_Load(object sender, EventArgs e)
        {

            string upit = "select* from narudzbenica";
            List<dodavaj> narudzbe = dodavaj.selectUrediPojedinogKorisnika("narudzbenica",10,upit);

            foreach(dodavaj narudzba in narudzbe)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = int.Parse(narudzba.Id.ToString());
                row.Cells[1].Value = narudzba.Naziv;
                dataGridView1.Rows.Add(row);
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            this.dataGridView2.Rows.Clear();

            int idNarudzbenice = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            string upit2 = "select nk.kolicina as kolicina,a.naziv as naziv from  narucena_kolicina nk left join artikl a on(nk.[id_artikla]=a.[sifra_art]) where nk.sifra_narudzbenice=" + idNarudzbenice;

            List<dodavaj> stavkeNarudzbe = dodavaj.selectUrediPojedinogKorisnika("narucena_kolicina", 11, upit2);
            
          
            foreach(dodavaj stavka in stavkeNarudzbe)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                row.Cells[0].Value = int.Parse(stavka.Sifra_art.ToString());
                row.Cells[1].Value = stavka.TipArtikla;
                dataGridView2.Rows.Add(row);
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
