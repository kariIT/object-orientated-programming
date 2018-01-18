using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_luokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Audi", 250);


            Auto auto2 = new Auto();
           

            Auto autox = new Auto()
            {
                Merkki = "",
                Nopeus = 0
            };

            autox.KysyTiedot();
            auto2.KysyTiedot();


            auto1.NäytäTiedot();
            autox.NäytäTiedot();
            auto2.NäytäTiedot();

            Console.ReadLine();

            
        }
    }
}
