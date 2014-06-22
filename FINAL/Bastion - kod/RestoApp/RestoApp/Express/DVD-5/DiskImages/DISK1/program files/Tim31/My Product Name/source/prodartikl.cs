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
    public partial class prodartikl : Form
    {
        public string treciDatum = "";
        public string cetvrtiDatum = "";
        bool odredi = false;
        public prodartikl()
        {
            InitializeComponent();
            this.dataGridView1.Hide();
            this.chart1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            treciDatum = this.dateTimePicker1.Value.ToString("yyyy-MM-dd");
            cetvrtiDatum = this.dateTimePicker2.Value.ToString("yyyy-MM-dd");
            int limit  = int.Parse(this.numericUpDown1.Value.ToString());
            string upit = "Select a.naziv as Naziv, sum(sr.kolicina) as Kolicina From artikl a Left join stavke_racuna sr ON a.sifra_art=sr.idartika LEFT JOIN racun r ON sr.idracun=r.idracun where sr.idartika=(Select DISTINCT(sr.idartika) from stavke_racuna) AND (datum_kreiranja between '" + treciDatum + "' AND '" + cetvrtiDatum + "' ) and r.status = 1 Group by Naziv Order By Naziv DESC Limit "+limit+"";

            dodavaj d = new dodavaj();
            List<dodavaj> obracun_dana = d.obracun_danas(15, upit);
            this.chart1.Series["Kolicina"].Points.Clear();
            foreach (dodavaj ime in obracun_dana)
            {
                this.chart1.Series["Kolicina"].Points.AddXY(ime.Narnaziv.ToString(),int.Parse(ime.Narkol.ToString()));
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = ime.Narnaziv.ToString();
                row.Cells[1].Value = ime.Narkol.ToString();
                
                dataGridView1.Rows.Add(row);
            }
           
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (odredi == false)
            {
                this.chart1.Show();
                this.dataGridView1.Hide();
                
            }
            if (odredi == true)
            {
                this.chart1.Hide();
                this.dataGridView1.Show();
               
            }
            if (odredi == false)
            {
                odredi = true;
            }
            else
            {
                odredi = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
           
            int fileCount = Directory.GetFiles(@"Potvrde").Length;
            int fileCount2 = fileCount+1;
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(@"Potvrde\Potvrde" + fileCount2.ToString() + ".pdf", FileMode.Create));

            doc.Open();//Open Document to write

            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.FontFactory.GetFont("HELVETICA", 14.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK));

            iTextSharp.text.Font tableFont = new iTextSharp.text.Font(iTextSharp.text.FontFactory.GetFont("HELVETICA", 12.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK));

            iTextSharp.text.Font headerfont = new iTextSharp.text.Font(iTextSharp.text.FontFactory.GetFont("HELVETICA", 12.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK));


            
            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
            table.TotalWidth = dataGridView1.Width;
            
            
            PdfPCell cell = null;
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                cell = new PdfPCell(new Phrase(new Chunk(c.HeaderText, headerfont)));
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                table.AddCell(cell);
            }

            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count  -1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        cell = new PdfPCell(new Phrase(dataGridView1.Rows[i].Cells[j].Value.ToString(), tableFont));
                        cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                        cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }
            }

            var chartimage = new MemoryStream();
            chart1.SaveImage(chartimage, ChartImageFormat.Png);
            iTextSharp.text.Image Chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
            //centriraj
            Paragraph p = new Paragraph("Statistika najkoristenijih artikala od " + treciDatum + " do " + cetvrtiDatum + "\n\n",headerfont);
            doc.Add(p);
            Paragraph pa = new Paragraph("Tablica\n\n",titleFont);
            doc.Add(pa);
            //doc.Add(paragraph);
            doc.Add(table);
            Paragraph par = new Paragraph("Statistika\n\n",titleFont);
            doc.Add(par);
            doc.Add(Chart_image);
            Paragraph para = new Paragraph("\n\n" + DateTime.Now);
            doc.Add(para);
            doc.Close(); //Close document
            //
            MessageBox.Show("PDF je kreiran!");
            try
            {
                System.Diagnostics.Process.Start(@"Potvrde\Potvrde" + fileCount.ToString() + ".pdf");
            }
            catch
            {
 
            }
            
        
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void prodartikl_Load(object sender, EventArgs e)
        {

        }
    }
}
