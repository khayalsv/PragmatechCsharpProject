using KS.Extension;
using KS.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Relation.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Controllers
{
    public class HomeController : Controller
    {

        private readonly PortoDbContext dbContext;
        public HomeController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult List()
        {
            var studentList = dbContext.STUDENT.Include(x => x.Groups).ToList();

            return View(studentList);
        }

    }
}
