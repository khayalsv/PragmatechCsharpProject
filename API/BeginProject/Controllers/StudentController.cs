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



        [HttpGet("{id}/{take}")]
        public async Task<IActionResult> Get(int id, int take)
        {
            var item = await myContext.Groups.Include(x=>x.Students).FirstOrDefaultAsync(g => g.ID == id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item.Students.Take(take));

        }


        [HttpGet("all")]
        public async Task<object> GetAllStudent()
        {
            var list = await myContext.Students.Select(x => new           
            {
                x.ID,
                x.Fullname,
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



        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] Student newstudent)
        {
            var item = await myContext.Students.FirstOrDefaultAsync(x => x.ID == newstudent.ID);

            if (item == null) return NotFound();

            item.Fullname = newstudent.Fullname;
            item.Email = newstudent.Email;
            item.GroupID = newstudent.GroupID;
     
            myContext.Update(item);
            
            await myContext.SaveChangesAsync();
            return Ok($"Edit item {item.Fullname}");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await myContext.Students.FirstOrDefaultAsync(x => x.ID==id);

            if (item==null) return NotFound();
          
            myContext.Students.Remove(item);
            await myContext.SaveChangesAsync();
            return Ok($"Delete item {item.Fullname}");
        }
    }
}
