using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lipunhinnan_laskenta
{
    class Program
    {
        static void Main(string[] args)
        {
            Asiakas asiakas = new Asiakas("Matti", 20);


            asiakas.KysyTiedot();




            Console.ReadLine();
        }

    }
}
