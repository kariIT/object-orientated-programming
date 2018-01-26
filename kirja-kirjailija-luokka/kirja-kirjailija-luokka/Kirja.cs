using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirja_kirjailija_luokka
{
    class Kirja
    {
        string Nimi;
        string Kirjailija;
        string Kustantaja;
        double Hinta;
        static string teemanNimi;

        //K
        public Kirja()
        {
            Nimi = " ";
            Kirjailija = " ";
            Kustantaja = " ";
            Hinta = 22;
            teemanNimi = " ";
        }

        public Kirja(string nimi, string kirjailija, string kustantaja, double hinta, string teemannimi)
        {
            Nimi = nimi;
            Kirjailija = kirjailija;
            Kustantaja = kustantaja;
            Hinta = hinta;
            teemanNimi = teemannimi;
        }

        //M
        public void HaeKirja()
        {
            Console.Write(" ");
            string haku = Console.ReadLine();

            if (haku == Nimi)
            {
                Console.WriteLine("\nKirjan nimi: " + Nimi);
                Console.WriteLine("Kirjailija: " + Kirjailija);
                Console.WriteLine("Kustantaja: " + Kustantaja);
                Console.WriteLine("Hinta: " + Hinta);
                Console.WriteLine("Teema: " + teemanNimi);
            }

            else
                Console.Write("Haku epäonnistui.");
        }

        public bool HaeKirja2(string haku)
        {
            if (haku == Nimi)
                return true;
            else
                return false;
        }

        public void KirjaInfo()
        {
            Console.WriteLine("\nKirjan nimi: " + Nimi);
            Console.WriteLine("Kirjailija: " + Kirjailija);
            Console.WriteLine("Kustantaja: " + Kustantaja);
            Console.WriteLine("Hinta: " + Hinta);
            Console.WriteLine("Teema: " + teemanNimi);
        }

    }

}





