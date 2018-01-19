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
        public string Puhelin;
        public double Tulot;
        public double Menot;

        //Konstruktori

        public Firma()
        {
            Nimi = "Firma";
            Osoite = "Sijainti";
            Puhelin = "Ei tiedossa!";
            Tulot = 10000.00f;
            Menot = 5000.00f;

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

        //KopioIlmentymä





        public Firma(string nimi, string osoite, string puhelin, double tulot, double menot)
        {
            Nimi = nimi;
            Osoite = osoite;
            Puhelin = puhelin;
            Tulot = tulot;
            Menot = menot;

        }

        public string Tiedot()
        {
            return $"Yritys: {Nimi}\nOsoite: {Osoite}\nPuh. {Puhelin}\nTulot: {Tulot}\nMenot: {Menot} ";
            
        }
            
        //Metodit 

        public void Tulos()
        {
            double tulos = Tulot - Menot;
            double voittoprosentti = ((Tulot - Menot) / Menot * 100);
            
            Console.WriteLine($"Yrityksen {Nimi} tulos: " + "{0:C}", tulos + " ja voitto%: " + voittoprosentti + "% ");
            //tulokseen valuutta ja voittoprosentti näyttämään %arvo yhden desimaalin tarkkuudella

        }
        public void MitenMenee()
        {
            double voittoprosentti = ((Tulot - Menot) / Menot * 100);

            if (voittoprosentti > 100 && voittoprosentti < 200)
            {
                Console.Write("Tyydyttävästi menee! ");
            }
            else if (voittoprosentti > 200)
            {
                Console.Write("Hyvin menee! ");
            }
            else if (voittoprosentti < 100)
            {
                Console.Write("Kehnosti menee!");
            }
            else if (voittoprosentti == 100 & voittoprosentti < 200)
            {
                Console.Write("Tyydyttävästi menee!");
            }
        }
    }
}
 