using System;
using System.Collections.Generic;

namespace inLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            BOOK book = new BOOK("Sefiller", "Viktor", 253);
            BOOK book2 = new BOOK("Metamarfoz", "Franz", 125);            

            Library library = new Library();
            library.books = new List<BOOK> { book, book2};


            library.FindBook("Sefiller");

            foreach (var item in library.FindBook2("Sefiller"))
            {
                Console.WriteLine(item.author);
            }

        }
    }
    public class BOOK
    {
        public string name;
        public string author;
        public int page;
        public string code;
        public static int no;


        public BOOK(string name, string author, int page)
        {
            this.name = name;
            this.author = author;
            this.page = page;

            string x = name.Substring(0, 2);
            no++;
            code = x + no;

        }
    }

    public class Library
    {
        public List<BOOK> books = new List<BOOK>();


        public void FindBook(string name)
        {
            foreach (var item in books)
            {
               if (item.name == name)
               {
                    
                    Console.WriteLine(item.author);
               }
            }
        }
        public List<BOOK> FindBook2(string name)
        {
            List<BOOK> allbook = new List<BOOK>(); ;
            foreach (var item in books)
            {
                if (item.name == name)
                {
                   allbook.Add(item);
                }
            }
            return allbook;
        }


        #region

        //public void RemoveBook(string name)
        //{
        //    foreach (var item in books)
        //    {
        //        if (item.name == name)
        //        {
        //            books.Remove(item);
        //            Console.WriteLine(item.name);
        //        }
        //    }
        //}

      

        //public List<BOOK> RemoveNo(string code)
        //{
        //    foreach (var item in books)
        //    {
        //        if (item.code == code)
        //        {
        //            books.Remove(item);
        //        }
        //    }
        //    return books;
        //}
        #endregion
    }

}
    



   

