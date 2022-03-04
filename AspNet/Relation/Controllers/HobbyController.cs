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

            TeacherToHobby hobbyList=dbContext.TEACHERTOHOBBY.Include(x => x.TeacherTable).Include(y => y.HobbyTable).FirstOrDefault(x=>x.TeacherID==id);

            if (hobbyList == null)
                return NotFound();

            return View(hobbyList);
        }

        [HttpPost]
        public IActionResult Edit(TeacherToHobby teacherToHobby)
        {
            if (!ModelState.IsValid)
                return NotFound();

            TeacherToHobby teacherList = dbContext.TEACHERTOHOBBY.Include(x => x.TeacherTable).FirstOrDefault(x => x.TeacherID == x.TeacherID);
            TeacherToHobby hobbyList = dbContext.TEACHERTOHOBBY.Include(x => x.HobbyTable).FirstOrDefault(x => x.HobbyID == x.HobbyID);

            if (teacherList == null)
                return View(teacherToHobby);

            if (hobbyList == null)
                return View(teacherToHobby);
           
            teacherList.TeacherTable.TeacherName = teacherToHobby.TeacherTable.TeacherName;
            hobbyList.HobbyTable.HobbyName = teacherToHobby.HobbyTable.HobbyName;

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
