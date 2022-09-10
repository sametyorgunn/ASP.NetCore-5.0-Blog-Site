using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ArticleProject.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleProject.Controllers
{
    public class WriterController : Controller
    {
        private readonly IWebHostEnvironment _webHost;

        WriterManager wm = new WriterManager(new EfWriterRepository());
        UserManager usermanager = new UserManager(new EfUserRepository());


        private readonly UserManager<AppUser> _userManager;

        public WriterController(IWebHostEnvironment webHost, UserManager<AppUser> userManager)
        {
            _webHost = webHost;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.v1 = usermail;
            Context c = new Context();
            var writername = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.v2 = writername;
            return View();
        }
        public IActionResult WriterProfile()
        {
            return View();
        }
        public IActionResult WriterMail()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        public PartialViewResult WriterNavbarPartial()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var userid = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var userimageurl = c.Users.Where(x=>x.UserName==username).Select(y=>y.imgUrl).FirstOrDefault();
            ViewBag.profilfoto = userimageurl;
            return PartialView();
        }
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

       
        [HttpGet]
        public async Task<IActionResult> WriterEditProfile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateViewModel model = new UserUpdateViewModel();
            model.mail = values.Email;
            model.namesurname = values.namesurname;
            model.imgurl = values.imgUrl;
            model.username = values.UserName;
            return View(model);

            //1. Cİ YÖNTEM
            //Context c = new Context();
            //var username = User.Identity.Name;
            //var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();

            //var id = c.Users.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();
            //var values = usermanager.TGetById(id);

            //2.Cİ YÖNTEM

        }
      
        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(UserUpdateViewModel model)
        {
            string wwwRootPath = _webHost.WebRootPath;
            string filename = Path.GetFileNameWithoutExtension(model.img.FileName);
            string extension = Path.GetExtension(model.img.FileName);
            model.imgurl = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/ProfilResim/", filename);
            using (var filestream = new FileStream(path, FileMode.Create))
            {
                await model.img.CopyToAsync(filestream);
            }
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.imgUrl = model.imgurl;
            values.namesurname = model.namesurname;
            values.Email = model.mail;
            values.imgUrl = model.imgurl;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.password);
            var result = await _userManager.UpdateAsync(values);
            return RedirectToAction("Index", "Dashboard");

            //WriterValidator v1 = new WriterValidator();
            //ValidationResult result = v1.Validate(p);

            //if(result.IsValid)
            //{
            //    wm.TUpdate(p);
            //    return RedirectToAction("Index", "Dashboard");

            //}
            //else
            //{
            //    foreach(var item in result.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

            //    }
            //}
            //return View();

        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult WriterAdd()
        {
            return View();

        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if(p.WriterImage != null)
            {

                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFile/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
                w.WriterImage = newimagename;


            }
            w.WriterMail = p.WriterMail;
            w.WriterName = p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus = true;
            w.WriterAbout = p.WriterAbout;
            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }

        public IActionResult HesabiSil(int id)
        {
            
            Context c = new Context();
            var username = User.Identity.Name;
            var userid = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            id = userid;
            var kisi = c.Users.Find(id);
            usermanager.TDelete(kisi);
            return RedirectToAction("Index", "Login");
        }

    }
}
