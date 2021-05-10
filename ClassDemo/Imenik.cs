using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Imenik
    {
        Osoba[] kontakti;

        public Imenik(int velicinaImenika)
        {
            kontakti = new Osoba[velicinaImenika];
        }

        public bool DodajOsobu(Osoba novaOsoba)
        {
            for (int i = 0; i < kontakti.Length; i++)
            {
                if (kontakti[i]==null)
                {
                    kontakti[i] = novaOsoba;
                    return true;
                }

            }
            return false;
        }

        public void IzlistajKontakte()
        {
            for (int i = 0; i < kontakti.Length; i++)
            {
                if (kontakti[i]!=null)
                {
                    Console.WriteLine(kontakti[i].GetFullInfo());
                }
                
            }
        }
    }
}
