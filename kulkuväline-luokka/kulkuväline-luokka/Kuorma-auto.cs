using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulkuväline_luokka
{
    class Kuorma_auto : Auto
    {
        int Kuormanpaino;
        int KulutusPerKg;

        public Kuorma_auto()
        {
            Kuormanpaino = 100;
            KulutusPerKg = 10;
        }
        public Kuorma_auto(int kuorma, int kulutusperkg)
        {
            Kuormanpaino = kuorma;
            KulutusPerKg = kulutusperkg;
        }
        public string LaskeKulutus()
        {

            double Kulutus = Kuormanpaino / KulutusPerKg;
            return ($"Kulutus: {Kulutus} litraa");

           
                
                
        }
    }
}
