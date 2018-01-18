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


            Auto auto2 = new Auto("Datsun", 100);
           

            Auto autox = new Auto()
            {
                Merkki = "",
                Nopeus = 0
            };


           
            autox.KysyTiedot();
            Console.Clear();
            

            auto1.Kaasu();
            auto1.NäytäTiedot();
           

            Console.Write("\n");
           
            
            auto2.Jarru();
            auto2.NäytäTiedot();

            Console.Write("\n");

            autox.NäytäTiedot();

            Console.ReadLine();

            
        }
    }
}
