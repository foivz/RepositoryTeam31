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
        public int odabraniArtiklID = 0;
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
            kreirajDataGrid();
        }

        public void kreirajDataGrid()
        {
            List<dodavaj> artikli = dodavaj.select("artikl", 1);
            dataGridView1.DataSource = artikli;
            for (int i = 4; i < dataGridView1.ColumnCount; i++)
                this.dataGridView1.Columns[i].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uREDIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void urediArtiklToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urediArtkl uredi = new urediArtkl(odabraniArtiklID, this);
            uredi.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                odabraniArtiklID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
        }
    }
}
