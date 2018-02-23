using System;
using System.Collections.Generic;

namespace rajapinta
{
    class Program
    {
        public static List<Product> products = new List<Product>();
        public static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        { 
            GenerateProductData();
            PrintProductData();


            GenerateCustomerData();
            PrintCustomerData();
             
            Console.ReadLine();

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
        public static void GetProductData()
        {
            
        }




        
        public static void GenerateCustomerData()
        {
            Random rnd = new Random();
            for (int i = 0; i < 200; i++)
            {
                customers.Add(new Customer ("Customer " + i, "Product "+rnd.Next(1, 1000)));
            }
        }

        public static void PrintCustomerData()
        {
            foreach (var c in customers)
            {
                Console.WriteLine(c);
            }
        }
        
    }
}
