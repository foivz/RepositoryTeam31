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
    public partial class briasnjeArtikl : Form
    {
        public briasnjeArtikl()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void briasnjeArtikl_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string naziv = textBox1.Text;
            dodavaj d = new dodavaj();
            try
            {
                d.izbrisi(naziv, "artikl", "naziv");
                textBox1.Text = "";
                MessageBox.Show("Artikl uspjesno izbrisan!");
            }
            catch 
            {
                MessageBox.Show("Navedeni artikl ne postoji!");
            }
        }
    }
}
