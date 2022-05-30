using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            MyContext myContext = new MyContext();
            ViewBag.v1 = myContext.Blogs.Count().ToString();
            ViewBag.v2 = myContext.Blogs.Where(x => x.WriterId == 1).Count();
            ViewBag.v3 = myContext.Categories.Count();
            return View();
        }
    }
}
