using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var _myContext = new MyContext();
            var values = _myContext.Employees.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult EmployeeAdd(Employee employee)
        {
            using var _myContext = new MyContext();
            _myContext.Add(employee);
            _myContext.SaveChanges();
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult EmployeeGet(int id)
        {
            using var _myContext = new MyContext();
            var employee = _myContext.Employees.Find(id);
            if (employee == null)
                return NotFound();
            else
                return Ok(employee);
        }

        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {
            using var _myContext = new MyContext();
            var employee = _myContext.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                _myContext.Remove(employee);
                _myContext.SaveChanges();
                return Ok();
            }
        }

        [HttpPut]
        public IActionResult EmployeeUpdate(Employee item)
        {
            using var _myContext = new MyContext();
            var employee = _myContext.Find<Employee>(item.Id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                employee.Name = item.Name;
                _myContext.Update(employee);
                _myContext.SaveChanges();
                return Ok();
            }

        }
    }
}