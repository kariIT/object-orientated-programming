using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulkuväline_luokka
{
    class Auto : Kulkuväline
    {
        protected double koneenKoko;
        protected string Malli;
        protected int ovienLkm;

        public Auto()
        {
            
            koneenKoko = 0;
            Malli = "Ei mallia";
            ovienLkm = 0;

        }
        public Auto(double koneenkoko, string malli, int ovienlkm) //string tyyppi, string merkki, int vuosimalli, 
            
        {
            koneenKoko = koneenkoko;
            Malli = malli;
            ovienLkm = ovienlkm;

           /* Tyyppi = tyyppi;
            Merkki = merkki;
            Vuosimalli = vuosimalli;
            Hinta = hinta;*/

        }
        public override string Tiedot() =>
            $" " +
            //\nTyyppi: " + Tyyppi + 
            //"\nMerkki: " + Merkki + 
            "\nMalli: " + Malli +
            //"\nVuosimalli: " + Vuosimalli + 
            "\nMoottorin tilavuus: " + koneenKoko +
            "\nOvien lukumäärä: " + ovienLkm;
            //"\nHinta: " + Hinta
            
    }
}
