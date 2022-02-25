using KS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KS.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ResumeController : Controller
    {
        private readonly PortoDbContext dbContext;
        public ResumeController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult ResumeList()
        {
            return View(dbContext.Resumes.ToList());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string edtitle, string eddetail, string eddescription,string extitle, string exdetail, string exdescription)
        {
            Resume resume = new Resume
            {
                edtitle = edtitle,
                eddetail = eddetail,
                eddescription = eddescription,

                extitle = extitle,
                exdetail = exdetail,
                exdescription = exdescription,
            };
            dbContext.Resumes.Add(resume);
            dbContext.SaveChanges();

            return Redirect("ResumeList");
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
