using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {
        private readonly PortoDbContext dbContext;

        public StudentController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult List()
        {
            var studentList = dbContext.StudentAddress.Include(x => x.Student).ToList();

            return View(studentList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
