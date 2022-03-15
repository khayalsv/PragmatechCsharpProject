using KS.Extension;
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
    public class TestimonialsController : Controller
    {
        private readonly MyContext myContext;
        private readonly IWebHostEnvironment env;

        public TestimonialsController(MyContext myContext,IWebHostEnvironment env)
        {
            this.myContext = myContext;
            this.env = env;
        }
        public IActionResult List()
        {
            return View(myContext.Testimonials.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Testimonials item)
        {
            if (!ModelState.IsValid) return View(item);
          
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

            string folder = @"assets\images\testimonial\";
            item.Image = await item.Photo.SaveAsync(env.WebRootPath, folder);

            await myContext.Testimonials.AddAsync(item);
            await myContext.SaveChangesAsync();

            return Redirect("List");
        }


        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var item = myContext.Testimonials.Find(id);

            if (item == null) return NotFound();

            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Testimonials item)
        {
            if (!ModelState.IsValid) return View(item);

            var list =  myContext.Testimonials.Find(item.ID);

            if (item.Photo != null)
            {
                try
                {
                    string folder = @"assets\images\testimonial\";
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

            list.Name = item.Name;
            list.Text = item.Text;
            list.Company = item.Company;

            await myContext.SaveChangesAsync();

            return Redirect("/Admin/Testimonials/List");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var item = await myContext.Testimonials.FindAsync(id);

            myContext.Testimonials.Remove(item);

            TempData["Success"] = "item deleted!";

            await myContext.SaveChangesAsync();

            return Redirect("/Admin/Testimonials/List");
        }
    }
}
