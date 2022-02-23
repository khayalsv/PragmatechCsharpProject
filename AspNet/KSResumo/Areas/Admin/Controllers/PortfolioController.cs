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
    public class PortfolioController : Controller
    {

        private readonly PortoDbContext dbContext;
        private readonly IWebHostEnvironment env;
        public PortfolioController(PortoDbContext _dbContext, IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            env = _env;
        }

        public IActionResult List()
        {
            return View(dbContext.Portfolios.ToList());
        }


        [HttpGet]
        public IActionResult Create()
        {
            Portfolio portfolio = new Portfolio();
            return View(portfolio);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Portfolio portfolio)
        {
            if (!ModelState.IsValid && portfolio.Photo == null)
            {
                ModelState.AddModelError("Photo", "Error [Download image]");
                return View();
            }

            if (!portfolio.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Img format error");
                return View(portfolio);
            }

            string folder = @"img\";
            portfolio.Image = await portfolio.Photo.SaveAsync(env.WebRootPath, folder);

            await dbContext.Portfolios.AddAsync(portfolio);
            await dbContext.SaveChangesAsync();

            return Redirect("List");
        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Portfolio portfolio = dbContext.Portfolios.Find(id);
            if (portfolio == null)
            {
                return NotFound();
            }
            return View(portfolio);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Portfolio portfolio)
        {
            if (!ModelState.IsValid)
            {
                return View(portfolio);
            }
            var portfolioDb = dbContext.Portfolios.Find(portfolio.ID);
            if (portfolio.Photo != null)
            {
                try
                {
                    string folder = @"img\";
                    var newImg = await portfolio.Photo.SaveAsync(env.WebRootPath, folder);

                    FileExtension.Delete(env.WebRootPath, folder, portfolioDb.Image);
                    portfolioDb.Image = newImg;
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Unexpted error happened while save img");
                    return View();

                }
            }
            portfolioDb.Name = portfolio.Name;
            portfolioDb.Link = portfolio.Link;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/Portfolio/List");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Portfolio portfolio = await dbContext.Portfolios.FindAsync(id);
            if (portfolio == null) return NotFound();
            dbContext.Portfolios.Remove(portfolio);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Portfolio deleted!";
            return Redirect("/Admin/Portfolio/List");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Portfolio portfolio = await dbContext.Portfolios.FindAsync(id);
            if (portfolio == null) return NotFound();
            return View(portfolio);
        }
    }
}
