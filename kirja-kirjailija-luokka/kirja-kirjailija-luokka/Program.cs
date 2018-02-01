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

            //kirja.HaeKirja();

            Kirja[] kirjat = new Kirja[4];
            kirjat[0] = kirja;
            kirjat[1] = new Kirja("Teline", "Johannes", "Petteri", 8.70, "lauta");
            kirjat[2] = kirja2;
            kirjat[3] = kirja3;

            Console.WriteLine("======================");
            Console.WriteLine("\nHae kirjaa: ");
            string etsittavaKirja = Console.ReadLine();
            bool isKirjaLoytynyt = false;
            for(int i = 0;i<kirjat.Length;i++)
            {
                if (kirjat[i].HaeKirja2(etsittavaKirja))
                {
                    Console.WriteLine($"{etsittavaKirja} Kirja löytyi!");
                    kirjat[i].KirjaInfo();
                    isKirjaLoytynyt = true;
                    break;
                }
            }

            if (!isKirjaLoytynyt)
                Console.WriteLine($"{etsittavaKirja.ToUpper()} Kirjaa ei löytynyt!");





            Console.ReadLine();
        }
    }
}
