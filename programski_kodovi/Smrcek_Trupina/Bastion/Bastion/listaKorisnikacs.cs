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
            dataGridView1.DataSource = artikli;
        }
    }
}
