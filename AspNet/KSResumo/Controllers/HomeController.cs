using KSResumo.Models;
using KSResumo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KSResumo.Controllers
{
    public class HomeController : Controller
    {
        private readonly PortoDbContext dbContext;
        public HomeController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IActionResult> HomePage()
        {
            HomeVM vM = new HomeVM
            {
                Homes = await dbContext.Homes.ToListAsync(),
                Abouts=await dbContext.Abouts.ToListAsync(),
                Portfolios = await dbContext.Portfolios.ToListAsync(),
                News = await dbContext.News.ToListAsync(),
                Contacts = await dbContext.Contacts.ToListAsync(),
                Socials = await dbContext.Socials.ToListAsync(),
            };
            return View(vM);
        }

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    Contact contact = new Contact();
        //    return View(contact);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Create(Contact contact)
        //{ 
        //    await dbContext.Contacts.AddAsync(contact);
        //    await dbContext.SaveChangesAsync();

        //    return Redirect("HomePage");
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
