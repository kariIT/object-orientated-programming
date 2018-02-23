using System;
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
            return $"{Name}, {Price}, {Quantity}";
        }

        public void GetProduct()
        {
            Console.Write("Hae tuotetta: ");
            string haku = Console.ReadLine();

            if (haku == Name)
                Console.WriteLine("Haku onnistui.");
            else
                Console.WriteLine("Haku epäonnistui.");
        }

        public void CountValue()
        {
            double total = Price * Quantity;
            Console.WriteLine("Total: " + total);
        }
        
        
    }
}
