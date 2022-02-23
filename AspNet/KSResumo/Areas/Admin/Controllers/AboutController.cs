using KS.Extension;
using KSResumo.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSResumo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {

        private readonly PortoDbContext dbContext;
        private readonly IWebHostEnvironment env;
        public AboutController(PortoDbContext _dbContext, IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            env = _env;
        }

        public IActionResult List()
        {
            return View(dbContext.Abouts.ToList());
        }


        [HttpGet]
        public IActionResult Create()
        {
            About about = new About();
            return View(about);
        }

        [HttpPost]
        public async Task<IActionResult> Create(About about)
        {
            if (!ModelState.IsValid && about.Photo == null)
            {
                ModelState.AddModelError("Photo", "Error [Download image]");
                return View();
            }

            if (!about.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Img format error");
                return View(about);
            }

            string folder = @"img\";
            about.Image = await about.Photo.SaveAsync(env.WebRootPath, folder);

            await dbContext.Abouts.AddAsync(about);
            await dbContext.SaveChangesAsync();

            return Redirect("List");
        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            About about = dbContext.Abouts.Find(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(About about)
        {
            if (!ModelState.IsValid)
            {
                return View(about);
            }
            var aboutDb = dbContext.Abouts.Find(about.ID);
            if (about.Photo != null)
            {
                try
                {
                    string folder = @"img\";
                    var newImg = await about.Photo.SaveAsync(env.WebRootPath, folder);

                    FileExtension.Delete(env.WebRootPath, folder, aboutDb.Image);
                    aboutDb.Image = newImg;
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Unexpted error happened while save img");
                    return View();

                }
            }
            aboutDb.Text = about.Text;
            aboutDb.Name = about.Name;
            aboutDb.Birthday = about.Birthday;
            aboutDb.Age = about.Age;
            aboutDb.Address = about.Address;
            aboutDb.Phone = about.Phone;
            aboutDb.Email = about.Email;


            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/About/List");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            About about = await dbContext.Abouts.FindAsync(id);
            if (about == null) return NotFound();
            dbContext.Abouts.Remove(about);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "About deleted!";
            return Redirect("/Admin/About/List");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            About about = await dbContext.Abouts.FindAsync(id);
            if (about == null) return NotFound();
            return View(about);
        }
    }
}
