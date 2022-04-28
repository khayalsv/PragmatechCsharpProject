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
      

        const string SessionName = "_Name";
        const string SessionAge = "_Age";
        public IActionResult Index()
        {
            HttpContext.Session.SetString(SessionName, "Jarvik");
            HttpContext.Session.SetInt32(SessionAge, 24);
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(string text)
        //{
        //    HttpContext.Session.SetString(text, "deyer");
        //    return View();
        //}

        public IActionResult Index2()
        {
            ViewBag.Deyer = HttpContext.Session.GetString(SessionName).ToString();
            ViewBag.Age = HttpContext.Session.GetInt32(SessionAge);
            return View();
        }

    
    }
}
