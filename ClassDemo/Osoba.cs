using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Osoba
    {
        string Ime;
        public string Prezime;
        public string BrojTelefona;
        public string Adresa;

        public Osoba()
        {
            Ime = "Ivor";
        }

        public Osoba(string ime,string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        public Osoba(string ime, string prezime,string teleBroj)
        {
            Ime = ime;
            Prezime = prezime;
            BrojTelefona = teleBroj;
        }

        public Osoba(string ime, string prezime, string teleBroj,string adresa)
        {
            Ime = ime;
            Prezime = prezime;
            BrojTelefona = teleBroj;
            Adresa = adresa;
        }

        public string GetIme()
        {
            return Ime;
        }


        public string GetFullInfo()
        {
            return $"{Ime} {Prezime} {BrojTelefona}";
        }

      
    }
}
