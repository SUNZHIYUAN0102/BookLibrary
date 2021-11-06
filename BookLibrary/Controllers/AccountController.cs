using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.Models.AccountViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext dbcontext;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AccountController(ApplicationDbContext dbcontext, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.dbcontext = dbcontext;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login()
        {
            await this.HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var user = await this.userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    var NewUser = new User { Email = model.Email, UserName = model.Email};
                    var result = await this.userManager.CreateAsync(NewUser, model.Password);
                    if (result.Succeeded)
                    {
                        await this.signInManager.SignInAsync(NewUser, isPersistent: false);
                        return this.RedirectToAction("Index", "Books");
                    }
                    return this.View();
                }
                else
                {
                    var result = await this.signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: true);
                    if (result.Succeeded)
                    {
                        return this.RedirectToAction("Index", "Books");
                    }

                    this.ModelState.AddModelError(String.Empty, "Invalid login attempt.");
                    return this.View(model);
                }
            }
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await this.signInManager.SignOutAsync();
            return this.Redirect("/");
        }
    }
}
