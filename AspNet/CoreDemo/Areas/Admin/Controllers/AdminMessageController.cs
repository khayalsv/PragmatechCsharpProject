using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminMessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        MyContext _myContext = new MyContext();
        public IActionResult Inbox()
        {
            var username = User.Identity.Name;
            var usermail = _myContext.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = _myContext.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();

            var values = mm.GetInboxListByWriter(writerId);
            return View(values);
        }
    }
}
