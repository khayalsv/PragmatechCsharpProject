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
    public class ServicesBoxController : Controller
    {
        private readonly MyContext myContext;
        private readonly IWebHostEnvironment env;
        public ServicesBoxController(MyContext myContext, IWebHostEnvironment env)
        {
            this.myContext = myContext;
            this.env = env;
        }
        public IActionResult List()
        {
            return View(myContext.ServicesBoxes.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ServicesBox item)
        {
            if (!ModelState.IsValid) return View(item);

            await myContext.ServicesBoxes.AddAsync(item);
            await myContext.SaveChangesAsync();

            return Redirect("/Admin/ServicesBox/List");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var item = myContext.ServicesBoxes.Find(id);

            if (item == null) return NotFound();

            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ServicesBox item)
        {
            if (!ModelState.IsValid) return View(item);

            var list = myContext.ServicesBoxes.Find(item.ID);

            list.Title1 = item.Title1;
            list.Title2 = item.Title2;
            list.Text1 = item.Text1;
            list.Text2 = item.Text2;
            list.Icon = item.Icon;

            await myContext.SaveChangesAsync();

            return Redirect("/Admin/ServicesBox/List");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            var item = await myContext.ServicesBoxes.FindAsync(id);

            myContext.ServicesBoxes.Remove(item);

            TempData["Success"] = "item deleted!";

            await myContext.SaveChangesAsync();

            return Redirect("/Admin/ServicesBox/List");

        } 
    }
}
