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
    public partial class Stol : Form
    {
        public Stol()
        {
            InitializeComponent();
        }

        private void Stol_Load(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }
    }
}
