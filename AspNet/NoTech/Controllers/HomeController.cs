using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NoTech.Models;
using NoTech.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyContext myContext;

        public HomeController(MyContext myContext)
        {
            this.myContext = myContext;
        }

        public async Task<IActionResult> Index()
        {
            var vM = new ALLVM
            {
                homes = await myContext.Homes.ToListAsync()
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
