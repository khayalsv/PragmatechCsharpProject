using KS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KS.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {

        private readonly PortoDbContext dbContext;
        public AboutController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult AboutList()
        {
            return View(dbContext.Aboutes.ToList());
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            return View();
        }


  
    }
}
