using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulkuväline_luokka
{
    class Auto : Kulkuväline
    {
        double koneenKoko;
        string Malli;
        int ovienLkm;

        public Auto()
        {
            
            koneenKoko = 0;
            Malli = "Ei mallia";
            ovienLkm = 0;

        }
        public Auto(double koneenkoko, string malli, int ovienlkm) 
        {
            koneenKoko = koneenkoko;
            Malli = malli;
            ovienLkm = ovienlkm;

        }
        public string Tiedot() => $"\nIskutilavuus: " + koneenKoko + "\nMalli: " + Malli + "\nOvien lukumäärä: " + ovienLkm; 
    }
}
