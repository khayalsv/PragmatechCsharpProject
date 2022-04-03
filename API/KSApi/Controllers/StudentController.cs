using KSApi.Data;
using KSApi.Data.Entities;
using KSApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
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

        public StudentController(ISingletonOperation singletonOperation,
            IServiceProvider serviceProvider,
            IConfiguration configuration,
            IOptions<PositionOptions> positionOptions,
            MyContext mycontext)
        {
            this.singletonOperation = singletonOperation;
            this.serviceProvider = serviceProvider;
            this.configuration = configuration;
            this.mycontext = mycontext;
            this.positionOptions = positionOptions.Value; //instance
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
        public async Task<List<Student>> GetAll()
        {
            var list= await mycontext.Students.ToListAsync();
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
            var student = await mycontext.Students.FirstOrDefaultAsync(x => x.ID == id);
            mycontext.Remove(student);
            await mycontext.SaveChangesAsync();

            return student;
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
