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
        public Konobar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stol Stol1 = new Stol();
            Stol1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stol Stol2 = new Stol();
            Stol2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stol Stol3 = new Stol();
            Stol3.Show();
        }

        private void Konobar_Load(object sender, EventArgs e)
        {

        }
    }
}
