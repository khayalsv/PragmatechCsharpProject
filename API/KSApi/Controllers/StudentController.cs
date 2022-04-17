using KSApi.Data;
using KSApi.Data.Entities;
using KSApi.Models;
using KSApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

     
        //GetAll
        [HttpGet("all")]
        public async Task<object> GetAll()
        {
            var list = await studentRepository.GetAll();

            return list.ToList(); ;
        }

     
        //Get
        [HttpGet("student/{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {

            var student = await studentRepository.Get(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

       
        //Create
        [HttpPost("create")]
        public async Task<IActionResult> CreateStudent([FromBody] Student student)
        {
            await studentRepository.Add(student);

            return Created($"/api/student/student/{student.ID}", student);
        }


        //Update
        [HttpPut("update")]
        public async Task<Student> UpdateStudent(int id, Student newStudent)
        {
            var student = await studentRepository.Get(id);

            student.Name = newStudent.Name;
            student.Surname = newStudent.Surname;

            await studentRepository.Update(student);

            return newStudent;
        }


        //Delete
        [HttpDelete("delete")]
        public async Task<Student> DeleteStudent(int id)
        {
           var student=  await studentRepository.Delete(id);

            return student;
        }


        //[HttpGet("studentCourseReport")]
        //public async Task<object> GetReport()  //sql code
        //{
        //    var query = from sc in mycontext.StudentCourses
        //                join s in mycontext.Students on sc.StudentID equals s.ID
        //                join c in mycontext.Courses on sc.CourseID equals c.ID
        //                join g in mycontext.Genders on s.GenderID equals g.ID
        //                select new
        //                {
        //                    s.Name,
        //                    s.Surname,
        //                    s.DateOfBirth,
        //                    GenderName = g.Name,
        //                    CourseName = c.Name,
        //                    sc.StartDate,
        //                    sc.EndDate
        //                };
        //    return await query.ToListAsync();
        //}


        //[HttpGet("genders")]             
        //public async Task<object> GetGender()
        //{
        //    var list = await mycontext.Students.Include(x => x.Gender)
        //        .Select(y => new
        //        {
        //            y.Name,
        //            y.Surname,
        //            y.Salary,
        //            y.DateOfBirth,
        //            GenderName=y.Gender.Name
        //        }).ToListAsync();
        //    return list;
        //}


        //[HttpGet("Guid")]
        //public object GetGuid()
        //{
        //    var scopedOperation1 = (IScopedOperation)serviceProvider.GetService(typeof(IScopedOperation));
        //    var transientOperation1 = (ITransientOperation)serviceProvider.GetService(typeof(ITransientOperation));

        //    var scopedOperation2 = (IScopedOperation)serviceProvider.GetService(typeof(IScopedOperation));
        //    var transientOperation2 = (ITransientOperation)serviceProvider.GetService(typeof(ITransientOperation));


        //    var data = new
        //    {
        //        Singleton = singletonOperation.ID,
        //        Scoped1 = scopedOperation1.ID,
        //        Scoped2 = scopedOperation2.ID,
        //        Transient1 = transientOperation1.ID,
        //        Transient2 = transientOperation2.ID

        //    };

        //    return data;
        //}



        //[HttpGet("configs")]
        //public object GetConfigurations()
        //{
        //    var configurations = new
        //    {
        //        GeneralApiKey = configuration["ApiKey"],
        //        SmsApiKey = configuration["SmsApi:ApiKey"],
        //        FromNumber = configuration["SmsApi:FromNumber"],
        //        PositionOptions = positionOptions
        //    };

        //    return configurations;
        //}
    }
}
