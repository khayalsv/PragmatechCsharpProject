using KSResumo.Extension;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NoTech.Models;
using NoTech.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly MyContext myContext;
        private readonly IEmailService emailService;

        public AccountController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            MyContext myContext,
            IEmailService emailService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.myContext = myContext;
            this.emailService = emailService;
        }
        public async Task SeedRoles()
        {
            if (!await roleManager.RoleExistsAsync(roleName: "Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole(roleName: "Admin"));
            }
            if (!await roleManager.RoleExistsAsync(roleName: "User"))
            {
                await roleManager.CreateAsync(new IdentityRole(roleName: "User"));
            }
        }

        public async Task SeedAdmin()
        {
            if (userManager.FindByEmailAsync("selimovxeyal@gmail.com").Result == null)
            {
                IdentityUser user = new IdentityUser()
                {
                    UserName = "khayal",
                    Email = "selimovxeyal@gmail.com"
                };

                IdentityResult result = await userManager.CreateAsync(user, "Xeyal123");

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                    await myContext.SaveChangesAsync();
                    await signInManager.SignInAsync(user, true);
                }
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View(login);

            var user = await userManager.FindByEmailAsync(login.Email);

            if (user==null)
            {
                ModelState.AddModelError("", "Username is invalid");
                return View();
            }

            var result = await signInManager.PasswordSignInAsync(user, login.Password,false,false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Password is invalid");
                return View();

            }

            return Redirect("/admin/home/list");
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return Redirect("/");
        }

    }
}
