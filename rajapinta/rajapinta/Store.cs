using System;
using System.Collections.Generic;
using System.Text;

namespace rajapinta
{
    class Store : ICustomers, IProducts
    {
        string Name;
        double Turnover;
        public List<Customer> customers;
        public List<Product> products;

        public Store()
        {
            Name = "Undefined";
            Turnover = 0;
            List<Customer> customers = new List<Customer>();
            List<Product> products = new List<Product>();
        }
        public Store(string name, double turnover)
        {
            Name = name;
            Turnover = turnover;
        }
        public override string ToString()
        {
            return $"{Name}, {Turnover}";
        }

        public void AddCustomers(List<Customer> customer)
        {
            customers = customer;
        }
        public void PrintCustomers()
        {
            foreach (Customer c in customers)
            {
                Console.WriteLine(c);
            }
        }

        public void AddProducts(List<Product> product)
        {
            products = product;
        }
        public void PrintProducts()
        {
            foreach (var p in products)
            {
                Console.WriteLine(p);
            }
        }
    }
}
