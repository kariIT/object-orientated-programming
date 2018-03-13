using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("Bank");

            Customer customer = new Customer("Matti", "Meikäläienen", "FI11 1111 1111 1111");
            Customer customer2 = new Customer("Teppo", "Tulppu", "FI22 2222 2222 2222");
            Customer customer3 = new Customer("Mikki", "Hiiri", "FI33 3333 3333 3333");


        }
    }
}
