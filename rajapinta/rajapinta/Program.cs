using System;
using System.Collections.Generic;

namespace rajapinta
{
    class Program
    {
        public static List<Product> products = new List<Product>();

        static void Main(string[] args)
        {


            /* Product product = new Product("Product 1", 10, 1);
             Product product2 = new Product("Product 2", 10, 5);
             Product product3 = new Product("Product 3", 20, 2);

             products.Add(product);
             products.Add(product2);
             products.Add(product3); */

            //  Console.WriteLine(product.ToString());

            //  product3.CountValue();

            //  product.GetProduct();
            GenerateData();
            PrintData();
           

             
            Console.ReadLine();

        }
        public static void GenerateData()
        {
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                products.Add(new Product("Product "+i, rnd.Next(5, 50), rnd.Next(1, 10)));
            }  
        }
        public static void PrintData()
        {
            foreach (var p in products)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
