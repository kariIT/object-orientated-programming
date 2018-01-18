﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_luokka
{
    class Auto
    {
        //Muuttujat
        public string Merkki;
        public int Nopeus;

        //Konstruktori
        public Auto()
        {
            Merkki = "Ei tietoa";
            Nopeus = 250;
        }

        public Auto(string merkki, int nopeus)
        {
            Merkki = merkki;
            Nopeus = nopeus;
        }


        //Metodit
        public void KysyTiedot() //kysyy merkin ja nopeuden ja sijoittaa nämä arvot
        {
            Console.Write("Anna tiedot: \n");

            Console.WriteLine("Merkki: ");
            Merkki = Console.ReadLine();

            Console.WriteLine("Nopeus: ");
            Nopeus = int.Parse(Console.ReadLine());
        }
            
         public void NäytäTiedot() //tulostaa auton merkin ja nopeuden
         {
            Console.WriteLine("Merkki: " + Merkki);
            
            Console.WriteLine("Nopeus: " + Nopeus);

         }
    }
}
