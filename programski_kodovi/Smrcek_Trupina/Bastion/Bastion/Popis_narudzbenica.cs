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
    public partial class Popis_narudzbenica : Form
    {
        public Popis_narudzbenica()
        {
            InitializeComponent();
        }

        private void Popis_narudzbenica_Load(object sender, EventArgs e)
        {
            dodavaj d = new dodavaj();
            string upit = "Select n.idnarudzbenica AS IDnarudzbenice,n.datum_narudzbe AS Datum,nam.naziv as Naziv,nk.kolicina as Kolicina,nam.nabavna_cijena AS Nabavna_cijena from narudzbenica n LEFT JOIN narucena_kolicina nk on n.idnarudzbenica=nk.sifra_narudzbenice LEFT JOIN namirnice nam ON nk.sifra_namirnice=nam.sifra_nam";

            List<dodavaj> obracun_dana = d.obracun_danas(4, upit);

            dataGridView1.DataSource = obracun_dana;
            for (int i = 5; i < dataGridView1.ColumnCount; i++)
            {
                this.dataGridView1.Columns[i].Visible = false;
            }

        }
    }
}
