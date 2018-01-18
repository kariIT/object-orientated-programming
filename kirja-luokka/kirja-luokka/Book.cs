using System;

namespace kirja_luokka
{
    class Book
    {
        // Muuttujat
        public string Title;
        public string _author;
        public int Id;
        public double Price;

        // Konstruktori
        public Book()
        {
            Title = "Ei tietoa";
            _author = "xxxx";
            Id = 123;
            Price = 10;
        }

        public Book(string title, string author, int id, double price)
        {
            title = Title;
            author = _author;
            id = Id;
            price = Price;

        }

        // Metodit
        public void Tiedot()
        {
            Console.WriteLine("Kirjan nimi: " + Title);
            Console.WriteLine("Kijoittanut: " + _author);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Hinta: " + Price);
            Console.Write("\n");


        }
        public string Vertailu(Book book)
        {

            if (this.Price > book.Price)
                return $"{this.Title} on kalliimpi kuin {book.Title} kirja";

            else if (this.Price < book.Price)
                return $"{book.Title} on kalliimpi kuin {this.Title} kirja";

            else
                return "Vertailu epäonnistui. ";

        }

    }
}
