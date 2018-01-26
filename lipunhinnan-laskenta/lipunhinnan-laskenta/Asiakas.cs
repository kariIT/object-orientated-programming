using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lipunhinnan_laskenta
{
    class Asiakas
    {
        string Nimi;
        int Ikä;
        //string NN;

        public Asiakas()
        {
            Nimi = "Ei tietoa.";
            Ikä = 22;
            //NN = "Ei tietoa.";
        }
        public Asiakas(string nimi, int ikä)
        {
            Nimi = nimi;
            Ikä = ikä;
        }

        //Metodit

        public void KysyTiedot()
        {
            Console.WriteLine("Nimi: ");
            string nimi = Console.ReadLine();

            Console.WriteLine("Ikä: ");
            int ikä = int.Parse(Console.ReadLine());

            Console.WriteLine("Oletko 1) MTK jäsen, 2) varusmies, 3) opiskelija, 0) ei mikään näistä?: ");
            string alennus = Console.ReadLine();

            //string LipunHinta()
            {
                double hinta = 16;

                if (ikä < 7)
                    Console.Write("Alle 7-vuotiaat sisään ilmaiseksi.");

                else if (ikä > 65)
                    Console.Write("Eläkeläislipun hinta " + hinta * 0.5 + " euroa.");

                else if (ikä > 7 && ikä < 15)
                    Console.Write("Lapsilipun hinta " + hinta * 0.5 + " euroa.");

                else if (alennus == "1")
                    Console.Write("Lipun hinta MTK jäsenille " + hinta * 0.85 + " euroa.");

                else if (alennus == "2")
                    Console.Write("Lipun hinta varusmiesalennuksella " + hinta * 0.5 + " euroa.");

                else if (alennus == "3")
                {
                    Console.Write("Oletko myös MTK jäsen? \n1) kyllä \n2) ei ");
                    int mtk = int.Parse(Console.ReadLine());

                    if (mtk == 1)
                        Console.Write("Lipun hinta " + hinta * 0.85 * 0.55 + " euroa.");

                    else if (mtk == 2)
                    Console.Write("Lipun hinta opiskelija-alennuksella " + hinta * 0.55 + " euroa.");
                }
                    
                else
                    Console.Write("seis");

            }
        }
    }


}
