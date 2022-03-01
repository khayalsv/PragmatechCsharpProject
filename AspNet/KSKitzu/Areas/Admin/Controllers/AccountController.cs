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
        private readonly UserManager<IdentityUser> _userManager; //user-in emaili dogrulugu,crud
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(PortoDbContext dbContext,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<IdentityUser> signInManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task SeedRoles()
        {
            if (!await _roleManager.RoleExistsAsync(roleName: "Admin"))
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
            if (_userManager.FindByEmailAsync("admin@gmail.com").Result == null)
            {
                User user = new User()
                {
                    UserName = "admin",
                    Email = "admin@gmail.com"
                };

                IdentityResult result = await _userManager.CreateAsync(user, "admin123!A");
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "Admin").Wait();
                    await _dbContext.SaveChangesAsync();
                    await _signInManager.SignInAsync(user, true);
                }
            }
        }




        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Copy data from RegisterViewModel to IdentityUser
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email
                };

                // Store user data in AspNetUsers database table
                var result = await _userManager.CreateAsync(user, model.Password);

                // If user is successfully created, sign-in the user using
                // SignInManager and redirect to index action of HomeController
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return Redirect("/admin/account/login");
                }

                // If there are any errors, add them to the ModelState object
                // which will be displayed by the validation summary tag helper
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email,
                    model.Password,
                    model.RememberMe, false);

                if (result.Succeeded)
                {
                    return Redirect("/Admin/Blog/List");
                }

                ModelState.AddModelError(string.Empty, "Invalid login Attempt");

            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/Admin/account/register");
        }
    }
}
