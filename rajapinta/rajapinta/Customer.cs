using System;
using System.Collections.Generic;
using System.Text;

namespace rajapinta
{
    class Customer : ICustomer
    {
        string Name;
        double Purchases;

        public Customer()
        {
            Name = "Masa";
            Purchases = 0;
        }
        public Customer(string name, double purchases)
        {
            Name = name;
            Purchases = purchases;
        }
        public override string ToString()
        {
            return $"{Name}, {Purchases}";
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
            double total;
            if (Purchases <= 1000)
            {
                total = Purchases * 0.02;
                Console.WriteLine($"{Name}, Bonus 2%: {total}");
            }
            else if (Purchases > 1000 && Purchases < 2000)
            {
                total = Purchases * 0.03;
                Console.WriteLine($"{Name}, Bonus 3%: {total}");
            }
            else
            {
                total = Purchases * 0.05;
                Console.WriteLine($"{Name}, Bonus 5%: {total}");
            }
        }

        public void SearchCustomer(List<Customer> customers, string search)
        {
            Customer foundData = customers.Find(c => c.Name.Equals(search));
            if (foundData == null)
                Console.WriteLine("Customer not found. ");
            else
                Console.WriteLine($"Customer found\n" + 
                    $"{foundData.ToString()}");
        }
    }
}
