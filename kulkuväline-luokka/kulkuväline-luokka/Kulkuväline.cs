using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulkuväline_luokka
{
    class Kulkuväline
    {
        protected string Tyyppi;
        protected string Merkki;
        protected int Vuosimalli;
        protected double Hinta;

        public Kulkuväline()
        {
            Tyyppi = "Ei tietoa";
            Merkki = "Ei merkkiä";
            Vuosimalli = 0;
            Hinta = 0;
        }
        public Kulkuväline(string tyyppi, string merkki, int vuosimalli, double hinta)
        {
            Tyyppi = tyyppi;
            Merkki = merkki;
            Vuosimalli = vuosimalli;
            Hinta = hinta;
        }

        public virtual string Tiedot()
        {
            return $"Tyyppi: " + Tyyppi + "\nMerkki: " + Merkki + "\nVuosimalli: " + Vuosimalli + "\nHinta: " + Hinta;
        }
    }
}
