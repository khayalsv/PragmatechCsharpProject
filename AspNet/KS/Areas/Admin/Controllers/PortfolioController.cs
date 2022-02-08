using KS.Models;
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
        public PortfolioController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult CRUD()
        {
            return View(dbContext.Portfolios.ToList());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormFile photo, string name)
        {
            Portfolio portfolio = new Portfolio
            {
                Name=name,
                Image = photo.FileName
            };
            dbContext.Portfolios.Add(portfolio);
            dbContext.SaveChanges();

            return Redirect("CRUD");
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
