using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Sifra_art = dr.GetInt32(0);
                    Tip_artikla = int.Parse(dr["tip_artikla"].ToString());
                    Tip_artikla = dr.GetInt32(0);
                    Naziv = dr["naziv"].ToString();
                    Prodajna_cijena = float.Parse(dr["prodajna_cijena"].ToString());
                    Prodajna_cijena = dr.GetFloat(0);
                }
                if (broj == 2)
                {
                    Id = int.Parse(dr["idkorisnik"].ToString());
                    Id = dr.GetInt32(0);
                    Idovlasti = int.Parse(dr["idovlasti"].ToString());
                    Idovlasti = dr.GetInt32(0);
                    Ime = dr["ime"].ToString();
                    Prezime = dr["prezime"].ToString();
                    Broj_ziro = dr["broj_ziro"].ToString();
                    Telefon = dr["telefon"].ToString();
                    Adresa = dr["adresa"].ToString();
                    Grad = dr["grad"].ToString();
                    Username = dr["Username"].ToString();
                    Password = dr["Password"].ToString();
                }
                if (broj == 4)
                {
                    Naziv_namirnice = dr["naziv"].ToString();
                    Kolicina_namirnice = int.Parse(dr["kolicina"].ToString());
                    Nabavna_cijena_namirnice = float.Parse(dr["nabavna_cijena"].ToString());
                    Jedinicna_mjera_namirnice = dr["jed_mjera"].ToString();
                }
            }
            
        }

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

        //DODAO BOZIDAR
        private string nazivNam;
        private int kolicinaNam;
        private float nabavna_cijenaNam;
        private string jedinicna_mjeraNam;

        public string Naziv_namirnice
        {
            get
            {
                return nazivNam;
            }
            private set
            {
                if (nazivNam != value)
                {
                    nazivNam = value;
                }
            }
        }

        public int Kolicina_namirnice
        {
            get
            {
                return kolicinaNam;
            }
            private set
            {
                if (kolicinaNam != value)
                {
                    kolicinaNam = value;
                }
            }
        }

        public float Nabavna_cijena_namirnice
        {
            get
            {
                return nabavna_cijenaNam;
            }
            private set
            {
                if (nabavna_cijenaNam != value)
                {
                    nabavna_cijenaNam = value;
                }
            }
        }

        public string Jedinicna_mjera_namirnice
        {
            get
            {
                return jedinicna_mjeraNam;
            }
            private set
            {
                if (jedinicna_mjeraNam != value)
                {
                    jedinicna_mjeraNam = value;
                }
            }
        }





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
            sqlProvjeri = "DELETE FROM " + imeTablice + "WHERE "+ uvjet + " = '" + ime + "';";
            return baza.Instance.IzvrsiUpit(sqlProvjeri);
        }

        public int dodajArtikl(int tip, string naziv, float cijena)
        {
            string sqlProvjeri = "";
            sqlProvjeri = "insert into artikl(sifra_art,tip_artikla, naziv, prodajna_cijena) values (null,'"+ tip + "','" + naziv + "'," + cijena + ")";
            return baza.Instance.IzvrsiUpit(sqlProvjeri);
        }
    }
}
