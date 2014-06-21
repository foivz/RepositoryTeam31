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
    public partial class obracun : Form
    {
        public obracun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime a = DateTime.Now;
            //string b = a.Year+"-"+a.Month+"-"+a.Day;
            //string upit = "Select sum(broj_gostiju) AS gosti,sum(iznos) as Iznos from racun where datum_kreiranja="+"'"+b+"'";
            string upit = "Select sum(broj_gostiju) AS gosti,sum(iznos) as Iznos from racun where datum_kreiranja='2014-04-19'";
            dodavaj d = new dodavaj();
            List<dodavaj> obracun_dana = d.obracun_danas(3, upit);

            TextBox t1 = new TextBox();
            TextBox t2 = new TextBox();
            Label l1 = new Label();
            Label l2 = new Label();
            //int LOKX = int.Parse((this.Width * 0.4).ToString());
            //int LOKY = int.Parse((this.Height * 0.1).ToString());
            t1.Location = new Point(this.button1.Location.X, this.button1.Location.Y + 100);
            t2.Location = new Point(this.button1.Location.X, this.button1.Location.Y + 200);
            l1.Location = new Point(this.button1.Location.X, this.button1.Location.Y + 50);
            l2.Location = new Point(this.button1.Location.X, this.button1.Location.Y + 150);
            l2.Text = "Ukupan promet:";
            l1.Text = "Ukupan broj gostiju: ";

            foreach (dodavaj ime in obracun_dana)
            {
                t1.Text = ime.Gosti.ToString();
                t2.Text = ime.Iznos.ToString();
            }

            this.Controls.Add(l1);
            this.Controls.Add(l2);
            this.Controls.Add(t1);
            this.Controls.Add(t2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string prviDatum = this.dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string drugiDatum = this.dateTimePicker2.Value.ToString("yyyy-MM-dd");
            //string datum1 = prviDatum.Year + "-" + prviDatum.Month.ToString("mm") + "-" + prviDatum.Day.ToString("dd");
            //string datum2 = drugiDatum.Year + "-" + drugiDatum.Month + "-" + drugiDatum.Day;

            string upit = "Select sum(broj_gostiju) AS gosti,sum(iznos) as Iznos from racun where datum_kreiranja between '"+prviDatum+"' AND '"+drugiDatum+"' ";

            dodavaj d = new dodavaj();
            List<dodavaj> obracun_dana = d.obracun_danas(3, upit);

            TextBox t3 = new TextBox();
            TextBox t4 = new TextBox();
            Label l3 = new Label();
            Label l4 = new Label();

            t3.Location = new Point(this.button2.Location.X, this.button2.Location.Y + 50);
            t4.Location = new Point(this.button2.Location.X, this.button2.Location.Y + 130);
            l3.Location = new Point(this.button2.Location.X, this.button2.Location.Y + 20);
            l4.Location = new Point(this.button2.Location.X, this.button2.Location.Y + 100);
            l4.Text = "Ukupan promet:";
            l3.Text = "Ukupan broj gostiju: ";

            foreach (dodavaj ime in obracun_dana)
            {
                t3.Text = ime.Gosti.ToString();
                t4.Text = ime.Iznos.ToString();
            }

            this.Controls.Add(l3);
            this.Controls.Add(l4);
            this.Controls.Add(t3);
            this.Controls.Add(t4);

        }

        private void obracun_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string treciDatum = this.dateTimePicker3.Value.ToString("yyyy-MM-dd");

            string upit = "Select sum(broj_gostiju) AS gosti,sum(iznos) as Iznos from racun where datum_kreiranja='" + treciDatum + "'";
            dodavaj d = new dodavaj();
            List<dodavaj> obracun_dana = d.obracun_danas(3, upit);

            TextBox t5 = new TextBox();
            TextBox t6 = new TextBox();
            Label l5 = new Label();
            Label l6 = new Label();
            t5.Location = new Point(this.button3.Location.X, this.button3.Location.Y + 100);
            l5.Location = new Point(this.button3.Location.X, this.button3.Location.Y + 50);
            t6.Location = new Point(this.button3.Location.X, this.button3.Location.Y + 180);
            l6.Location = new Point(this.button3.Location.X, this.button3.Location.Y + 200);

            l5.Text = "Ukupan promet:";
            l6.Text = "Ukupan broj gostiju: ";

            foreach (dodavaj ime in obracun_dana)
            {
                t5.Text = ime.Gosti.ToString();
                t6.Text = ime.Iznos.ToString();
            }

            this.Controls.Add(l5);
            this.Controls.Add(l6);
            this.Controls.Add(t5);
            this.Controls.Add(t6);
        }
    }
}
