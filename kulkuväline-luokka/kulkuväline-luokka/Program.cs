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
            Kulkuväline kv = new Kulkuväline("Mopo", "Suzuki", 1985, 500);
            Auto auto = new Auto(2.0, "Avensis", 5);

            Console.WriteLine(kv.Tiedot());
            Console.WriteLine(auto.Tiedot()+ "\n");
            

            Console.ReadLine();
        }
    }
}
