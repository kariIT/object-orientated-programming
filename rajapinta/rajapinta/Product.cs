﻿using System;
using System.Collections.Generic;
using System.Text;

namespace rajapinta
{
    class Product : IProduct
    {
         string Name;
         double Price;
         int Quantity;

        public Product()
        {
            Name = "Undefined";
            Price = 10;
            Quantity = 1;

        }
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"{Name}, P: {Price}, Q: {Quantity}";
        }

        public void GetProduct()
        {
            Console.Write("Search products: ");
            string search = Console.ReadLine();

            if (search == Name)
            {
                Console.WriteLine("Product found. ");
            }
            else
                Console.WriteLine("Product not found. ");
        }
        public void CountValue()
        {
            double total = Price * Quantity;
            Console.WriteLine("Total: " + total + "\n");
        }

        public void SearchProduct(List<Product> products, string search)
        {
            Product foundData =  products.Find(p => p.Name.Equals(search));
            if (foundData == null)
                Console.WriteLine("Product not found.");
            else
                Console.WriteLine($"Product found.\n" +
                    $"{foundData.ToString()}");
        }      
    }
}
