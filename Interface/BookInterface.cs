using System;
using System.Collections.Generic;

namespace BookInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book()
            {
                name = "Sherlock",
                genre = Genre.Detective,
                page = 5000,
                author = "Unknown"
            };

            Book book2 = new Book()
            {
                name = "Sefiller",
                genre = Genre.Drams,
                page = 700,
                author = "Viktor.H"
            };

            Library library = new Library();

            //add

            library.Add(book1);
            library.Add(book2);
            //Console.WriteLine(library.books.Count);


            //foreach (var item in library.Filter("Viktor.H",Genre.Drams))
            //{
            //    Console.WriteLine($"{item.name}  {item.author}  {item.genre.ToString()}");
            //}


            //Remove//
            library.Remove("Sherlock");

            foreach (var item in library.books)
            {
                Console.WriteLine($"{item.name}  {item.author}");
            }

            //Showinfo//
            library.ShowInfo("Sefiller");
        }
    }


    ///////////////////////////Methods///////////////////////////////
    class Library : ILibrary
    {
        public List<Book> books { get; set; }
        public Library()
        {
            this.books = new List<Book>();
        }
        public void Add(Book book)
        {
            bool existName = false;

            foreach (var item in books)
            {
                if (item.name.ToLower().Trim()==book.name.ToLower().Trim())
                {
                    existName = true;
                    break;
                     
                }
            }
            if (!existName)
            {
                books.Add(book);
            }
            else
            {
                throw new SomeBookAlreadyAddException("this book exist");
            }
        }

        public List<Book> Filter(string author, Genre genre)
        {
            string nonCapital = author.ToLower().Trim();
            List<Book> filtered = books.FindAll(b => b.author.ToLower().Trim().Equals(nonCapital) && b.genre.Equals(genre));
            return filtered;
        
        }

        public void Remove(string book)
        {
            string removeBook = book.ToLower().Trim();
            Book removeobj = books.Find(x => x.name.ToLower().Trim().Equals(removeBook));
            if (removeobj !=null)
            {
                books.Remove(removeobj);
            }
            else
            {
                throw new BookNotFoundException("Book doesnt exist");
            }
        }

        public List<Book> Search(string searchName)
        {
            string nonCapital = searchName.ToLower().Trim();
            List<Book> searced = books.FindAll(x => x.author.ToLower().Trim().Contains(nonCapital) 
            || x.name.ToLower().Trim().Contains(nonCapital));  
            return searced;

        }

        public void ShowInfo(string bookName)
        {
            Book info = books.Find(n => n.name.ToLower().Trim() == bookName.ToLower().Trim());
            if (info!=null)
            {
                Console.WriteLine($"Book:{info.name} \n Author:{info.author} \n Genre:{info.genre} \n"+ 
                $"Page:{info.page}");
            }
            else
            {
                throw new BookNotFoundException("Book doesnt exist");
            }
        }
    }

    /////////////////Book/////////////////////////
    class Book
    {
        public string name  { get; set; }
        public string author { get; set; }
        public int page { get; set; }

        public Genre genre;
    }
    public enum Genre
    {
        Detective,
        Drams,
        ScienceFaiction
    }


    ////////////////Interface///////////////////
    interface ILibrary
    {
        public List <Book> books { get; set; }
        public void Add(Book book);
        public void ShowInfo(string bookName);
        public List<Book> Search(string searchName);
        public List<Book> Filter(string author, Genre genre);
        public void Remove(string book);
    }

    //////////////////Exception////////////////////////
    class BookNotFoundException:Exception
    {
        public string message;
        public BookNotFoundException(string message)
        {
            this.message = message;
        }
        public override string Message => message;
    }

    class SomeBookAlreadyAddException : Exception
    {
        public string message;
        public SomeBookAlreadyAddException(string message)
        {
            this.message = message;
        }
        public override string Message => message;
    }
}
