using KS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Relation.Models;
using Relation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Controllers
{
    public class CustomerController : Controller
    {
        private readonly PortoDbContext dbContext;
        public CustomerController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IActionResult List()
        {
            var customerList = dbContext.PRODUCT.Include(x => x.Customers).ToList();
            return View(customerList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CustomerVM model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            Customer customer = new Customer
            {
                CustomerName = model.CustomerName
            };
            dbContext.CUSTOMER.Add(customer);
            dbContext.SaveChanges();

            Product product = new Product
            {
                ProductName = model.ProductName,
                Customers=customer
            };
            dbContext.PRODUCT.Add(product);
            dbContext.SaveChanges();

            return Redirect("/Customer/List");
        }



    }
}
