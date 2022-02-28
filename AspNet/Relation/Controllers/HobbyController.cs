using KS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    }
}
