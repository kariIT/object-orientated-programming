using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BankApp
{
    class Bank
    {
        private string _name;
        private List<BankAccount> _accounts;

        public Bank(string name)
        {
            _name = name;
            _accounts = new List<BankAccount>();
        }
        public Bank()
        {
            _name = "Undefined";
            _accounts = new List<BankAccount>();
        }
        public Bank(string name, List<BankAccount> accounts)
        {
            _name = name;
            _accounts = accounts;
        }

        public string CreateAccount()
        {
            Random rnd = new Random();
            string rndAccount = "FI";
            for (int i = 0; i < 16; i++)
            {
                rndAccount += rnd.Next(0, 10);
            }
            _accounts.Add(new BankAccount(rndAccount));
            return rndAccount;
        }
        public void GetTransactions()
        {

        }
        public void GetTransactionsTimeSpan()
        {
            
        }
        public double GetBalance(string accountNumber)
        {
            return (_accounts.Where(account => account.AccountNumber == accountNumber)).FirstOrDefault().Balance;
        }

        public bool AddTransaction(string accountnumber, Transaction transaction)
        {
            return (from account in _accounts
                    where account.AccountNumber == accountnumber
                    select account).First().AddTransaction(transaction);
        }
        public List<Transaction> GetTransactionsForCustomerForTimeSpan(string accountNumber, DateTime startTime, DateTime endTime)
        {
            return (from account in _accounts
                where account.AccountNumber == accountNumber
                select account).FirstOrDefault().GetTransactionsForTimeSpan(startTime, endTime);
        }
    }
}
