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
    public class HomePController : Controller
    {

        private readonly PortoDbContext dbContext;
        private readonly IWebHostEnvironment env;
        public HomePController(PortoDbContext _dbContext, IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            env = _env;
        }

        public IActionResult List()
        {
            return View(dbContext.Homes.ToList());
        }


        [HttpGet]
        public IActionResult Create()
        {
            Home home = new Home();
            return View(home);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Home home)
        {
            if (!ModelState.IsValid && home.Photo == null)
            {
                ModelState.AddModelError("Photo", "Error [Download image]");
                return View();
            }

            if (!home.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Img format error");
                return View(home);
            }

            string folder = @"img\";
            home.Image = await home.Photo.SaveAsync(env.WebRootPath, folder);

            await dbContext.Homes.AddAsync(home);
            await dbContext.SaveChangesAsync();

            return Redirect("List");
        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Home home = dbContext.Homes.Find(id);
            if (home == null)
            {
                return NotFound();
            }
            return View(home);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Home home)
        {
            if (!ModelState.IsValid)
            {
                return View(home);
            }
            var homeDb = dbContext.Homes.Find(home.ID);
            if (home.Photo != null)
            {
                try
                {
                    string folder = @"img\";
                    var newImg = await home.Photo.SaveAsync(env.WebRootPath, folder);

                    FileExtension.Delete(env.WebRootPath, folder, homeDb.Image);
                    homeDb.Image = newImg;
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Unexpted error happened while save img");
                    return View();

                }
            }
            homeDb.Text = home.Text;
            homeDb.Title = home.Title;
            homeDb.HolderTitle = home.HolderTitle;
            homeDb.Tag1 = home.Tag1;
            homeDb.Tag2 = home.Tag2;
            homeDb.Tag3 = home.Tag3;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/HomePageM/List");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Home home = await dbContext.Homes.FindAsync(id);
            if (home == null) return NotFound();
            dbContext.Homes.Remove(home);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Home deleted!";
            return Redirect("/Admin/HomePageM/List");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Home home = await dbContext.Homes.FindAsync(id);
            if (home == null) return NotFound();
            return View(home);
        }
    }
}
