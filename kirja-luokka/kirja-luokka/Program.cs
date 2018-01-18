using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirja_luokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book()
            {
                Title = "C#",
                _author = "Masa",
                Id = 111,
                Price = 10
               
            };
            Book book2 = new Book()
            {
                Title = "Java",
                _author = "Pena",
                Id = 222,
                Price = 20
            };

            book.Tiedot();
            book2.Tiedot();

           Console.WriteLine(book.Vertailu(book2));


            



            Console.ReadLine();
        }
    } 
  
    
}
