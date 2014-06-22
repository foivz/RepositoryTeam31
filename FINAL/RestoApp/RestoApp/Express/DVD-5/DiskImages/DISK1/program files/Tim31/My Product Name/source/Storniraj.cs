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
    public partial class Storniraj : Form
    {
        int idOdabranogRacuna = 0;
        public Storniraj()
        {
            InitializeComponent();
            //popis svih važećih računa (status=1)
            string upit = "SELECT idracun,iznos FROM racun WHERE status=1 ORDER BY idracun DESC LIMIT 10";
            List<dodavaj> racuni = dodavaj.selectUrediPojedinogKorisnika("racun", 8, upit);
            foreach (dodavaj vazeci in racuni)
            {
                comboBox1.Items.Add(" Iznos: " + vazeci.Iznos + " ID: " + vazeci.Id);
            }
            
            
                
        }

        private void Storniraj_Load(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = comboBox1.SelectedItem.ToString();
            string[] b = a.Split(':');
            this.idOdabranogRacuna = int.Parse(b[2].ToString());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string upit = "UPDATE racun SET status=0 WHERE idracun=" + idOdabranogRacuna;
            baza.Instance.IzvrsiUpit(upit);
            MessageBox.Show("Uspješno storniran račun!");
        }
    }
}
