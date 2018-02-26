using System;
using System.Collections.Generic;
using System.Text;

namespace rajapinta
{
    class Customer : ICustomer
    {
        string Name;
        string Purchases;

        public Customer()
        {
            Name = "Masa";
            Purchases = "Product i";
        }
        public Customer(string name, string purchases)
        {
            Name = name;
            Purchases = purchases;
        }
        public override string ToString()
        {
            return $"{Name} = {Purchases}";
        }
        public void GetCustomer()
        {
            Console.WriteLine("Type customer name: ");
            string search = Console.ReadLine();

            if (search == Name)
            {
                Console.WriteLine("Customer found. ");
                Console.WriteLine("Name: " + Name + "\nPurchases: " + Purchases);
            }   
            else
                Console.WriteLine("Customer not found. ");
        }
        public void CountBonus()
        {

        }
        public void SearchCustomer(List<Customer> listCustomers, string search)
        {
            Customer foundData = listCustomers.Find(c => c.Name.Equals(search));
            if (foundData == null)
                Console.WriteLine("Customer not found. ");
            else
                Console.WriteLine($"Customer found\n" + 
                    $"{foundData.ToString()}");
        }

    }
}
