using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulkuväline_luokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Kulkuväline mopo = new Kulkuväline("Mopo", "Suzuki", 1985, 500);
            Auto auto = new Auto("Auto", "Toyota", 2001, 4000, 2.0, "Avensis", 5);
            Auto auto1 = new Auto("Auto", "BMW", 1996, 3500, 3.2, "330", 3);
           

            Console.WriteLine(mopo.Tiedot());
            Console.WriteLine(auto.Tiedot());
            Console.WriteLine(auto1.Tiedot());
            

            Console.ReadLine();
        }
    }
}
