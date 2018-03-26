using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BankApp v1.0");

            Bank bank = new Bank("Bank");

            List<Customer> customers = new List<Customer>
            {
                new Customer("Aku", "Ankka", bank.CreateAccount()),
                new Customer("Mikki", "Hiiri", bank.CreateAccount()),
                new Customer("Hannu", "Hanhi", bank.CreateAccount()),
            };

            bank.GetBalance(customers[0].AccountNumber);

            //transactions
            bank.AddTransaction(customers[0].AccountNumber, new Transaction(new DateTime(2018, 03, 23), 2000));
            bank.AddTransaction(customers[1].AccountNumber, new Transaction(new DateTime(2017, 04, 22), 1000));
            bank.AddTransaction(customers[2].AccountNumber, new Transaction(new DateTime(2017, 05, 21), 7000));
            bank.AddTransaction(customers[0].AccountNumber, new Transaction(new DateTime(2017, 01, 11), 120));
            bank.AddTransaction(customers[1].AccountNumber, new Transaction(new DateTime(2016, 03, 12), 100000));
            bank.AddTransaction(customers[2].AccountNumber, new Transaction(new DateTime(2016, 12, 03), 5000));
            bank.AddTransaction(customers[1].AccountNumber, new Transaction(new DateTime(2015, 07, 05), -2500));
            //randomtransactions 
            /*
            for (int i = 0; i < 20; i++)
            {
                Random rnd = new Random();

                bank.AddTransaction(customers[rnd.Next(0, 2)].AccountNumber,
                    new Transaction(rnd.Next(-10000, 20000)));
                new DateTime(rnd.Next(2015, 2018), rnd.Next(1, 12), rnd.Next(1, 28));
            }   */

            void PrintBalance(Bank b, Customer customer)
            {
                var balance = bank.GetBalance(customer.AccountNumber);
                Console.WriteLine("{0} balance: {1}{2:0.00}",
                    customer.ToString(), balance >= 0 ? "+" : "", balance);
                /*
                if (balance >= 0)
                {
                    Console.WriteLine($"{customer}+{balance:F}");
                }
                //else
                   // Console.WriteLine($"{customer}-{balance:F}");
                   */
            }

            PrintBalance(bank, customers[0]);
            PrintBalance(bank, customers[1]);
            PrintBalance(bank, customers[2]);

            void PrintTransactions(List<Transaction> transactions, Customer customer)
            {
                Console.WriteLine($"Tilitapahtumat {customer.FirstName} {customer.LastName}:");

                for (int i = 0; i < transactions.Count(); i++)
                {
                    Console.WriteLine("{0}\t{2:0.00}",
                        transactions[i].Timestamp.ToShortDateString(),
                        transactions[i].Sum >= 0 ? "+" : "\n",
                        transactions[i].Sum);
                }
            }

            //timevariables
            var endTime = DateTime.Today;
            var time = new TimeSpan(24 * 30 * 6, 0, 0);
            //var startTime = endTime - time;
            var startTime = new DateTime(2015, 01, 01);

            PrintTransactions(bank.GetTransactionsForCustomerForTimeSpan(customers[0].AccountNumber, startTime, endTime), customers[0]);
            PrintTransactions(bank.GetTransactionsForCustomerForTimeSpan(customers[1].AccountNumber, startTime, endTime), customers[1]);
            PrintTransactions(bank.GetTransactionsForCustomerForTimeSpan(customers[2].AccountNumber, startTime, endTime), customers[2]);

            Console.WriteLine("Press <Enter> to exit.");
            Console.ReadLine();
        }
    }
}
