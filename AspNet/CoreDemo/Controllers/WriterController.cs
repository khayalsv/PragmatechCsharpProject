using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public WriterController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        public IActionResult WriterMail()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }

        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public async Task<IActionResult> WriterEditProfile()   //(hell olundu yenede baxilmalidi)   //oz alternatif versiyonuna baxilmalidi identityden melumat cekmek ucun  //129d
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            var model = new UserUpdateViewModel();

            model.Email = values.Email;
            model.NameSurname = values.NameSurname;
            model.ImageUrl = values.ImageUrl;
            model.Username = values.UserName;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(UserUpdateViewModel model)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.Email = model.Email;
            values.NameSurname = model.NameSurname;
            values.ImageUrl = model.ImageUrl;
            values.UserName = model.Username;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.Password);
            var result = await _userManager.UpdateAsync(values);
            return RedirectToAction("Index", "Dashboard");

        }


        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if (p.Image !=null)
            {
                var extension = Path.GetExtension(p.Image.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "Wwwroot/WriterImage/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.Image.CopyTo(stream);
                w.Image = newimagename;
            }
            w.Email = p.Email;
            w.Name = p.Name;
            w.Password = p.Password;
            w.Status = true;
            w.About = p.About;
            wm.TAdd(w);
            return RedirectToAction("Index","Dashboard");
        }

    }

}
