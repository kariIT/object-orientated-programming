using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyontekija_luokka
{
    class Tyontekija
    {
         public string Nimi;
         public int Id;
         public string Tehtävä;
         public double Palkka;
    
    //Konstruktori

    public Tyontekija()
        {
            Nimi = "Tuntematon";
            Id = 1234;
            Tehtävä = "Ei tietoa";
            Palkka = 2222;
        }

        public Tyontekija(string nimi, int id, string tehtävä, double palkka)
        {
            Nimi = nimi;
            Id = id;
            Tehtävä = tehtävä;
            Palkka = palkka;
        }
        

    //Metodit

    public string Tiedot()
        {
            
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Tehtävä: " + Tehtävä);
            Console.WriteLine("Palkka: " + Palkka);
            Console.Write("\n");
            return " ";
        }

    public string CompareSalary(Tyontekija tyontekija)
        {
            if (this.Palkka > tyontekija.Palkka)
                return $"Palkka ({this.Palkka}) on suurempi kuin työntekijän palkka ({tyontekija.Palkka})";
            

            else if (tyontekija.Palkka > this.Palkka)
                return $"Työntekijän {tyontekija.Nimi} palkka ({tyontekija.Palkka}) on suurempi kuin työntekijän {this.Nimi} palkka ({this.Palkka}).";
            

            else
                return $" ";
        }

    }  

}
/*
Luo testaussovelluksen

Employee[] employees = new Employee[3];

taulukko, jonka alkiot ovat Tyontekija-olioita. 
Tulosta näytölle taulukon kaikkien olio-alkioiden tiedot ja vertaile eri alkioiden palkkoja CompareSalary()-metodille.

Vihje: Jos haluat luoda taulukon, jonka alkiot ovat olioita, ensin pitää varata muistia taulukolle ja siten jokaliselle olio-alkiolle erikseen:

// Seuraavassa ensin luodaan tyontekijat-taulukko, jolla on kolme alkiota ja sitten sen olio-alkiot alustetaan.

Employee[] employees = new Employee[3];
employees[0] = new Employee(...);
employees[1] = new Employee(...);
employees[2] = new Employee(...);
*/