using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirjallisuus
{
    class Kirjailija
    {
        string Nimi;
        string Synttärit;
        Kirja kirjaX;
 
        public Kirjailija()
        {
            Nimi = "Ei tietoa.";
            Synttärit = "01.01.2000";
            kirjaX = new Kirja();
            
        }

        public Kirjailija(string nimi, string synttärit, Kirja kirja)
        {
            Nimi = nimi;
            Synttärit = synttärit;
            kirjaX = kirja;
           
        }

        public void Tiedot()
        {
            Console.WriteLine($"Nimi: {Nimi}\n" +
                $"Syntynyt: {Synttärit} \n" +
                $"Kirjoittanut: ");
            kirjaX.KirjaInfo() ;
        }
    }
}
