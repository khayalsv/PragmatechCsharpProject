using KS.Extension;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NoTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LayoutController : Controller
    {
        private readonly MyContext myContext;
        private readonly IWebHostEnvironment env; //image

        public LayoutController(MyContext myContext, IWebHostEnvironment env)
        {
            this.myContext = myContext;
            this.env = env;
        }

        [HttpGet]
        public IActionResult List()
        {
            var item = myContext.Layouts.ToList();
            return View(item);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var item = new Layout();
            return View(item);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Layout item)
        {
            if (!ModelState.IsValid) return View(item); //datanin olmadigini yoxluyur

            await myContext.Layouts.AddAsync(item);
            await myContext.SaveChangesAsync();

            return Redirect("List");
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var item = myContext.Layouts.Find(id);

            if (item == null) return NotFound();

            return View(item);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Layout item)
        {
            if (!ModelState.IsValid) return View(item);

            var list = myContext.Layouts.Find(item.ID);


            list.Address = item.Address;
            list.Email = item.Email;
            list.SocialIcon = item.SocialIcon;
            list.SocialIcon = item.SocialIcon;
            list.Question = item.Question;
            list.Phone = item.Phone;


            await myContext.SaveChangesAsync();
            return Redirect("/Admin/Layout/List");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var item = await myContext.Layouts.FindAsync(id);

            if (item == null) return NotFound();

            myContext.Layouts.Remove(item);
            await myContext.SaveChangesAsync();

            TempData["Success"] = "Item deleted!";

            return Redirect("/Admin/Layout/List");

        }
    }
}
