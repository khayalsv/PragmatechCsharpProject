using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
using WebApplication.ViewModels;

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

            var indexViewModel = new IndexViewModel()
            {
                CitiesData = new SelectList(City.GetFakeCities(), "Id", "Name"),
                CountryData = new SelectList(Country.GetFakeContries(), "Id", "Name"),
                SelectCityId = -1,
                SelectCountryId = -1
            };

            return View(indexViewModel);
        }


        [HttpPost]
        public IActionResult Index(IndexViewModel indexViewModel)
        {
            indexViewModel.CitiesData = new SelectList(City.GetFakeCities(), "Id", "Name");
            indexViewModel.CountryData = new SelectList(Country.GetFakeContries(), "Id", "Name");

            return View(indexViewModel);
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
