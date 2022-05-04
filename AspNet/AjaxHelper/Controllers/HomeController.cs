using AjaxHelper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc.Ajax;

namespace AjaxHelper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult GetData()
        {
            List<string> data = new List<string>() { "xeyal", "selimov", "sdsad" };
            
            return View();
        }

    }
}
