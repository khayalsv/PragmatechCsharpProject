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
    public class NewController : Controller
    {

        private readonly PortoDbContext dbContext;
        private readonly IWebHostEnvironment env;
        public NewController(PortoDbContext _dbContext, IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            env = _env;
        }

        public IActionResult List()
        {
            return View(dbContext.News.ToList());
        }


        [HttpGet]
        public IActionResult Create()
        {
            New news = new New();
            return View(news);
        }

        [HttpPost]
        public async Task<IActionResult> Create(New news)
        {
            if (!ModelState.IsValid && news.Photo == null)
            {
                ModelState.AddModelError("Photo", "Error [Download image]");
                return View();
            }

            if (!news.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Img format error");
                return View(news);
            }

            string folder = @"img\";
            news.Image = await news.Photo.SaveAsync(env.WebRootPath, folder);

            await dbContext.News.AddAsync(news);
            await dbContext.SaveChangesAsync();

            return Redirect("List");
        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            New news = dbContext.News.Find(id);
            if (news == null)
            {
                return NotFound();
            }
            return View(news);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(New news)
        {
            if (!ModelState.IsValid)
            {
                return View(news);
            }
            var newsDb = dbContext.News.Find(news.ID);
            if (news.Photo != null)
            {
                try
                {
                    string folder = @"img\";
                    var newImg = await news.Photo.SaveAsync(env.WebRootPath, folder);

                    FileExtension.Delete(env.WebRootPath, folder, newsDb.Image);
                    newsDb.Image = newImg;
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Unexpted error happened while save img");
                    return View();

                }
            }
            newsDb.Text = news.Text;
            newsDb.Date = news.Date;
            newsDb.Link = news.Link;

            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/New/List");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            New news = await dbContext.News.FindAsync(id);
            if (news == null) return NotFound();
            dbContext.News.Remove(news);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "New deleted!";
            return Redirect("/Admin/New/List");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            New news = await dbContext.News.FindAsync(id);
            if (news == null) return NotFound();
            return View(news);
        }
    }
}
