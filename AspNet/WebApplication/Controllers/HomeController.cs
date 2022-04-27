using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.SelectCountryId = -1;
            ViewBag.SelectCityId = -1;

            ViewBag.CitiesData = new SelectList(City.GetFakeCities(), "Id", "Name");
            ViewBag.CountryData = new SelectList(Country.GetFakeContries(), "Id", "Name");

            return View();
        }


        [HttpPost]
        public IActionResult Index(int SelectCityId, int SelectCountryId)
        {
            ViewBag.SelectCountryId = SelectCountryId;
            ViewBag.SelectCityId = SelectCityId;

            ViewBag.CitiesData = new SelectList(City.GetFakeCities(), "Id", "Name");
            ViewBag.CountryData = new SelectList(Country.GetFakeContries(), "Id", "Name");

            return View();
        }

        public IActionResult Privacy()
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
