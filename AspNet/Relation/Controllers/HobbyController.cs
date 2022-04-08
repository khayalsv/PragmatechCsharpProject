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
            var teacherlist = dbContext.TEACHER.Include(x => x.TeacherToHobbies).ThenInclude(y => y.Hobby).ToList();

            //var teacherlist = dbContext.TEACHER.Select(x => new
            //{
            //    HobbyName = x.TeacherToHobbies.Select(th => new
            //    {
            //        th.Hobby.Name
            //    })
            //}).ToList();
            return View(teacherlist);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Teacher = dbContext.TEACHER.ToList();
            ViewBag.Hobby = dbContext.HOBBY.ToList();
            return View();
        }

        [HttpPost]
        public  async Task<IActionResult> Create(Teacher item)
        {

            if (!ModelState.IsValid)
                return NotFound();

           await dbContext.TEACHER.AddAsync(item);
            dbContext.SaveChanges();

            return Redirect("/Hobby/List");   
        }

        //[HttpGet]
        //public IActionResult Edit(int? id)
        //{
        //    if (id == null)
        //        return NotFound();

        //    var teacherList = dbContext.TEACHERTOHOBBY.Include(x => x.TeacherTable).Include(x=>x.HobbyTable).First(x => x.TeacherID==id);

           

        //    return View(teacherList);
        //}

        //[HttpPost]
        //public IActionResult Edit(TeacherToHobby teacherToHobby)
        //{
        //    if (!ModelState.IsValid)
        //        return NotFound();

        //    var teacherList = dbContext.TEACHERTOHOBBY.First(x => x.TeacherID == teacherToHobby.TeacherID);

        //    if (teacherList == null)
        //        return View(teacherToHobby);

        //    teacherList.HobbyTable.HobbyName = teacherToHobby.HobbyTable.HobbyName;
        //    teacherList.TeacherTable.TeacherName = teacherToHobby.TeacherTable.TeacherName;



        //    dbContext.SaveChanges();
        //    return Redirect("/Hobby/List");
        //}

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
