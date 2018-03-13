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
            Store store = new Store("Market", 1000000);

            GenerateProductData();
            //PrintProductData();

            GenerateCustomerData();
            //PrintCustomerData();

            SearchProduct();
            SearchCustomer();
            //CustomerBonus();

            /*
            store.AddCustomers(customers);
            store.PrintCustomers();
            store.AddProducts(products);
            store.PrintProducts();
            */

            Exit();

        }
        public static void GenerateProductData()
        {
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                products.Add(new Product("Product "+i, rnd.Next(5, 50), rnd.Next(1, 10)));
            }  
            //tuottaa listan tuotteita
        }
        public static void PrintProductData()
        {
            foreach (var p in products)
            {
                Console.WriteLine(p.ToString());
                
                {
                    p.CountValue();
                }
                //tulostaa tuotteen tiedot
            }
        }
        public static void SearchProduct()
        {
            Console.Write("Search products: ");
            string search = Console.ReadLine();

            products[0].SearchProduct(products, search);
            //etsii tuotteen
        }

        public static void GenerateCustomerData()
        {
            Random rnd = new Random();
            for (int i = 0; i < 200; i++)
            {
                customers.Add(new Customer ("Customer "+i, 1+rnd.Next(1, 6000)));
            }
            //tuottaa listan asiakkaita
        }
        public static void PrintCustomerData()
        {
            foreach (var c in customers)
            {
                Console.WriteLine(c);
            }
            //tulostaa asiakkaan tiedot
        }
        public static void SearchCustomer()
        {
            Console.Write("Search customers: ");
            string search = Console.ReadLine();

            customers[0].SearchCustomer(customers, search);    
            //etsii asiakkaan listalta
        }
        public static void CustomerBonus()
        {
            foreach (var c in customers)
            {
                c.CountBonus();
            }
            //näyttää asiakkaan nimen, bonusprosentin ja bonuksen määrän
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
            //kysyy haluatko poistua ohjelmasta vai suorittaa sen uudelleen
        }
    }
}
