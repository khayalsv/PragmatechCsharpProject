using KS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KS.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly PortoDbContext _dbContext;
        private readonly UserManager<User> _userManager; //user-in emaili dogrulugu,crud
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(PortoDbContext dbContext, 
            UserManager<User> userManager, 
            RoleManager<IdentityRole> roleManager,
            SignInManager<User> signInManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        
        public async Task SeedRoles()
        {
            if (!await _roleManager.RoleExistsAsync(roleName:"Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName: "Admin"));
            }

            if (!await _roleManager.RoleExistsAsync(roleName: "User"))
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName: "USer"));
            }
        }

        public async Task SeedAdmin()
        {
            if (_userManager.FindByEmailAsync("admin@gmail.com").Result==null)
            {
                User user = new User()
                {
                    UserName = "admin",
                    Email="admin@gmail.com"
                };

               IdentityResult result=await _userManager.CreateAsync(user, "admin123!A");
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "Admin").Wait();
                    await _dbContext.SaveChangesAsync();
                    await _signInManager.SignInAsync(user, true);
                }
            }
        }



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User model)
        {
        }
}
