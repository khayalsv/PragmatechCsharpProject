using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleTemplate.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly PortoDbContext dbContext;
        public HomeController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult HomePage()
        {
           var category = dbContext.Categories.ToList();

            return View(category);
        }

        public IActionResult AboutPage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
