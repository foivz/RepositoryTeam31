﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bastion
{
    public class LOG
    {

        public LOG() { }
        public LOG(DbDataReader dr)
        {
            if (dr != null)
            {
                kime = dr["Username"].ToString();
                lozinka = dr["Password"].ToString();

            }
        }


        private string KIME;
        private string LOZINKA;


        public string kime
        {

            get
            {
                return KIME;
            }
            set
            {
                if (KIME != value)
                {
                    KIME = value;
                }
            }
        }

        public string lozinka
        {

            get
            {
                return LOZINKA;
            }
            set
            {
                if (LOZINKA != value)
                {
                    LOZINKA = value;
                }
            }
        }

        public static int id = 0;
        public static string Ime = "";
        public static string Prezime = "";
        public static string Username = "";

        /// <summary>
        /// Metoda za dohvacanje lozinke korisnika iz baze....vraca lozinku u obliku stringa
        /// </summary>
        /// <returns></returns>
        public string provjeri()
        {
            string sqlProvjeri = "";
            sqlProvjeri = "SELECT Password FROM korisnik WHERE Username = '" + kime + "';";
            Username = kime;
            dohvatiIme();
            return baza.Instance.DohvatiVrijednost(sqlProvjeri).ToString();
        }
        /// <summary>
        /// Metoda za brisanje korisnika iz baze....za sada se jos ne koristi
        /// </summary>
        /// <returns></returns>
        public int izbrisi()
        {
            string sqlProvjeri = "";
            sqlProvjeri = "DELETE FROM korisnik WHERE Username = '" + kime + "';";
            return baza.Instance.IzvrsiUpit(sqlProvjeri);
        }
        /// <summary>
        /// Metoda koja broji korisnike u bazi po odredenom username-u
        /// Sluzi umijesto try-catch...ako je rezultat ove metode 0 onda se prilikom prijave ne provjerava lozinka jer
        /// korisnik ne postoji (run time greska)
        /// ako metoda vrati 1 onda korisnik postoji i dalje se pokrece metoda provjeri() da se dohvati lozinka
        /// ne smije vratiti broj veci od 1 jer username mora biti jedinsven...u bazi nije definiran kao unique
        /// </summary>
        /// <returns></returns>
        public int provjera_username(string imeTablice, string kime, string upiti)
        {
            string sqlProvjeri = "";
            sqlProvjeri = "select count(*) from " + imeTablice + " where " +upiti + "= '" + kime + "';";
            return baza.Instance.DohvatiV(sqlProvjeri);
        }

        private void dohvatiIme() 
        {
            string sqlProvjeri = "select ime from korisnik where Username = '" + Username + "';";
            Ime = (baza.Instance.DohvatiVrijednost(sqlProvjeri)).ToString();
            sqlProvjeri = "select prezime from korisnik where Username = '"+Username+"';";
            Prezime = (baza.Instance.DohvatiVrijednost(sqlProvjeri)).ToString();
            sqlProvjeri = "select idkorisnik from korisnik where Username = '" + Username + "';";
            id = int.Parse((baza.Instance.DohvatiVrijednost(sqlProvjeri)).ToString());

        }
    }
}
