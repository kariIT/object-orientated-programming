using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firma_luokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma firma = new Firma("Hese", "Kerrostie 2", "0201234567", 10000, 1000);
            Firma firma2 = new Firma("Näkkäri", "Ranskakuja 5", "0207654321", 20000, 10000);
            Firma firma3 = new Firma(firma2)
            {
                Nimi = "Käkkäri",
                Tulot = 0
            };

            Console.Write(firma.Tiedot());
            Console.Write("\n\n");

            Console.Write(firma2.Tiedot());
            Console.Write("\n\n");

            Console.Write(firma3.Tiedot());
            Console.Write("\n\n");
            

            firma.Tulos();
            firma.MitenMenee();
            Console.Write("\n\n");

            firma2.Tulos();
            firma2.MitenMenee();
            Console.Write("\n\n");

            firma3.Tulos();
            firma3.MitenMenee();

            Console.ReadLine();
        }
    }
}

