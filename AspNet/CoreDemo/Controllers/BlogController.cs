﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        MyContext _myContext = new MyContext();

        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        [AllowAnonymous]
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogById(id);
            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            var usermail = User.Identity.Name;
            var writerId = _myContext.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();

            var values = bm.GetListWithCategoryByWriterBm(writerId);
            return View(values);
        }
         
        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;                                   
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {

            var usermail = User.Identity.Name;
            var writerId = _myContext.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();


            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(p);
            if (results.IsValid)
            {
                p.Status = true;
                p.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterId = writerId;
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

        public IActionResult DeleteBlog(int id)
        {
            var blogValue = bm.TGetById(id);
            bm.TDelete(blogValue);

            return RedirectToAction("BlogListByWriter");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogValue = bm.TGetById(id);
            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View(blogValue);
        }

        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {

            var usermail = User.Identity.Name;
            var writerId = _myContext.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();

            p.WriterId = writerId;
            p.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.Status=true;
            bm.TUpdate(p);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
