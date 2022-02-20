using KS.Extension;
using KS.Models;
using Microsoft.AspNetCore.Hosting;
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
        private readonly IWebHostEnvironment env;
        public BlogController(PortoDbContext _dbContext,IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            env = _env;
        }

        public IActionResult BlogCRUD()
        {
            return View(dbContext.Blogs.ToList());
        }


        [HttpGet]
        public IActionResult Create()
        {
            Blog blog = new Blog();
            return View(blog);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            //if (blog.Photo==null)
            //{
            //    ModelState.AddModelError("Photo", "Error [Download image]");
            //}

            if (!blog.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Img format error");
                return View(blog);
            }

            string folder = @"img\";
            blog.Image = await blog.Photo.SaveAsync(env.WebRootPath, folder);

            await dbContext.Blogs.AddAsync(blog);
            await dbContext.SaveChangesAsync();

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
