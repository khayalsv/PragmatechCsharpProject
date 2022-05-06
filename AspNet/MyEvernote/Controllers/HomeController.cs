using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyEvernote.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvernote.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            BusinessLayer.Test test = new BusinessLayer.Test();

            return View();
        }
    }
}
