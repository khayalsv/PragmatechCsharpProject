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
            MyContext _myContext = new MyContext();
            var username = User.Identity.Name; //identity ile sisteme authentication ile adin cekir
            var usermail = _myContext.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault(); //usermaille deyerini cekir
            var writerId = _myContext.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();

            ViewBag.v1 = _myContext.Blogs.Count().ToString();
            ViewBag.v2 = _myContext.Blogs.Where(x => x.WriterId == writerId).Count();
            ViewBag.v3 = _myContext.Categories.Count();
            return View();
        }
    }
}
