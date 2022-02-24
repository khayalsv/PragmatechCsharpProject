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
    public class SocialController : Controller
    {

        private readonly PortoDbContext dbContext;
        private readonly IWebHostEnvironment env;
        public SocialController(PortoDbContext _dbContext, IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            env = _env;
        }

        public IActionResult List()
        {
            return View(dbContext.Socials.ToList());
        }


        [HttpGet]
        public IActionResult Create()
        {
            Social social = new Social();
            return View(social);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Social social)
        {

            await dbContext.Socials.AddAsync(social);
            await dbContext.SaveChangesAsync();

            return Redirect("List");
        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Social social = dbContext.Socials.Find(id);
            if (social == null)
            {
                return NotFound();
            }
            return View(social);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Social social)
        {
            if (!ModelState.IsValid)
            {
                return View(social);
            }
            var socialDb = dbContext.Socials.Find(social.ID);

            socialDb.Twitter = social.Twitter;
            socialDb.Facebook = social.Facebook;
            socialDb.Instagram = social.Instagram;

            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/Social/List");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Social social = await dbContext.Socials.FindAsync(id);
            if (social == null) return NotFound();
            dbContext.Socials.Remove(social);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Social deleted!";
            return Redirect("/Admin/Social/List");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Social social = await dbContext.Socials.FindAsync(id);
            if (social == null) return NotFound();
            return View(social);
        }
    }
}
