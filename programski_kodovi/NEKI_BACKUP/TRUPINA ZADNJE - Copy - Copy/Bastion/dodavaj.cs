using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bastion
{
    public class dodavaj
    {
        

        public dodavaj() { }
        
         public dodavaj(DbDataReader dr, int broj)
        {
            if (dr != null)
            {
                if (broj == 1)
                {
                    Sifra_art = int.Parse(dr["sifra_art"].ToString());
                   // Sifra_art = dr.GetInt32(0);
                    Tip_artikla = int.Parse(dr["tip_artikla"].ToString());
                   // Tip_artikla = dr.GetInt32(0);
                    Naziv = dr["naziv"].ToString();
                    Prodajna_cijena = float.Parse(dr["prodajna_cijena"].ToString());
                   // Prodajna_cijena = dr.GetFloat(0);
                    //TipArtikla = dr["Tip"].ToString();
                }
                if (broj == 2)
                {
                    Id = int.Parse(dr["idkorisnik"].ToString());
                   // Id = dr.GetInt32(0);
                    Idovlasti = int.Parse(dr["idovlasti"].ToString());
                   // Idovlasti = dr.GetInt32(0);
                    Ime = dr["ime"].ToString();
                    Prezime = dr["prezime"].ToString();
                    Broj_ziro = dr["broj_ziro"].ToString();
                    Telefon = dr["telefon"].ToString();
                    Adresa = dr["adresa"].ToString();
                    Grad = dr["grad"].ToString();
                    Username = dr["Username"].ToString();
                    Password = dr["Password"].ToString();
                }
                if (broj == 5)
                {
                    NazivA = dr["naziv"].ToString();
                    CijenaA = Single.Parse(dr["nabavna_cijena"].ToString());
                }
                if (broj == 6)
                {
                    Sifra_art = int.Parse(dr["sifra_art"].ToString());
                   // Sifra_art = dr.GetInt32(0);
                    
                    Naziv = dr["naziv"].ToString();
                    Prodajna_cijena = float.Parse(dr["prodajna_cijena"].ToString());
                   // Prodajna_cijena = dr.GetFloat(0);
                    TipArtikla = dr["Tip"].ToString();
                }
                if (broj == 7)
                {
                    Naziv = dr["naziv"].ToString();
                    Prodajna_cijena = float.Parse(dr["prodajna_cijena"].ToString());
                }
                if (broj == 8)
                {
                    Id = int.Parse(dr["idracun"].ToString());
                    Iznos = float.Parse(dr["iznos"].ToString());
                    
                }
                if (broj == 9)
                {
                    TipArtikla = dr["naziv"].ToString();
                    Id = int.Parse(dr["idtip"].ToString());
                }
                if (broj == 10)
                {
                    Id = int.Parse(dr["idnarudzbenica"].ToString());
                    Naziv = dr["datum_narudzbe"].ToString();

                }
                if (broj == 11)
                {
                    Sifra_art = int.Parse(dr["kolicina"].ToString());
                    TipArtikla = dr["naziv"].ToString();
                }
                if (broj == 12)
                {

                    Gosti = int.Parse(dr["gosti"].ToString());
                    Iznos = float.Parse(dr["Iznos"].ToString());

                }
            }
            
        }

        private string nazivA;
        private float cijenaA;

        private int sifra_art;
        private int tip_artikla;
        private string naziv;
        private float prodajna_cijena;

        private int id;
        private int idovlasti;
        private string ime;
        private string prezime;
        private string broj_ziro;
        private string telefon;
        private string adresa;
        private string grad;
        private string username;
        private string password;
        private float iznos;
        private string tipArtikla;

       

        public int Sifra_art
        {
            get
            {
                return sifra_art;
            }
            private set
            {
                if (sifra_art != value)
                {
                    sifra_art = value;
                }
            }
        }

        public int Tip_artikla
        {
            get
            {
                return tip_artikla;
            }
            private set
            {
                if (tip_artikla != value)
                {
                    tip_artikla = value;
                }
            }
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }
            set
            {
                if (naziv != value)
                {
                    naziv = value;
                }
            }
        }

        public float Prodajna_cijena
        {
            get
            {
                return prodajna_cijena;
            }
            set
            {
                if (prodajna_cijena != value)
                {
                    prodajna_cijena = value;
                }
            }
        }

        //
        public string TipArtikla
        {
            get
            {
                return tipArtikla;
            }
            private set
            {
                if (tipArtikla != value)
                {
                    tipArtikla = value;
                }
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            private set
            {
                if (id != value)
                {
                    id = value;
                }
            }
        }

        public float Iznos
        {
            get
            {
                return iznos;
            }
            private set
            {
                if (iznos != value)
                {
                    iznos = value;
                }
            }
        }

        public int Idovlasti
        {
            get
            {
                return idovlasti;
            }
            private set
            {
                if (idovlasti != value)
                {
                    idovlasti = value;
                }
            }
        }
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                if (ime != value)
                {
                    ime = value;
                }
            }
        }
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                if (prezime != value)
                {
                    prezime = value;
                }
            }
        }
        public string Broj_ziro
        {
            get
            {
                return broj_ziro;
            }
            set
            {
                if (broj_ziro != value)
                {
                    broj_ziro = value;
                }
            }
        }
        public string Telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                if (telefon != value)
                {
                    telefon = value;
                }
            }
        }
        public string Adresa
        {
            get
            {
                return adresa;
            }
            set
            {
                if (adresa != value)
                {
                    adresa = value;
                }
            }
        }
        public string Grad
        {
            get
            {
                return grad;
            }
            set
            {
                if (grad != value)
                {
                    grad = value;
                }
            }
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (username != value)
                {
                    username = value;
                }
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (password != value)
                {
                    password = value;
                }
            }
        }

        //dodavano
        public string NazivA
        {
            get
            {
                return nazivA;
            }
            private set
            {
                if (nazivA != value)
                {
                    nazivA = value;
                }
            }
        }
        public float CijenaA
        {
            get
            {
                return cijenaA;
            }
            private set
            {
                if (cijenaA != value)
                {
                    cijenaA = value;
                }
            }
        }
        
        public static List<dodavaj> select (string imeTablice, int broj)
        {
            List<dodavaj> lista = new List<dodavaj>();
            string sqlProvjeri = "";
            sqlProvjeri = "SELECT * FROM "+ imeTablice +";";
            //return baza.Instance.DohvatiVrijednost(sqlProvjeri).ToString();
            DbDataReader dr = baza.Instance.DohvatiDataReader(sqlProvjeri);
            while (dr.Read())
            {
                
                dodavaj artiklil = new dodavaj(dr,broj);
                lista.Add(artiklil);
            }
            dr.Close();
            return lista;
        }

        //dodao bozidar...ne brisi
        public static List<dodavaj> selectUrediPojedinogKorisnika(string imeTablice, int broj, string upit)
        {
            List<dodavaj> lista = new List<dodavaj>();
            string sqlProvjeri = "";
            sqlProvjeri = upit;
            //return baza.Instance.DohvatiVrijednost(sqlProvjeri).ToString();
            
            DbDataReader dr = baza.Instance.DohvatiDataReader(sqlProvjeri);
            while (dr.Read())
            {
                
                dodavaj artiklil = new dodavaj(dr, broj);
                lista.Add(artiklil);
                
                
            }
            dr.Close();
            return lista;
        }

        public int izbrisi(string ime, string imeTablice, string uvjet)
        {
            string sqlProvjeri = "";
            sqlProvjeri = "DELETE FROM " + imeTablice + " WHERE "+ uvjet + " = '" + ime + "';";
            return baza.Instance.IzvrsiUpit(sqlProvjeri);
        }

        public int dodajArtikl(int tip, string naziv, float cijena)
        {
            string sqlProvjeri = "";
            sqlProvjeri = "insert into artikl(sifra_art,tip_artikla, naziv, prodajna_cijena) values (null,'"+ tip + "','" + naziv + "'," + cijena + ")";
            return baza.Instance.IzvrsiUpit(sqlProvjeri);
        }

        public static List<dodavaj> dohvatiNarudzbe()
        {
            List<dodavaj> lista = new List<dodavaj>();
            string sqlProvjeri = "select naziv,nabavna_cijena from namirnice";
            DbDataReader dr = baza.Instance.DohvatiDataReader(sqlProvjeri);
            while (dr.Read())
            {
                dodavaj artiklil = new dodavaj(dr,5);
                lista.Add(artiklil);
            }
            dr.Close();
            return lista;
        }

        public int Max()
        {
            string sqlProvjeri = "select max(idnarudzbenica) from narudzbenica;";
            int a = baza.Instance.IzvrsiUpit(sqlProvjeri);
            return a;
        }
        public int sifra(string namirica) 
        {
            string sqlProvjeri = "select sifra_nam from namirnice where naziv = '" + namirica + "';";
            int sif = baza.Instance.IzvrsiUpit(sqlProvjeri);
            return sif;
        }

        public int dodajNamirnicu(string namirnica, int kolicina)
        {
            string datum = DateTime.Now.ToString("yyyy-MM-dd");
            string sqlProvjeri = "insert into narudzbenica values (null, '"+datum+"');";
            //return 
            baza.Instance.IzvrsiUpit(sqlProvjeri);
            //sqlProvjeri = "sqlite_last_inserted_rowid()";
            //sqlProvjeri = "select max(id) from narudzbenica; 
            int a = Max();
            int sira = sifra(namirnica);
            sqlProvjeri = "insert into narucena_kolicina values ("+a+","+sira+","+kolicina+");";
            return baza.Instance.IzvrsiUpit(sqlProvjeri);
        }

        public List<dodavaj> obracun_danas(int broj, string upit)
        {

            List<dodavaj> lista = new List<dodavaj>();
            string sqlProvjeri = upit;

            //return baza.Instance.DohvatiVrijednost(sqlProvjeri).ToString();
            DbDataReader dr = baza.Instance.DohvatiDataReader(sqlProvjeri);

            MessageBox.Show(sqlProvjeri);
            while (dr.Read())
            {

                dodavaj artiklil = new dodavaj(dr, broj);
                lista.Add(artiklil);
            }
            dr.Close();

            return lista;
        }

        public int Gosti { get; set; }
    }
}
