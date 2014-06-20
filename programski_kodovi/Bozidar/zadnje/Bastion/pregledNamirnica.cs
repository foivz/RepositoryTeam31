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
    public partial class pregledNamirnica : Form
    {
        public pregledNamirnica()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pregledNamirnica_Load(object sender, EventArgs e)
        {
            List<dodavaj> namirnice = dodavaj.select("namirnice",4);
            dataGridView1.DataSource = namirnice;
            for (int i = 4; i <=17; i++)
                this.dataGridView1.Columns[i].Visible = false;
        }
        
    }
}
