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
    public partial class Bastion : Form
    {
        string loza = "";
        string korime = "";
        private LOG log = null;
   
        public Bastion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Bastion_Load(object sender, EventArgs e)
        {
            
            this.AcceptButton = button1;

            if (String.Compare(textBox1.Text, "") == 0 || String.Compare(textBox2.Text, "") == 0)
            {
                button1.Enabled = false;
            }

            else
            {
                button1.Enabled = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.Compare(textBox1.Text,"")==0 || String.Compare(textBox2.Text,"")==0)
            {
                button1.Enabled = false; 
            }
            
            else
            {
                    button1.Enabled = true;
            }
            
            if (log == null)
            {
                log = new LOG();
            }

            log.kime = textBox1.Text;
            log.lozinka = textBox2.Text;
            bool pogodak=false;
            bool user = false; //user postoji u bazi
            //provjera usernamea i passworda u bazi
            int rez_user = 0; //ako user ne postoji u bazi ne trazi mu lozinku
            rez_user = log.provjera_username("korisnik",textBox1.Text, "Username");
            string dohvat = "";
            
            

            if (rez_user == 1) {
                user = true;
            }

            if (user == true)
            {
                dohvat = log.provjeri(); //dohvati mu lozinku
            }
            
            if (user == true)
            {
                if (String.Compare(loza, dohvat) == 0)
                {
                    pogodak=true; //je li unesena lozinka jednaka onoj iz baze
                }
            }

            ///poziv forme za administratora
           
               if (String.Compare(korime, "Admin") == 0 && pogodak && user)
               {
                   textBox2.Text = "";
                   textBox1.Text = "";
                   administrator adminko = new administrator();
                   adminko.RefToLogin = this;
                   this.Visible = false;
                   adminko.Show();
               }

            ///poziv forme za korisnika
               else if (String.Compare(korime, "Admin") != 0 && pogodak && user) 
               {
                   textBox2.Text = "";
                   textBox1.Text = "";
                   //korisnik koro = new korisnik();
                   //oro.RefToLogin = this;
                   this.Visible=false;
                   Konobar konobar = new Konobar();
                   konobar.Show();
                   //koro.Show();
               }



            //provjera za poruku o gresci
            if (!pogodak ||!user)
            {
                MessageBox.Show("Pogresno korisnicko ime ili lozinka", "Pogreska pri prijavi", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                textBox2.Text = "";
            }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                        if (String.Compare(textBox1.Text, "") == 0 || String.Compare(textBox2.Text, "") == 0)
            {
                button1.Enabled = false;
            }

            else
            {
                button1.Enabled = true;
            }
            if (textBox1.Text != "")
            {
                label1.Visible = false;
            }
            else{
                label1.Visible=true;
            }
            korime = textBox1.Text;
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             if (String.Compare(textBox1.Text, "") == 0 || String.Compare(textBox2.Text, "") == 0)
            {
                button1.Enabled = false;
            }

            else
            {
                button1.Enabled = true;
            }
            if (textBox2.Text != "")
            {
                label2.Visible = false;
            }
            else
            {
                label2.Visible = true;
            }
            loza = textBox2.Text;
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
