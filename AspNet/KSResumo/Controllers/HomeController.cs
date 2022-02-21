using KSResumo.Models;
using KSResumo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KSResumo.Controllers
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
            HomeVM vM = new HomeVM
            {
                Homes =await dbContext.Homes.ToListAsync()
            };

            return View(vM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
