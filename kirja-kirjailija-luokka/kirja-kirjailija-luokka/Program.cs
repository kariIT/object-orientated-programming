using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirjallisuus
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Kirja kirja = new Kirja("Aamu", "Eeli Tamminen", "PV", 35.10, "metsä", 35.10);
            

            Kirja kirja1 = new Kirja("Teline", "Johannes", "Petteri", 88.70, "lauta", 88.70);
            

            Kirja kirja2 = new Kirja("Muki", "Eemeli", "Johannes", 15.10, "kahvi", 15.10);
            

            Kirja kirja3 = new Kirja("Pöytä", "Kaisa", "HH", 14, "seinä", 14);


            Kirja[] kirjat = new Kirja[4];
            kirjat[0] = kirja;
            kirjat[1] = kirja1;
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
                    Console.WriteLine($"{etsittavaKirja} Kirja löytyi!\n" +
                        $"");
                    kirjat[i].KirjaInfo();
                    isKirjaLoytynyt = true;
                    break;
                }
            }

            if (!isKirjaLoytynyt)
                Console.WriteLine(
                    $"{etsittavaKirja.ToUpper()} Kirjaa ei löytynyt!" +
                    $"\n-------------------------------");

            

            Kirjailija Eeli = new Kirjailija("Eeli Tamminen", "01.02.1990", kirja);
            Kirjailija Johannes = new Kirjailija("Johannes", "06.07.1980", kirja1);

            Eeli.Tiedot();
            
            Johannes.Tiedot();
            
            

            Console.ReadLine();
        }
    }
}
