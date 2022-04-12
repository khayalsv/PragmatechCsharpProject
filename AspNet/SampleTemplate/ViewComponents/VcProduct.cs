using Microsoft.AspNetCore.Mvc;
using SampleTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTemplate.ViewComponents
{
    public class VcProduct:ViewComponent
    {
        private readonly PortoDbContext _context;
        public VcProduct(PortoDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var model = _context.ProductViews.OrderBy(x => x.Name).ToList();
            return View(model);
        }
    }
}
