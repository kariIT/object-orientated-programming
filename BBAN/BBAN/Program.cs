using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBAN
{
    class Program
    {
        static void Main(string[] args)
        {
            string machineFormat = "227720-35988";
            bool isMachineFormmat = UtilityBBAN.CorrectNumber(ref machineFormat);
            if (isMachineFormmat)
                Console.WriteLine($"{machineFormat} - { UtilityBBAN.IsValidAccount(machineFormat)}");
            else
                Console.WriteLine("Account number incorrect!");

            Console.ReadLine();
        }
    }
}
