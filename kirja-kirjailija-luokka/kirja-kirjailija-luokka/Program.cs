using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirja_kirjailija_luokka
{
    class Program
    {
        static void Main(string[] args)
        {

            Kirja kirja = new Kirja("Aamu", "Eeli Tamminen", "PV", 5.10, "metsä");

            Kirja kirja1 = new Kirja("Teline", "Johannes", "Petteri", 8.70, "lauta");

            Kirja kirja2 = new Kirja("Muki", "Eemeli", "Johannes", 15.10, "kahvi");

            Kirja kirja3 = new Kirja("Pöytä", "Kaisa", "HH", 14, "seinä");


            kirja.HaeKirja();


            Console.ReadLine();
        }
    }
}
