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
    public class ContactController : Controller
    {
        private readonly MyContext myContext;

        public ContactController(MyContext myContext)
        {
            this.myContext = myContext;
        }

        [HttpGet]
        public IActionResult List()
        {
            var item = myContext.Contacts.ToList();
            return View(item);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var item = new Contact();
            return View(item);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Contact item)
        {
            if (!ModelState.IsValid) return View(item); //datanin olmadigini yoxluyur


            await myContext.Contacts.AddAsync(item);
            await myContext.SaveChangesAsync();

            return Redirect("List");
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var item = myContext.Contacts.Find(id);

            if (item == null) return NotFound();

            return View(item);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Contact item)
        {
            if (!ModelState.IsValid) return View(item);

            var list = myContext.Contacts.Find(item.ID);
            list.Name = item.Name;
            list.Email = item.Email;
            list.Message = item.Message;

            await myContext.SaveChangesAsync();
            return Redirect("/Admin/Contact/List");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var item = await myContext.Contacts.FindAsync(id);

            if (item == null) return NotFound();

            myContext.Contacts.Remove(item);
            await myContext.SaveChangesAsync();

            TempData["Success"] = "Item deleted!";

            return Redirect("/Admin/Contact/List");

        }


    }
}
