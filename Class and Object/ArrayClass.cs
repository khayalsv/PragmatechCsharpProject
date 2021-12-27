using System;

namespace _inLesson
{

    class Program
    {
        static void Main(string[] args)
        {

            Book[] list = new Book[2];
            Book list1 = new Book("melikmemmedin nagili", "dede qorqud", 500);
            Book list2 = new Book("cirtdan", "dede qorqud 2", 600);
            list[0] = list1;
            list[1] = list2;
            foreach (var item in list)
            {
                Console.WriteLine(item.code);
            }



        }
    }
    class Book
    {
        public string name;
        public string author;
        public int page;
        public string code;
        public static int no = 1000;


        public Book(string name, string author, int page)
        {
            this.name = name;
            this.author = author;
            this.page = page;

            string x = name.Substring(0, 2);
            no++;
            code = x + no;

        }

    }
}
