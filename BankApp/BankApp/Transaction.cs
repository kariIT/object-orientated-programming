using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Transaction
    {
        string Timestamp;
        double Amount;

        public Transaction()
        {
            Timestamp = "DDMMYYYYHHMMSS";
            Amount = 0;
        }
    }
}
