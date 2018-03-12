using System;
using System.Collections.Generic;

namespace rajapinta
{
    class Program
    {
        public static List<Product> products = new List<Product>();
        public static List<Customer> customers = new List<Customer>();

        static void Main()
        {
            GenerateProductData();
            //PrintProductData();

            GenerateCustomerData();
            //PrintCustomerData();

            SearchProduct();
            SearchCustomer();
            //CustomerBonus();
            

            Exit();

        }
        public static void GenerateProductData()
        {
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                products.Add(new Product("Product "+i, rnd.Next(5, 50), rnd.Next(1, 10)));
            }  
        }
        public static void PrintProductData()
        {
            foreach (var p in products)
            {
                Console.WriteLine(p.ToString());
                
                {
                    p.CountValue();
                }
                
            }
        }
        public static void SearchProduct()
        {
            Console.Write("Search products: ");
            string search = Console.ReadLine();

            products[0].SearchProduct(products, search);
        }

        public static void GenerateCustomerData()
        {
            Random rnd = new Random();
            for (int i = 0; i < 200; i++)
            {
                customers.Add(new Customer ("Customer "+i, 1+rnd.Next(1, 6000)));
            }
        }
        public static void PrintCustomerData()
        {
            foreach (var c in customers)
            {
                Console.WriteLine(c);
            }
        }
        public static void SearchCustomer()
        {
            Console.Write("Search customers: ");
            string search = Console.ReadLine();

            customers[0].SearchCustomer(customers, search);
        }
        public static void CustomerBonus()
        {
            foreach (var c in customers)
            {
                c.CountBonus();
            }
        }

        public static void Exit()
        {
            Console.WriteLine("\nPress 'Enter' to continue or type 'E' to exit..");
            string e = Console.ReadLine();

            if (e == "E") { Console.Clear(); }
            else if (e == "e") { Console.Clear(); }
            else if (e == "exit") { Console.Clear(); }
            else if (e == "Exit") { Console.Clear(); }

            else
            {
                Console.Clear();
                Main();
            }
        }
    }
}
