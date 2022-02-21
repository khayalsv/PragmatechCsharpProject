using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SampleTemplate.Models;
using SampleTemplate.ViewModels;
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

        public async Task<IActionResult> HomePage()
        {
            //var slider = dbContext.Sliders.ToList();

            HomeVM vM = new HomeVM
            {
                Sliders = await dbContext.Sliders.ToListAsync(),
            };

            return View(vM);
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
