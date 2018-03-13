using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Customer
    {
        string FirstName;
        string LastName;
        string AccountNumber;

        public Customer()
        {
            FirstName = "Undefined";
            LastName = "Undefined";
            AccountNumber = "FI01 2345 6789 0000";
        }
        public Customer(string firstname, string lastname, string accountnumber)
        {
            FirstName = firstname;
            LastName = lastname;
            AccountNumber = accountnumber;
        }
        public override string ToString()
        {
            return $"{FirstName}, {LastName}, {AccountNumber}.";
        }
    }
}
