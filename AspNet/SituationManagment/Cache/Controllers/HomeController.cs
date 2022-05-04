using Cache.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Cache.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMemoryCache memoryCache;

        public HomeController(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }

        public IActionResult Index()
        {
            memoryCache.Set("name", "Khayal Salimov",new TimeSpan(0,0,10));

            return View();
        }

        public IActionResult Index2()
        {
            memoryCache.Set("name", "Khayal Salimov", new TimeSpan(0, 0, 10));

            return View();
        }


    }
}
