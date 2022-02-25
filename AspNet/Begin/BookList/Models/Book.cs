using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Models
{
    public static class imgMODEL
    {
        public static List<Book> images = new List<Book>
        {
            new Book{ID=1,Name="dsasas",Link="1.jpeg"},
            new Book{ID=2,Name="dwdw ve Ceza",Link="2.jpeg"},
            new Book{ID=3,Name="dsafasfsafa addim",Link="3.jpeg"},
        };

        public static List<Book> GetimgItem() => images;

    }

    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }

    }

}
