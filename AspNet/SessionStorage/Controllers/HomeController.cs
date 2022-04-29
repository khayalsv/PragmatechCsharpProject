using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SituationManagment.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SituationManagment.Controllers
{
    public class HomeController : Controller
    {
        const string text = "_Name";
        public IActionResult Index()
        {
            HttpContext.Session.SetString(text, "Khayal");
            return RedirectToAction("index2");
        }

        //[HttpPost]
        //public IActionResult Index(string text)
        //{
        //    HttpContext.Session.SetString(text, "deyer");
        //    return View();
        //}

        public IActionResult Index2()
        {
            if (HttpContext.Session.GetString(text) != null)
            {
                ViewBag.Deyer = HttpContext.Session.GetString(text).ToString();
            }
            else
            {
                ViewBag.Deyer = "Deyer yoxdu";
            }
            return View();
        }

        public IActionResult Index3()
        {
            if (HttpContext.Session.GetString(text) != null)
            {
                HttpContext.Session.Remove(text);
            }

            return RedirectToAction("index2");
        }



    }
}
