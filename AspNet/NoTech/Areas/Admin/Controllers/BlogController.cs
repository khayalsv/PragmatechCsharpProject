using KS.Extension;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NoTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class BlogController : Controller
    {
        private readonly MyContext myContext;
        private readonly IWebHostEnvironment env; //image

        public BlogController(MyContext myContext, IWebHostEnvironment env)
        {
            this.myContext = myContext;
            this.env = env;
        }

        [HttpGet]
        public IActionResult List()
        {
            var item = myContext.Blogs.ToList();
            return View(item);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var item = new Blog();
            return View(item);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Blog item)
        {
            if (!ModelState.IsValid) return View(item); //datanin olmadigini yoxluyur

            if (item.Photo == null)
            {
                ModelState.AddModelError("Photo", "Error (Download Image)");
                return View();
            }

            if (!item.Photo.IsImage())    // formatin uygunluyugunu yoxluyur
            {
                ModelState.AddModelError("Photo", "Img format error");
                return View(item);
            }


            string folder = @"assets\images\blog\";
            item.Image = await item.Photo.SaveAsync(env.WebRootPath, folder);

            await myContext.Blogs.AddAsync(item);
            await myContext.SaveChangesAsync();

            return Redirect("List");
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var item = myContext.Blogs.Find(id);

            if (item == null) return NotFound();

            return View(item);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Blog item)
        {
            if (!ModelState.IsValid) return View(item);

            var list = myContext.Blogs.Find(item.ID);

            if (item.Photo != null)
            {
                try
                {
                    string folder = @"assets\images\blog\";
                    var newImg = await item.Photo.SaveAsync(env.WebRootPath, folder);

                    FileExtension.Delete(env.WebRootPath, folder, list.Image);
                    list.Image = newImg;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Unexpted error happened while save img");
                    return View();
                }
            }

            list.Title = item.Title;
            list.DateTime = item.DateTime;
            list.byFrom = item.byFrom;
            list.Name = item.Name;
            list.Link = item.Link;

            await myContext.SaveChangesAsync();
            return Redirect("/Admin/Blog/List");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var item = await myContext.Blogs.FindAsync(id);

            if (item == null) return NotFound();

            myContext.Blogs.Remove(item);
            await myContext.SaveChangesAsync();

            TempData["Success"] = "Item deleted!";

            return Redirect("/Admin/Blog/List");

        }
    }
}
