using KSApi.Data;
using KSApi.Data.Entities;
using KSApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        private readonly ISingletonOperation singletonOperation;
        private readonly IServiceProvider serviceProvider;
        private readonly IConfiguration configuration;
        private readonly MyContext mycontext;
        private readonly PositionOptions positionOptions;
        private readonly ILogger<StudentController> logger;

        public StudentController(ISingletonOperation singletonOperation,
            IServiceProvider serviceProvider,
            IConfiguration configuration,
            IOptions<PositionOptions> positionOptions,
            MyContext mycontext,
            ILogger<StudentController> logger)
        {
            this.singletonOperation = singletonOperation;
            this.serviceProvider = serviceProvider;
            this.configuration = configuration;
            this.mycontext = mycontext;
            this.positionOptions = positionOptions.Value; //instance
            this.logger = logger;
        }

        [HttpGet("Guid")]
        public object GetGuid()
        {
            var scopedOperation1 = (IScopedOperation)serviceProvider.GetService(typeof(IScopedOperation));
            var transientOperation1 = (ITransientOperation)serviceProvider.GetService(typeof(ITransientOperation));

            var scopedOperation2 = (IScopedOperation)serviceProvider.GetService(typeof(IScopedOperation));
            var transientOperation2 = (ITransientOperation)serviceProvider.GetService(typeof(ITransientOperation));


            var data = new
            {
                Singleton = singletonOperation.ID,
                Scoped1 = scopedOperation1.ID,
                Scoped2 = scopedOperation2.ID,
                Transient1 = transientOperation1.ID,
                Transient2 = transientOperation2.ID

            };

            return data;
        }


        [HttpGet("all")]
        public async Task<object> GetAll()
        {
            logger.LogInformation("Request accepted at {date}", DateTime.Now);


            var list = await mycontext.Students.Include(x => x.Gender)
                 .Select(y => new
                 {
                     y.ID,
                     y.Name,
                     y.Surname,
                     y.Salary,
                     y.DateOfBirth,
                     GenderName = y.Gender.Name,
                     Courses = y.StudentCourses.Select(sc => new
                     {
                         sc.Course.Name,
                         sc.StartDate,
                         sc.EndDate
                     })
                 }).ToListAsync();

            logger.LogWarning("Request successfully completed at {date}, list: {list}", DateTime.Now, JsonConvert.SerializeObject(list));

            return list;
        }

        [HttpGet("studentCourseReport")]
        public async Task<object> GetReport()  //sql code
        {
            var query = from sc in mycontext.StudentCourses
                        join s in mycontext.Students on sc.StudentID equals s.ID
                        join c in mycontext.Courses on sc.CourseID equals c.ID
                        join g in mycontext.Genders on s.GenderID equals g.ID
                        select new
                        {
                            s.Name,
                            s.Surname,
                            s.DateOfBirth,
                            GenderName=g.Name,
                            CourseName=c.Name,
                            sc.StartDate,
                            sc.EndDate
                        };
            return await query.ToListAsync();
        }

        [HttpGet("genders")]             
        public async Task<object> GetGender()
        {
            var list = await mycontext.Students.Include(x => x.Gender)
                .Select(y => new
                {
                    y.Name,
                    y.Surname,
                    y.Salary,
                    y.DateOfBirth,
                    GenderName=y.Gender.Name
                }).ToListAsync();
            return list;
        }

        [HttpGet("student/{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var request = Request;
            var context = HttpContext;
            var user = User;

            var student = await mycontext.Students.FirstOrDefaultAsync(x => x.ID == id);
            if (student==null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateStudent([FromBody] Student student)
        {
            await mycontext.Students.AddAsync(student);
            await mycontext.SaveChangesAsync();

            return Created($"/api/student/student/{student.ID}",student);
        }

        [HttpPut("update")]
        public async Task<Student> UpdateStudent(int id,Student newStudent)
        {
            var student =await mycontext.Students.FirstOrDefaultAsync(x => x.ID == id);
            student.Name = newStudent.Name;
            student.Surname = newStudent.Surname;
            await mycontext.SaveChangesAsync();

            return newStudent;
        }
   
        [HttpDelete("delete")]
        public async Task<Student> DeleteStudent(int id)
        {
            try
            {
                logger.LogDebug("Request accepted to delete the student with id: {id}", id);

                var student = await mycontext.Students.FirstOrDefaultAsync(x => x.ID == id);

                logger.LogDebug("Student is fetched from database successfully", id);


                mycontext.Remove(student);
                await mycontext.SaveChangesAsync();


                logger.LogDebug("Student is deleted from db and transaction committed {id}", id);

                logger.LogInformation("Request is successfully completed to delete the student {id}", id);

                return student;

            }
            catch (Exception exc)
            {
                logger.LogError(exc,"Error occurred when deleting the student wirh id: {id}", id);
                throw;
            }
           
        }

        [HttpGet("configs")]
        public object GetConfigurations()
        {
            var configurations = new
            {
                GeneralApiKey = configuration["ApiKey"],
                SmsApiKey=configuration["SmsApi:ApiKey"],
                FromNumber=configuration["SmsApi:FromNumber"],
                PositionOptions= positionOptions
            };

            return configurations;
        }
    }
}
