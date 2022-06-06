using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller  //identity problemi 132ders
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        MyContext _myContext = new MyContext();
        public IActionResult InBox()
        {
            
            var username = User.Identity.Name;
            var usermail = _myContext.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = _myContext.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();

               var values = mm.GetInboxListByWriter(writerId);
               return View(values);
            
        }

        public IActionResult MessageDetails(int id)
        {
            var value = mm.TGetById(id);
            return View(value);
        }



        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message2 p)
        {
            var username = User.Identity.Name;
            var usermail = _myContext.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = _myContext.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();
            p.SenderId = writerId;
            p.ReceiverId = 3;
            p.Status = true;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            mm.TAdd(p);
            return RedirectToAction("InBox");
        }
    }
}
