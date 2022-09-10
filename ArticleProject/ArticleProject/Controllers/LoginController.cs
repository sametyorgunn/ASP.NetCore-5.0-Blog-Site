using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ArticleProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System;

namespace ArticleProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {

        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel p)
        {
            Context c = new Context();
            AppUser user = new AppUser();
            //if(ModelState.IsValid)
            //{                
            var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, true);
           
            if (result.Succeeded)
            {
                var username = User.Identity.Name;
                var userstatus = c.Users.Where(x => x.UserName == username).Select(y => y.Status).FirstOrDefault();
                if (userstatus == 1)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
              
            }
            else
            {
                return View();
            }
            //}
            //else
            //{
            //    return View();
            //}

        }
        public async Task<IActionResult>LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }

       
    }
}

