using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirjallisuus
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
            Hinta = 22.22;
            teemanNimi = " ";
            UusiHinta = 22.22;
        }

        public Kirja(string nimi, string kirjailija, string kustantaja, double hinta, string teemannimi, double uusihinta)
        {
            Nimi = nimi;
            Kirjailija = kirjailija;
            Kustantaja = kustantaja;
            Hinta = hinta;
            teemanNimi = teemannimi;
            UusiHinta = uusihinta;
        }

        public double UusiHinta
        {
            get { return Hinta; }

            set

            {
                if (Hinta > 30)
                    Hinta = value * 0.9;
                else
                   Hinta = value;
            }

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
                Console.WriteLine("\n");
                
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
            Console.WriteLine("\n------------------------\n");
        }
         /*   public static string VaihdaTeema
            {
                get { return teemanNimi; }
                set { teemanNimi = value; }
            }*/
      
            
    }

      
        

    

}





