using System;

namespace Repaet2
{
    class Program
    {
        class Book
        {
            public string name { get; set; }
            public string author { get; set; }
            public int page { get; set; }
            public string code { get; set; }
            public static int id = 100;

            public Book(string name)
            {
                this.name = name;
                string x = name.Substring(0, 2);
                code = x + id;
            }


            static void Main(string[] args)
            {
                Book books = new Book("Cinayet ve ceza")
                {         
                    author = "Dostoyevski",
                    page = 700
                };
                Console.WriteLine($"{books.code} {books.name} {books.author} {books.page}");
            }
        }
    }
}