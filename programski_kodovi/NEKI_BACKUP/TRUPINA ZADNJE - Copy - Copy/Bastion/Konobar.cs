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
    public partial class Konobar : Form
    {
        public int stol = 0;
        public Konobar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stol = 1;
            Stol Stol1 = new Stol(stol);
            Stol1.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            stol = 2;
            Stol Stol2 = new Stol(stol);
            Stol2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stol = 3;
            Stol Stol3 = new Stol(stol);
            Stol3.Show();
        }

        private void Konobar_Load(object sender, EventArgs e)
        {

        }

        private void stornirajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Storniraj storno = new Storniraj();
            storno.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stol = 4;
            Stol Stol4 = new Stol(stol);
            Stol4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stol = 5;
            Stol Stol5 = new Stol(stol);
            Stol5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stol = 6;
            Stol Stol6 = new Stol(stol);
            Stol6.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
