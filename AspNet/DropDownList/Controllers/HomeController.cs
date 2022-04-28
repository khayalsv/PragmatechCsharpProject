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

        public ActionResult Index()
        {

            IndexViewModel indexViewModel = new IndexViewModel()
            {
                CitiesData = new SelectList(City.GetFakeCities(), "CityId", "CityName"),
                CountriesData = new SelectList(Country.GetFakeCountries(), "CountryId", "CountryName"),
                SelectedCityId = -1,
                SelectedCountryId = -1
            };

            return View(indexViewModel);
        }



        [HttpPost]
        public ActionResult Index(IndexViewModel indexViewModel)
        {
            indexViewModel.CitiesData = new SelectList(City.GetFakeCities(), "CityId", "CityName");
            indexViewModel.CountriesData = new SelectList(Country.GetFakeCountries(), "CountryId", "CountryName");

            return View(indexViewModel);
        }

        public JsonResult GetCitiesByCountry(int id)
        {
            int countryId = id;

            List<City> result = City.GetFakeCities().Where(x => x.CountryId == countryId).ToList();


            //return Json(result, System.Web.Mvc.JsonRequestBehavior.AllowGet);

            return Json(result);
        }
    }
}
