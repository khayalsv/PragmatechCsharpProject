using KS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Relation.Models;
using Relation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Controllers
{
    public class AuthorController : Controller
    {
        private readonly PortoDbContext dbContext;

        public AuthorController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult List()
        {
            var bookList = dbContext.BOOK.Include(x => x.Authors).ToList();

            return View(bookList);
        }

        public IActionResult Create()
        {
            ViewBag.AUTHORBAG = dbContext.AUTHOR.ToList();
            Book book = new Book();
            return View(book);
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AUTHORBAG = dbContext.AUTHOR.ToList();
                return View(book);
            } 
            dbContext.BOOK.Add(book);
            dbContext.SaveChanges();

            return Redirect("/Author/List");
        }

        public IActionResult CreateAuthor()
        {
            Author author = new Author();
            return View(author);
        }

        [HttpPost]
        public IActionResult CreateAuthor(Author author)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            dbContext.AUTHOR.Add(author);
            dbContext.SaveChanges();
            return Redirect("/Author/Create");

        }


        public IActionResult Edit(int? id)
        {
            ViewBag.AUTHORBAG = dbContext.AUTHOR.ToList();
            if (id==null)
            {
                return NotFound();
            }

            var book = dbContext.BOOK.FirstOrDefault(x => x.ID == id);

            if (book==null)
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {

            if (!ModelState.IsValid)
            {
                ViewBag.AUTHORBAG = dbContext.AUTHOR.ToList();
                return NotFound();
            }

            var bookDb = dbContext.BOOK.First(x => x.ID == book.ID);
            bookDb.BookName = book.BookName;
            bookDb.AuthorID = book.AuthorID;
            bookDb.Page = book.Page;

            dbContext.SaveChanges();
            return Redirect("/Author/List");
        }

        public IActionResult Delete(int? id)
        {
            if (id==null) 
            {
                return NotFound();
            }

            Book book = dbContext.BOOK.Find(id);
            if (book==null)
            {
                return NotFound();
            }
            dbContext.BOOK.Remove(book);
            dbContext.SaveChanges();
            return Redirect("/Author/List");

        }

        public IActionResult Details(int? id)
        {
            if (id==null)
            {
                return NotFound();

            }
            var bookList = dbContext.BOOK.Include(x => x.Authors).ToList();

            if (bookList == null) 
            {
                return NotFound();
            }
            return View(bookList);

        }



    }
}
