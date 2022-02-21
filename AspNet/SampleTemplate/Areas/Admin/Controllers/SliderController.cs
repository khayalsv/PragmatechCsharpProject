using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly PortoDbContext dbContext;
        public SliderController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult List()
        {
            return View(dbContext.Sliders.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormFile photo,int price,string trend,string discount,string cloth)
        {
            Slider slider = new Slider
            {
                TrendWord = trend,
                ClothType = cloth,
                Price = price,
                DisCount = discount,
                Image = photo.FileName
            };
            dbContext.Sliders.Add(slider);
            dbContext.SaveChanges();

            return Redirect("List");
        }

        public IActionResult Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            return View();
        }
    }
}
