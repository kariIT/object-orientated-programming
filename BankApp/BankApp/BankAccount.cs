using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class BankAccount
    {
        string AccountNumber;
        List<Transaction> transactions;
        double Balance;

        public BankAccount()
        {
            AccountNumber = "FI01 2345 6789 0000";
            List<Transaction> transactions = new List<Transaction>();
            Balance = 0;
        }
        public BankAccount(string accountnumber, List<Transaction> list, double balance)
        {
            AccountNumber = accountnumber;
            List<Transaction> transactions = list;
            Balance = balance;
        }
    }
}
