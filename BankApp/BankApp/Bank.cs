using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Bank
    {
        string Name;
        List<BankAccount> accounts;

        public Bank()
        {
            Name = "Undefined";
            List<BankAccount> accounts = new List<BankAccount>();
        }
        public Bank(string name)
        {
            Name = name;
        }
    }
}
