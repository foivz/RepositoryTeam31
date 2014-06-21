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
    public partial class popisArtikala : Form
    {
        private dodavaj unesi = null;
        public popisArtikala()
        {
            InitializeComponent();
        }

        private void popisArtikala_Load(object sender, EventArgs e)
        {
            if (unesi == null)
            {
                unesi = new dodavaj();
            }
            List<dodavaj> artikli = dodavaj.select("artikl",1);
            dataGridView1.DataSource = artikli;
        }
    }
}
