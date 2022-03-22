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

    public class HelpingController : Controller
    {
        private readonly MyContext myContext;
        private readonly IWebHostEnvironment env; //image

        public HelpingController(MyContext myContext, IWebHostEnvironment env)
        {
            this.myContext = myContext;
            this.env = env;
        }

        [HttpGet]
        public IActionResult List()
        {
            var item = myContext.Helpings.ToList();
            return View(item);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var item = new Helping();
            return View(item);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Helping item)
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


            string folder = @"assets\images\backgrounds\";
            item.Image = await item.Photo.SaveAsync(env.WebRootPath, folder);

            await myContext.Helpings.AddAsync(item);
            await myContext.SaveChangesAsync();

            return Redirect("List");
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var item = myContext.Helpings.Find(id);

            if (item == null) return NotFound();

            return View(item);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Helping item)
        {
            if (!ModelState.IsValid) return View(item);

            var list = myContext.Helpings.Find(item.ID);

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
            list.Icon = item.Icon;
            list.SubTitle = item.SubTitle;
            list.SubText = item.SubText;

            await myContext.SaveChangesAsync();
            return Redirect("/Admin/Helping/List");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var item = await myContext.Helpings.FindAsync(id);

            if (item == null) return NotFound();

            myContext.Helpings.Remove(item);
            await myContext.SaveChangesAsync();

            TempData["Success"] = "Item deleted!";

            return Redirect("/Admin/Helping/List");

        }
    }
}
