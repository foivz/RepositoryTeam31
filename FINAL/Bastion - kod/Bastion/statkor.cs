using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bastion
{
    public partial class statkor : Form
    {
        public statkor()
        {
            InitializeComponent();
        }

        private void statkor_Load(object sender, EventArgs e)
        {
            
            button1.Enabled = false;

            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            label4.Hide();
            textBox4.Hide();

            string upit = "Select k.Username as Naziv, count(r.idracun) as Kolicina from racun r LEFT JOIN korisnik k ON r.idkorisnik = k.idkorisnik where r.status = 1 GROUP BY Naziv ORDER BY Kolicina DESC";

            dodavaj d = new dodavaj();
            List<dodavaj> obracun_dana = d.obracun_danas(15, upit);

            this.chart2.Series["Broj računa"].Points.Clear();
            foreach (dodavaj ime in obracun_dana)
            {
                this.chart2.Series["Broj računa"].Points.AddXY(ime.Narnaziv.ToString(), int.Parse(ime.Narkol.ToString()));
                this.comboBox1.Items.Add(ime.Narnaziv.ToString());
            } //foreach

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string blj = this.comboBox1.SelectedItem.ToString();
            string upit2 = "Select Count(r.idracun) as Broj,sum(r.broj_gostiju) as Gosti,(Select datum_kreiranja from racun where racun.idkorisnik=(Select idkorisnik from korisnik where Username='"+blj+"') and r.status = 1 ORDER BY datum_kreiranja DESC LIMIT 1 ) AS Datum FROM racun r LEFT JOIN korisnik k ON r.idkorisnik=k.idkorisnik WHERE k.idkorisnik=(Select idkorisnik from korisnik where Username='"+blj+"')";
            List<dodavaj> obracun_dana2 = null;
            dodavaj d2 = new dodavaj();
            try
            {
                obracun_dana2 = d2.obracun_danas(99, upit2);
            }
            catch
            {
                MessageBox.Show("Baza je vratila prazan odgovor", "Pogreska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (this.comboBox1.SelectedIndex >= 0)
            {
               button1.Enabled = true;
               textBox1.Text= obracun_dana2[0].Narkol.ToString();
               textBox2.Text = obracun_dana2[0].Narnabavna.ToString();
               textBox3.Text = obracun_dana2[0].Narnaziv.ToString();

                label1.Show();
                label2.Show();
                label3.Show();
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                label4.Show();
                textBox4.Show();
                string upit3 = "Select a.naziv as Naziv,a.prodajna_cijena as Cijena,sum(sr.kolicina) AS Kolicina FROM artikl a LEFT JOIN stavke_racuna sr ON a.sifra_art=sr.idartika LEFT JOIN racun r ON sr.idracun=r.idracun where r.idkorisnik=(Select idkorisnik from korisnik where Username='" + blj + "') and r.status=1 GROUP BY Naziv";
                dodavaj d3= new dodavaj();
                List<dodavaj> obracun_dana3 = d3.obracun_danas(77, upit3);
                float suma = 0;
                foreach (dodavaj ime in obracun_dana3)
                {
                    suma += (ime.Prodajna_cijena * ime.Narkol);
                }

                textBox4.Text = suma.ToString();
            }
            else
            {
                label1.Hide();
                label2.Hide();
                label3.Hide();
                textBox1.Hide();
                textBox2.Hide();
                textBox3.Hide();
                label4.Hide();
                textBox4.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);

            int fileCount = Directory.GetFiles(@"Potvrde\").Length;
            int fileCount2 = fileCount + 1;
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(@"Potvrde\Promet po korisniku" + fileCount2.ToString() + ".pdf", FileMode.Create));

            doc.Open();//Open Document to write

            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.FontFactory.GetFont("HELVETICA", 14.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK));

            iTextSharp.text.Font tableFont = new iTextSharp.text.Font(iTextSharp.text.FontFactory.GetFont("HELVETICA", 12.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK));

            iTextSharp.text.Font headerfont = new iTextSharp.text.Font(iTextSharp.text.FontFactory.GetFont("HELVETICA", 12.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK));

            Paragraph p = new Paragraph("Statistika konobara\n\n", headerfont);
            doc.Add(p);

            Paragraph pa = new Paragraph("Graf\n\n", titleFont);
            doc.Add(pa);

            var chartimage = new MemoryStream();
            chart2.SaveImage(chartimage, ChartImageFormat.Png);
            iTextSharp.text.Image Chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
            doc.Add(Chart_image);

            Paragraph par = new Paragraph("Statistika odabranog konobara\n\n", titleFont);
            doc.Add(par);
            //dodavaj podatke
            Paragraph prvi = new Paragraph("Konobar "+comboBox1.SelectedItem.ToString());
            doc.Add(prvi);

            Paragraph drugi = new Paragraph(label1.Text+textBox1.Text);
            doc.Add(drugi);
            Paragraph treci = new Paragraph(label2.Text+textBox2.Text);
            doc.Add(treci);
            Paragraph cetvrti = new Paragraph(label3.Text+textBox3.Text);
            doc.Add(cetvrti);
            Paragraph peti = new Paragraph(label4.Text+textBox4.Text);
            doc.Add(peti);
            Paragraph para = new Paragraph("\n\n" + DateTime.Now);
            doc.Add(para);

            doc.Close(); //Close document
            //
            MessageBox.Show("PDF je kreiran!");
            try
            {
                System.Diagnostics.Process.Start(@"Potvrde\Promet po korisniku" + fileCount.ToString() + ".pdf");
            }
            catch
            {

            }

           
        }

      

      
    }
}
