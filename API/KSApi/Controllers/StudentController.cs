using KSApi.Models;
using Microsoft.AspNetCore.Mvc;
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
        private static List<Student> _students = new List<Student>();
        [HttpGet("all")]
        public List<Student> GetAll()
        {
            return _students;
        }

        [HttpPost("create")]
        public Student CreateStudent(Student student)
        {
            _students.Add(student);

            return student;
        }

        [HttpPut("update")]
        public Student UpdateStudent(int id,Student newStudent)
        {
            var student = _students.FirstOrDefault(x => x.ID == id);
            student.Name = newStudent.Name;

            return newStudent;
        }
   
        [HttpDelete("delete")]
        public Student DeleteStudent(int id)
        {
            var student = _students.FirstOrDefault(x => x.ID == id);
            _students.Remove(student);

            return student;
        }
    }
}
