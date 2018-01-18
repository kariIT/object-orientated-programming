using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firma_luokka
{
    class Firma
    {
        //Muuttujat
        public string Nimi;
        public string Osoite;
        public int Puhelin;
        public double Tulot;
        public double Menot;

        //Konstruktori

        public Firma()
        {
            Nimi = "Firma";
            Osoite = "Sijainti";
            Puhelin = 1234560000;
            Tulot = 10000;
            Menot = 5000;

        }

        //KopioKonstruktori

        public Firma(Firma kopioFirma)
        {
            Nimi = kopioFirma.Nimi;
            Osoite = kopioFirma.Osoite;
            Puhelin = kopioFirma.Puhelin;
            Tulot = kopioFirma.Tulot;
            Menot = kopioFirma.Menot;

        }

        //KopioTapaus

        public Firma(string nimi, string osoite, int puhelin, double tulot, double menot)
        {
            Nimi = nimi;
            Osoite = osoite;
            Puhelin = puhelin;
            Tulot = tulot;
            Menot = menot;

        }

        public string Tiedot()
        {
            return $"{Nimi} + {Osoite} + {Puhelin} + {Tulot} + {Menot}";
            
        }
            
        //Metodit 

        public void Tulos()
        {
            double tulos = Tulot - Menot;
            double voittoprosentti = ((Tulot - Menot) / Menot * 100);
            
            
            Console.WriteLine($"Yrityksen {Nimi} tulos: " + tulos + " ja voitto%: " + voittoprosentti);
            //tulokseen valuutta ja voittoprosentti näyttämään %arvo yhden desimaalin tarkkuudella
        }
    }
}
 