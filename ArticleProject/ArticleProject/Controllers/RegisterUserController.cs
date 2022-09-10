using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ArticleProject.Models;
using System.Threading.Tasks;

namespace ArticleProject.Controllers
{
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {
        private readonly UserManager<AppUser> _usermanager;
        private readonly RoleManager<AppRole> _rolemanager;

        public RegisterUserController(UserManager<AppUser> usermanager, RoleManager<AppRole> rolemanager)
        {
            _usermanager = usermanager;
            _rolemanager = rolemanager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Index(UserSignUpModel p)
        {
            if(ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Email = p.mail,
                    UserName = p.username,
                    namesurname = p.namesurname,
                    Status = 0
                };
                var result = await _usermanager.CreateAsync(user, p.password);
                if(result.Succeeded)
                {
                    if (!_rolemanager.RoleExistsAsync("Writer").Result)
                    {
                        AppRole role = new AppRole
                        {
                            Name = "Writer"
                        };
                        IdentityResult roleResult = _rolemanager.CreateAsync(role).Result;

                    }
                    _usermanager.AddToRoleAsync(user, "Writer").Wait();
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }
    }
}
