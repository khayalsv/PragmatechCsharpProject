using KS.Extension;
using KS.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KS.Areas.Admin.Controllers
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

        public IActionResult PortfolioCRUD()
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
            if (!ModelState.IsValid)
            {
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

            return Redirect("PortfolioCRUD");
        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            return View();
        }
    }
}
