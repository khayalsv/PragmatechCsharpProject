using KS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KS.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
       
        private readonly PortoDbContext dbContext;
        public BlogController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult BlogCRUD()
        {
            return View(dbContext.Blogs.ToList());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormFile photo, string title,string text,string date)
        {
            Blog blog = new Blog
            {
                Title = title,
                Text=text,
                Date=date,
                Image = photo.FileName
            };
            dbContext.Blogs.Add(blog);
            dbContext.SaveChanges();

            return Redirect("BlogCRUD");
        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            return View();
        }
    }
}
