using KS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Relation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Controllers
{
    public class HobbyController : Controller
    {
        private readonly PortoDbContext dbContext;

        public HobbyController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IActionResult List()
        {
            var hobbyList = dbContext.TEACHERTOHOBBY.Include(x=>x.TeacherTable).Include(y=>y.HobbyTable).ToList();

            return View(hobbyList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.TEACHERBAG = dbContext.TEACHER.ToList();
            TeacherToHobby teacherToHobby = new TeacherToHobby();
            return View(teacherToHobby);
        }

        [HttpPost]
        public IActionResult Create(TeacherToHobby teacherToHobby)
        {
            if (!ModelState.IsValid)
                return NotFound();

            dbContext.TEACHERTOHOBBY.Add(teacherToHobby);
            dbContext.SaveChanges();

            return Redirect("/Hobby/List");   
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var teacherList = dbContext.TEACHERTOHOBBY.Include(x => x.TeacherTable).Include(x=>x.HobbyTable).First(x => x.TeacherID==id);

           

            return View(teacherList);
        }

        [HttpPost]
        public IActionResult Edit(TeacherToHobby teacherToHobby)
        {
            if (!ModelState.IsValid)
                return NotFound();

            var teacherList = dbContext.TEACHERTOHOBBY.First(x => x.TeacherID == teacherToHobby.TeacherID);

            if (teacherList == null)
                return View(teacherToHobby);

            teacherList.HobbyTable.HobbyName = teacherToHobby.HobbyTable.HobbyName;
            teacherList.TeacherTable.TeacherName = teacherToHobby.TeacherTable.TeacherName;



            dbContext.SaveChanges();
            return Redirect("/Hobby/List");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            TeacherToHobby hobbyList = dbContext.TEACHERTOHOBBY.Find(id);

            if (hobbyList == null)
                return NotFound();

            dbContext.TEACHERTOHOBBY.Remove(hobbyList);
            dbContext.SaveChanges();

            return Redirect("/Hobby/List");
        }

    }
}
