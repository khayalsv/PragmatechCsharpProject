using BeginProject.Data.Entities;
using BeginProject.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeginProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly MyContext myContext;
        public StudentController(MyContext myContext)
        {
            this.myContext = myContext;
        }



        [HttpGet("{id}")]
        public async Task<object> GetByID(int id)
        {
            var item = await myContext.Students.FirstOrDefaultAsync(x => x.ID == id);

            if (item == null) return NotFound();

            return item;

        }


        [HttpGet("all")]
        public async Task<object> GetAllStudent()
        {
            var list = await myContext.Students.Select(x => new           
            {
                x.ID,
                x.Fullname,
                x.Email,
                x.Group.Name,
                Teachers = x.StudentTeachers.Select(st => new
                {
                    st.Teacher.Fullname
                }),
                Classroom = x.StudentClassrooms.Select(sc => new
                {
                    sc.Classroom.Name,
                    sc.Classroom.Capacity
                })
            }).ToListAsync();
          
            return list;
        }


        [HttpGet("getreport")]
        public async Task<object> GetReport()
        {
            var query = from st in myContext.StudentTeachers
                        join s in myContext.Students on st.StudentID equals s.ID
                        join t in myContext.Teachers on st.TeacherID equals t.ID
                        join g in myContext.Groups on s.GroupID equals g.ID
                        select new
                        {
                            s.Fullname,
                            GroupName=g.Name,
                            TeacherName = t.Fullname,
                        };
                    
            return await query.ToListAsync();
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("student is not valid");
            }

            await myContext.Students.AddAsync(student);
            await myContext.SaveChangesAsync();
            return Created($"/api/students/{student.ID}", student);
        }



        [HttpPut("edit")]
        public async Task<object> Edit([FromBody] Student newstudent)
        {
            var item = await myContext.Students.FirstOrDefaultAsync(x => x.ID == newstudent.ID);

            if (item == null) return NotFound();

            item.Fullname = newstudent.Fullname;
            item.Email = newstudent.Email;
            item.GroupID = newstudent.GroupID;
     
            myContext.Update(item);
            
            await myContext.SaveChangesAsync();
            return item;
        }

        [HttpDelete("{id}")]
        public async Task<object> Delete(int id)
        {
            var item = await myContext.Students.FirstOrDefaultAsync(x => x.ID==id);

            if (item==null) return NotFound();
          
            myContext.Students.Remove(item);
            await myContext.SaveChangesAsync();

            return item;

        }
    }
}
