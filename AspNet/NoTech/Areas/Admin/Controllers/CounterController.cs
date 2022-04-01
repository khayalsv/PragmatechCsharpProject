using KS.Extension;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoTech.Extension;
using NoTech.Models;
using NoTech.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CounterController : Controller
    {
        private readonly MyContext myContext;

        public CounterController(MyContext myContext)
        {
            this.myContext = myContext;
        }

        [HttpGet]
        public async Task<IActionResult> List(int page=1)
        {
            int take = 3;
            PaginationVM model = new PaginationVM
            {
                counters = await myContext.Counters.Skip(take * (page - 1)).Take(take).ToListAsync(),
                Pagination = new PaginationModel(await myContext.Counters.CountAsync(), take, page)
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Counter item)
        {
            if (!ModelState.IsValid) return View(item); //datanin olmadigini yoxluyur


            await myContext.Counters.AddAsync(item);
            await myContext.SaveChangesAsync();

            return Redirect("List");
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var item = myContext.Counters.Find(id);

            if (item == null) return NotFound();

            return View(item);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Counter item)
        {
            if (!ModelState.IsValid) return View(item);

            var list = myContext.Counters.Find(item.ID);

           

            list.Odometer = item.Odometer;
            list.Text = item.Text;
            list.Title = item.Title;
            list.Icon = item.Icon;


            await myContext.SaveChangesAsync();
            return Redirect("/Admin/Counter/List");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var item = await myContext.Counters.FindAsync(id);

            if (item == null) return NotFound();

            myContext.Counters.Remove(item);
            await myContext.SaveChangesAsync();

            TempData["Success"] = "Item deleted!";

            return Redirect("/Admin/Counter/List");

        }

        //AJAX
        [HttpPost]
        public async Task<JsonResult> CreateAjax(Counter item)
        {
            if (item == null)
            {
                return Json(new
                {
                    status = 400
                });
            }


            await myContext.Counters.AddAsync(item);
            await myContext.SaveChangesAsync();

            return Json(new
            {
                status = 200
            });
        }


        [HttpGet]
        public async Task<JsonResult> EditAjax(int? id)
        {
            if (id == null)
            {
                return Json(new
                {
                    status = 404
                }); ;
            }
              

            var item = await myContext.Counters.FindAsync(id);

            if (item == null)
            {
                return Json(new
                {
                    status = 404
                }); ;
            }

            return Json(item);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> EditAjax(Counter item)
        {
            var list = await myContext.Counters.FirstOrDefaultAsync(x=>x.ID == item.ID);
            if (list == null)
            {
                return Json(new
                {
                    status = 404
                });
            }
            list.Odometer = item.Odometer;
            list.Title = item.Title;
            list.Text = item.Text;
            list.Icon = item.Icon;

            myContext.Update(item);
            await myContext.SaveChangesAsync();

            return Json(new
            {
                status = 200
            });
        }


        [ValidateAntiForgeryToken]
        public async Task<JsonResult> DeleteAjax(int? id)
        {
            if (id == null) return Json(new
            {
                status = 404
            });
            var item = await myContext.Counters.FindAsync(id);
            if (item == null)
            {
                return Json(new
                {
                    status = 404
                });
            }

            myContext.Counters.Remove(item);
            await myContext.SaveChangesAsync();
            return Json(new
            {
                status = 200
            });
        }
    }
}
