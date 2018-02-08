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

            Kulkuväline auto = new Kulkuväline("Auto", "Toyota", 2001, 3500);
            Auto auto_ = new Auto(2.0, "Avensis", 5);

            Kulkuväline auto1 = new Kulkuväline("Auto", "BMW", 1996, 4000);
            Auto auto1_ = new Auto(3.2, "330", 3);

            Kulkuväline kuorma_auto = new Kulkuväline("Kuorma-auto", "Scania", 2000, 20000);
            Auto kuorma_auto_ = new Auto(8.0, "Vabis", 2);
            Kuorma_auto _kuorma_auto_ = new Kuorma_auto(300, 10);
            

            Console.WriteLine(mopo.Tiedot() + "\n");

            Console.WriteLine(auto.Tiedot());
            Console.WriteLine(auto_.Tiedot() + "\n");

            Console.WriteLine(auto1.Tiedot());
            Console.WriteLine(auto1_.Tiedot() + "\n");

            //Console.WriteLine(auto_.ToString() + "\n");

            Console.WriteLine($"Onko 3.2 suurempi kuin 2.0? {auto1_.Equals(auto_)}\n");

            Console.WriteLine(kuorma_auto.Tiedot());
            Console.WriteLine(kuorma_auto_.Tiedot());
            Console.WriteLine(_kuorma_auto_.LaskeKulutus());


            Console.ReadLine();
        }
    }
}
 