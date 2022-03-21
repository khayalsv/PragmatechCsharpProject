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
    public class FeatureController : Controller
    {
        private readonly MyContext myContext;
        private readonly IWebHostEnvironment env;

        public FeatureController(MyContext myContext, IWebHostEnvironment env)
        {
            this.myContext = myContext;
            this.env = env;
        }
        public IActionResult List()
        {
            return View(myContext.Features.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            var item = new Feature();
            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Feature item)
        {
            if (!ModelState.IsValid) return View(item);

            if (item.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please download image");
                return View();
            }

            if (!item.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Image format error");
                return View();
            }

            string folder = @"assets\images\resources\";
            item.Image = await item.Photo.SaveAsync(env.WebRootPath, folder);

            await myContext.Features.AddAsync(item);
            await myContext.SaveChangesAsync();

            return Redirect("List");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var item = myContext.Features.Find(id);

            if (item == null) return NotFound();

            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Feature item)
        {
            if (!ModelState.IsValid) return View(item);

            var list = myContext.Features.Find(item.ID);

            if (item.Photo != null)
            {
                try
                {
                    string folder = @"assets\images\resources\";
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

            list.Icon = item.Icon;
            list.Title = item.Title;
            list.Text = item.Text;
            list.Link = item.Link;

            await myContext.SaveChangesAsync();
            return Redirect("/Admin/Feature/List");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id==null) return NotFound();

            var item = await myContext.Features.FindAsync(id);

            if (item == null) return NotFound();

            myContext.Features.Remove(item);
            await myContext.SaveChangesAsync();

            TempData["Success"] = "Item deleted!";

            return Redirect("/Admin/Feature/List");
        }
    }
}
