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

        public IActionResult List()
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
            if (!ModelState.IsValid && blog.Photo == null)
            {
                ModelState.AddModelError("Photo", "Error [Download image]");
                return View();
            }

            if (!blog.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Img format error");
                return View(blog);
            }

            string folder = @"img\";
            blog.Image = await blog.Photo.SaveAsync(env.WebRootPath, folder);

            await dbContext.Blogs.AddAsync(blog);
            await dbContext.SaveChangesAsync();

            return Redirect("List");
        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Blog blog = dbContext.Blogs.Find(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Blog blog)
        {
            if (!ModelState.IsValid)
            {
                return View(blog);
            }
            var blogDb = dbContext.Blogs.Find(blog.ID);
            if (blog.Photo != null)
            {
                try
                {
                    string folder = @"img\";
                    var newImg = await blog.Photo.SaveAsync(env.WebRootPath, folder);

                    FileExtension.Delete(env.WebRootPath, folder, blogDb.Image);
                    blogDb.Image = newImg;
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Unexpted error happened while save img");
                    return View();

                }
            }
            blogDb.Text = blog.Text;
            blogDb.Title = blog.Title;
            blogDb.Date = blog.Date;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/Blog/List");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = await dbContext.Blogs.FindAsync(id);
            if (blog == null) return NotFound();
            dbContext.Blogs.Remove(blog);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Blog deleted!";
            return Redirect("/Admin/Blog/List");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = await dbContext.Blogs.FindAsync(id);
            if (blog == null) return NotFound();
            return View(blog);
        }
    }
}
