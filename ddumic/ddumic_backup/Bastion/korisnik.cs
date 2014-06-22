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
    public partial class korisnik : Form
    {
        public korisnik()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Form RefToLogin
        {
            get;
            set;
        }

        private void korisnik_Load(object sender, EventArgs e)
        {

        }
    }
}
