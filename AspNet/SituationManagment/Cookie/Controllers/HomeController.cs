using Cookie.Models;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Cookie.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            HttpContext.Response.Cookies.Append("name", "Khayal");

            return View();
        }

        public IActionResult Index2()
        {
            if (HttpContext.Request.Cookies["name"] != null)
            {
                ViewBag.Name = HttpContext.Request.Cookies["name"].ToString();
            }
            else
            {
                ViewBag.Name = "Cookie yoxdur";

            }
            return View();
        }
        //public IActionResult Index3()
        //{
        //    if (HttpContext.Request.Cookies["name"] != null)
        //    {
        //        //Response.Cookies.Delete("name");
        //        HttpContext.Response.Cookies["name"].Expires = DateTime.Now.AddSeconds(2);
        //    }

        //    return RedirectToAction("index2");
        //}

        

    }
}
