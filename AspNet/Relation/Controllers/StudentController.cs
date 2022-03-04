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

        [HttpGet]
        public IActionResult List()
        {
            var studentList = dbContext.STUDENT.Include(x => x.Addresses).ToList();

            return View(studentList);
        }

        [HttpGet]
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

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            Student studentList = dbContext.STUDENT.Include(x=>x.Addresses).FirstOrDefault(x=>x.ID==id);

            if (studentList == null)
                return NotFound();

            return View(studentList);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (!ModelState.IsValid)
                return NotFound();

            Student studentList = dbContext.STUDENT.Include(x => x.Addresses).FirstOrDefault(x => x.ID == student.ID);
            if (studentList == null)
                return NotFound();

            studentList.Fullname = student.Fullname;
            studentList.Addresses.Name = student.Addresses.Name;

            dbContext.SaveChanges();
            return Redirect("/Student/List");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            Student studentList = dbContext.STUDENT.Find(id);

            if (studentList == null)
                return NotFound();
            
            dbContext.STUDENT.Remove(studentList);
            dbContext.SaveChanges();

            return Redirect("/Student/List");
        }
    }
}
