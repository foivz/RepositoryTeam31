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
        public Form RefToLogin
        {
            get;
            set;
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
            //dodati upit...skiniti id, ime, prezime
            label2.Text = LOG.Ime;
            id.Text = LOG.id.ToString();
            prezime.Text = LOG.Prezime.ToString();
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

        private void pomoćF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.Show();
        }

        private void Konobar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            //if (e.KeyCode.Equals("F1"))
            {
                Pomoc pomoc = new Pomoc();
                pomoc.Show();
            }
            else
                MessageBox.Show("nije kljuc!");
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToLogin.Show();
        }

        private void Konobar_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Konobar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            //if (e.KeyCode.Equals("F1"))
            {
                Pomoc pomoc = new Pomoc();
                pomoc.Show();
            }
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            //if (e.KeyCode.Equals("F1"))
            {
                Pomoc pomoc = new Pomoc();
                pomoc.Show();
            }
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            //if (e.KeyCode.Equals("F1"))
            {
                Pomoc pomoc = new Pomoc();
                pomoc.Show();
            }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            //if (e.KeyCode.Equals("F1"))
            {
                Pomoc pomoc = new Pomoc();
                pomoc.Show();
            }
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            //if (e.KeyCode.Equals("F1"))
            {
                Pomoc pomoc = new Pomoc();
                pomoc.Show();
            }
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            //if (e.KeyCode.Equals("F1"))
            {
                Pomoc pomoc = new Pomoc();
                pomoc.Show();
            }
        }
    }
}
