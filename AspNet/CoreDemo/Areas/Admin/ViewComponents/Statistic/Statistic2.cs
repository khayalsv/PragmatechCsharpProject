
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2 : ViewComponent
    {
        MyContext _myContext = new MyContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _myContext.Blogs.OrderByDescending(x => x.Id).Select(x=>x.Title).Take(1).FirstOrDefault();

            return View();
        }
    }
}
