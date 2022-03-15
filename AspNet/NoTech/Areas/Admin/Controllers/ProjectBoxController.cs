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
    public class ProjectBoxController : Controller
    {
        private readonly MyContext myContext;
        private readonly IWebHostEnvironment env;

        public ProjectBoxController(MyContext myContext, IWebHostEnvironment env)
        {
            this.myContext = myContext;
            this.env = env;
        }

        public IActionResult List()
        {
            return View(myContext.ProjectBoxes.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProjectBox item)
        {
            if (!ModelState.IsValid) return NotFound();

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


            string folder = @"assets\images\project\";
            item.Image = await item.Photo.SaveAsync(env.WebRootPath, folder);

            await myContext.ProjectBoxes.AddAsync(item);
            await myContext.SaveChangesAsync();

            return Redirect("List");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var item = myContext.ProjectBoxes.Find(id);

            if (item == null) return NotFound();

            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProjectBox item)
        {
            if (!ModelState.IsValid) return View(item);

            var list = await myContext.ProjectBoxes.FindAsync(item.ID);

            if (item.Photo != null)
            {
                try
                {
                    string folder = @"assets\images\project\";
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

            list.Link = item.Link;
            list.Name1 = item.Name1;
            list.Name2 = item.Name2;
            list.TopTitle = item.TopTitle;
            list.BoxTitle = item.BoxTitle;

            await myContext.SaveChangesAsync();

            return Redirect("/Admin/ProjectBox/List");
        }

        public async Task<IActionResult> Delete (int? id)
        {
            if (id == null) return NotFound();

            var item = await myContext.ProjectBoxes.FindAsync(id);

            myContext.ProjectBoxes.Remove(item);

            await myContext.SaveChangesAsync();
            
            TempData["Success"] = "Item deleted!";

            return Redirect("/Admin/ProjectBox/List");
        }
    }
}
