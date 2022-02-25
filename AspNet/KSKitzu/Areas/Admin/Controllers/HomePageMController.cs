using KS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KS.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomePageMController : Controller
    {

        private readonly PortoDbContext dbContext;
        public HomePageMController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult HomeList()
        {
            return View(dbContext.HomePageMs.ToList());
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
