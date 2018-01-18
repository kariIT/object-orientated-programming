using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firma_luokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma firma = new Firma("Hese", "Kerrostie 2", 0201234567, 10000, 9000);
            Firma firma2 = new Firma("Näkkäri", "Ranskakuja 5", 0207654321, 20000, 17500);

            firma.Tiedot();
            firma2.Tiedot();

            firma.Tulos();
            firma2.Tulos();

            Console.ReadLine();
        }
    }
}
/*

Kirjoita luokalle
oletusmuodostin(parametritön),
muodostin, joka sisältää kaikki parametrit sekä
kopiontimuodostin, jolla olio voidaan kopioida.
Määritä luokalle myös metodi, joka tulojen ja menojen perusteella laskee firman voiton.
Metodin pitää laskea voitto%=[(tulot - menot)/menot x 100] ja sen perusteella tulostaa tulostaa näytölle viesti, 
joka kertoo, kuinka hyvin firmalla menee.
kehnosti, jos voitto on alle 100% suurempi kuin menot
tyydyttävästi, jos voitto on vähintään 200% suurempi kuin menot
hyvin, jos voitto on vähintään 300% suurempi kuin menot
Luo testausohjelmassa oliota Firma-luokasta ja kopioi yksi olio kopiointimuodostimella.
Luotuasi olioita, kutsu niiden metodi, joka kertoo firman tilanteesta.*/