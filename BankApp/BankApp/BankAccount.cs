using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApp
{
    class BankAccount
    {
        private string _accountNumber;
        private List<Transaction> _transactions;
        private double _balance;

        //constructor
        public BankAccount(string accountNumber)
        {
            _accountNumber = accountNumber;
            _transactions = new List<Transaction>();
        }
        public BankAccount()
        {
            _accountNumber = "FI01 2345 6789 0000";
            List<Transaction> _transactions = new List<Transaction>();
            Balance = 0;
        }
        public BankAccount(string accountnumber, List<Transaction> list, double balance)
        {
            _accountNumber = accountnumber;
            _transactions = list;
            Balance = balance;
        }
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public double Balance { get => _balance; set => _balance = value; }

        //methods
        public bool AddTransaction(Transaction transaction)
        {
            bool res = false;

            _transactions.Add(transaction);
            double balanceBeforeTransaction = Balance;
            if (_transactions.Last().Equals(transaction))
            {
                Balance += transaction.Sum;
            }
            if (Balance - transaction.Sum == balanceBeforeTransaction)
            {
                res = true;
            }
            return res;
        }
        public List<Transaction> GetTransactionsForTimeSpan(DateTime startTime, DateTime endTime)
        {
            List<Transaction> res = (from transaction in _transactions
                where transaction.Timestamp >= startTime && transaction.Timestamp <= endTime
                orderby transaction.Timestamp
                select transaction).ToList();

            return res;
        }
    }
}
