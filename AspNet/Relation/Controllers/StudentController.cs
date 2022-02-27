using KS.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Relation.Models;
using Relation.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Controllers
{
    public class StudentController : Controller
    {

        private readonly PortoDbContext dbContext;
        public StudentController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult List()
        {
            var studentList = dbContext.STUDENT.Include(x => x.Addresses).ToList();

            return View(studentList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Student student = new Student
            {
                Fullname = model.Fullname,
            };
            dbContext.STUDENT.Add(student);
            dbContext.SaveChanges();

            Address address = new Address
            {
                Name = model.Name,
                Students = student
            };
            dbContext.ADDRESS.Add(address);
            dbContext.SaveChanges();

            return Redirect("/Student/List");
        }
    }
}
