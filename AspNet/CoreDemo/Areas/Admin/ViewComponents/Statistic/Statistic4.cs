using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4 : ViewComponent
    {
        MyContext _myContext = new MyContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _myContext.Admins.Where(x => x.Id == 1).Select(y => y.Name).FirstOrDefault();
            ViewBag.v2 = _myContext.Admins.Where(x => x.Id == 1).Select(y => y.ImageUrl).FirstOrDefault();
            return View();
        }
    }
}
