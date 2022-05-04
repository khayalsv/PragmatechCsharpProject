using ApplicationStatement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationStatement.Controllers
{
    public class HomeController : Controller
    {
        const string text = "deyer";
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32(text, 1);

            return View();
        }

        public IActionResult Index2()
        {
            ViewBag.Deyer = HttpContext.Session.GetInt32(text).ToString();

            return View();
        }

        public IActionResult Index3()
        {
            int deyer = (int)HttpContext.Session.GetInt32(text);

            deyer++;

            HttpContext.Session.SetInt32(text,deyer);

            return RedirectToAction("index2");
        }
    }
}
