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

    public class ServicesTitleController : Controller
    {
        private readonly MyContext myContext;
        private readonly IWebHostEnvironment env;

        public ServicesTitleController(MyContext myContext, IWebHostEnvironment env)
        {
            this.myContext = myContext;
            this.env = env;
        }
        public IActionResult List()
        {
            return View(myContext.ServicesTitles.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ServicesTitle item)
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

            string folder = @"assets\images\backgrounds\";
            item.Image = await item.Photo.SaveAsync(env.WebRootPath, folder);

            await myContext.ServicesTitles.AddAsync(item);
            await myContext.SaveChangesAsync();

            return Redirect("/Admin/ServicesTitle/List");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var item = myContext.ServicesTitles.Find(id);

            if (id == null) return NotFound();

            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ServicesTitle item)
        {
            if (!ModelState.IsValid) return View(item);

            var list = myContext.ServicesTitles.Find(item.ID);

            if (item.Photo != null)
            {
                try
                {
                    string folder = @"assets\images\backgrounds\";
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
            list.Text = item.Text;
            list.SubTitle1 = item.SubTitle1;
            list.SubTitle2 = item.SubTitle2;

            await myContext.SaveChangesAsync();
            return Redirect("/Admin/ServicesTitle/List");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var item = await myContext.ServicesTitles.FindAsync(id);

            myContext.ServicesTitles.Remove(item);

            TempData["Success"] = "item deleted!";

            await myContext.SaveChangesAsync();
       
            return Redirect("/Admin/ServicesTitle/List");
        }
    }
}
