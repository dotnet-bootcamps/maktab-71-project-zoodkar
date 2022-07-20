using App.Domain.Core.Entities;
using App.EndPoints.UI.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace App.EndPoints.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        

        public AccountController(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager
           )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            
        }

        [AllowAnonymous]
        public async Task<IActionResult> Login()
        {
            await _signInManager.SignOutAsync();
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    return LocalRedirect("~/");
                }

                ModelState.AddModelError(string.Empty, "خطا در فرآیند لاگین");
            }
            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return LocalRedirect("~/");
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    FirstName=model.FirstName,
                    UserName=model.Email,
                    Email = model.Email,
                    LastName=model.LastName,
                    IsActive=true,
                    HomeAddress=model.HomeAddress,
                    
                    
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {



                  
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    await  _userManager.AddToRoleAsync(user, model.Role);
                   
                    return LocalRedirect("~/");
                   
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, item.Description);
                    }
                }
            }
            return View(model);
        }
    }
}

