using System;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Osoba novaOsoba = new Osoba();
            //novaOsoba.Ime = "Ante";
            //novaOsoba.Prezime = "Antić";
            //novaOsoba.BrojTelefona = "012345666";
            //novaOsoba.Adresa = "Ul Hrv. proljeca 28";

            //Console.WriteLine(novaOsoba.Ime);
            //Console.WriteLine(novaOsoba.Prezime);
            //Console.WriteLine(novaOsoba.BrojTelefona);
            //Console.WriteLine(novaOsoba.Adresa);
            Imenik imenik = new Imenik(5);
            Osoba novaOsoba2 = new Osoba("Pero", "Peric","012222");
            Osoba novaOsoba3 = new Osoba("Ana", "Anic", "01222233");
            imenik.DodajOsobu(novaOsoba2);
            imenik.DodajOsobu(novaOsoba3);
            imenik.IzlistajKontakte();
            //Console.WriteLine(novaOsoba2.GetIme());
            //Console.WriteLine(novaOsoba2.Prezime);
            //novaOsoba2.Ime = "Ivor";
            //Console.WriteLine(novaOsoba2.GetIme());
            //Console.WriteLine(novaOsoba2.GetFullInfo());

        }
    }
}
