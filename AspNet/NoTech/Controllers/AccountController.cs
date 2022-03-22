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

namespace NoTech.Controllers
{
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


        public IActionResult ForgetPassword() { return View(); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(ForgetVM forgetVM)
        {
            var user = await userManager.FindByEmailAsync(forgetVM.Email);

            if (user == null)
            {
                ModelState.AddModelError("Email", "Email is not valid");
                return View();
            }

            string token = await userManager.GeneratePasswordResetTokenAsync(user);
            string callback = Url.Action("resetpassword", "account", new { token, email = user.Email }, Request.Scheme);

            string body = string.Empty;
            using (StreamReader reader = new StreamReader("wwwroot/template/forgetpassword.html"))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{{url}}", callback);

            emailService.Send(user.Email, "Reset Password", body);

            return Redirect("/Admin/Account/Login");
        }

        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            ResetVM resetVM = new ResetVM
            {
                Token = token,
                Email = email
            };
            return View(resetVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetVM resetVM)
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

            return Redirect("/admin/account/login");
        }
    }
}
