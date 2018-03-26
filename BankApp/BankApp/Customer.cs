using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Customer
    {
        public string FirstName { get; }
        public string LastName { get; }
        private string _accountNumber;

        public string AccountNumber { get => _accountNumber; set => _accountNumber = value; }

        //constructor
        public Customer()
        {
            FirstName = "Undefined";
            LastName = "Undefined";
            _accountNumber = "FI01 2345 6789 0000";
        }
        public Customer(string firstname, string lastname, string accountnumber)
        {
            FirstName = firstname;
            LastName = lastname;
            _accountNumber = accountnumber;
        }

        //methods
        public override string ToString()
        {
            return $"{FirstName}, {LastName}, {_accountNumber}.";
        }
        public void PrintCustomerInfo()
        {
            Console.WriteLine("" + FirstName + LastName + _accountNumber + "");
        }
    }
}
