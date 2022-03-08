using KSResumo.Extension;
using KSResumo.Models;
using KSResumo.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KSResumo.Controllers
{
    public class AccountController : Controller
    {
        private readonly PortoDbContext dbContext;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IEmailService emailService;


        public AccountController(PortoDbContext dbContext,
            RoleManager<IdentityRole> roleManager,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
             IEmailService emailService)
        {
            this.dbContext = dbContext;
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
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
            if (userManager.FindByEmailAsync("admin@gmail.com").Result == null)
            {
                IdentityUser user = new IdentityUser()
                {
                    UserName = "admin",
                    Email = "admin@gmail.com"
                };

                IdentityResult result = await userManager.CreateAsync(user, "admin123!A");
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                    await dbContext.SaveChangesAsync();
                    await signInManager.SignInAsync(user, true);
                }
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //1 defe sorgu
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid)
                return View(register);

            if (userManager.Users.Any(x => x.NormalizedEmail == register.Email.ToUpper()))
            {
                ModelState.AddModelError("Email", "User is already exist");
                return View();
            }

            IdentityUser user = new IdentityUser()
            {
                UserName = register.Email,
                Email = register.Email
                
            };

            IdentityResult result = await userManager.CreateAsync(user, register.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(" ", item.Description);
                    return View();
                }
            }

            await userManager.AddToRoleAsync(user, "User");
            await signInManager.SignInAsync(user, true);

            return Redirect("/");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            IdentityUser user = await userManager.FindByNameAsync(login.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Email is invalid");
                return View();
            }

            var result = await signInManager.PasswordSignInAsync(user, login.Password, true, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Password is invalid");
                return View();

            }

            return Redirect("/");

        }

        
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return Redirect("/");
        }


        [HttpGet]
        [Authorize(Roles="User")]
        public async Task<IActionResult> Edit()
        {
            IdentityUser user = await userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateVM updateVM = new UserUpdateVM
            {
                Email=user.Email,
            };
            return View(updateVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> Edit(UserUpdateVM updateVM)
        {
            if (!ModelState.IsValid)
                return View();

            IdentityUser user = await userManager.FindByNameAsync(User.Identity.Name);

            if (user.Email != updateVM.Email && userManager.Users.Any(x=>x.NormalizedEmail== updateVM.Email.ToUpper()))
            {
                ModelState.AddModelError("", "Username is already exist");
                return View();
            }

            if (!string.IsNullOrWhiteSpace(updateVM.NewPassword))
            {
                if (updateVM.NewPassword != updateVM.NewConfirmPassword)
                {
                    ModelState.AddModelError("", "Password with not macthed confirm pass");
                    return View();
                }

                var result= await userManager.ChangePasswordAsync(user, updateVM.CurrentPassword, updateVM.NewPassword);
                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                        return View();
                    }
                }
            }
            user.Email = updateVM.Email;

            await userManager.UpdateAsync(user);
            await signInManager.SignInAsync(user, true);

            return Redirect("/");
        }

     
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordVM forgetVM)
        {          
            var user = await userManager.FindByEmailAsync(forgetVM.Email);

            if (user == null)
            {
                ModelState.AddModelError("Email", "Email is not valid");
                return View();
            }
           
            string token= await userManager.GeneratePasswordResetTokenAsync(user);
            string callback=Url.Action("resetpassword", "account", new { token, email = user.Email }, Request.Scheme);

            string body = string.Empty;
            using(StreamReader reader =new StreamReader("wwwroot/templates/forgetpassword.html"))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{{url}}", callback);

            emailService.Send(user.Email, "Reset Password", body);

            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public IActionResult ResetPassword(string token,string email)
        {
            ResetPasswordVM resetVM = new ResetPasswordVM
            {
                Token = token,
                Email = email
            };
            return View(resetVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetVM)
        {
            if (!ModelState.IsValid)
                return View(resetVM);

            IdentityUser user = await userManager.FindByEmailAsync(resetVM.Email);
            
            var result = await userManager.ResetPasswordAsync(user, resetVM.Token, resetVM.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(resetVM);
            }

            return RedirectToAction("Login", "Account");
        }

    }
}
