using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyontekija_luokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Tyontekija tyontekija = new Tyontekija("Masa", 111, "Kassa", 1900);
       
            Tyontekija tyontekija2 = new Tyontekija("Teppo", 222, "Varasto", 2200);

            tyontekija.Tiedot();
            tyontekija2.Tiedot();

            Console.Write(tyontekija.CompareSalary(tyontekija2));
            
            Console.ReadLine();
        }
    }
}
