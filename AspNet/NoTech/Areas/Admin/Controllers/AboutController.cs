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
    public class AboutController : Controller
    {
        private readonly MyContext myContext;
        private readonly IWebHostEnvironment env;

        public AboutController(MyContext myContext, IWebHostEnvironment env)
        {
            this.myContext = myContext;
            this.env = env;
        }

        public IActionResult List()
        {
            return View(myContext.Abouts.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            var item = new About();
            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create(About item)
        {
            if (!ModelState.IsValid) return View(item);
            
            if (item.Photo1 == null || item.Photo2 == null)
            {
                ModelState.AddModelError("Photo", "Please download image");
                return View();
            }



            if (!item.Photo1.IsImage() || !item.Photo2.IsImage())
            {
                ModelState.AddModelError("Photo", "Image format error");
                return View();
            }


            string folder = @"assets\images\resources\";
            item.Image1 = await item.Photo1.SaveAsync(env.WebRootPath, folder);
            item.Image2 = await item.Photo2.SaveAsync(env.WebRootPath, folder);

            

            await myContext.AddAsync(item);
            await myContext.SaveChangesAsync();

            return Redirect("List");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var list = myContext.Abouts.Find(id);
          
            if (list == null) return NotFound();

            return View(list);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(About item)
        {
            if (!ModelState.IsValid) return View(item);

            var list = myContext.Abouts.Find(item.ID);

            if (item.Photo1 != null)
            {
                try
                {
                    string folder = @"assets\images\resources\";
                    var newImg1 = await item.Photo1.SaveAsync(env.WebRootPath, folder);

                    FileExtension.Delete(env.WebRootPath, folder, list.Image1);
                    list.Image1 = newImg1;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Unexpted error happened while save img");
                    return View();
                }
            }

            if (item.Photo2 != null)
            {
                try
                {
                    string folder = @"assets\images\resources\";
                    var newImg2 = await item.Photo2.SaveAsync(env.WebRootPath, folder);

                    FileExtension.Delete(env.WebRootPath, folder, list.Image2);
                    list.Image2 = newImg2;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Unexpted error happened while save img");
                    return View();
                }
            }

            list.Title = item.Title;
            list.Text = item.Text;
            list.List = item.List;
            list.Subheading = item.Subheading;

            await myContext.SaveChangesAsync();
            return Redirect("/Admin/About/List");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var item = await myContext.Abouts.FindAsync(id);

            if (item == null) return NotFound();

            myContext.Abouts.Remove(item);
            await myContext.SaveChangesAsync();

            TempData["Success"] = "Item deleted!";

            return Redirect("/Admin/About/List");
        }


    }
}
