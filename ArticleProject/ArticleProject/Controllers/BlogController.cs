using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArticleProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
//using System.Collections.Generic;
//using System.Linq;

namespace ArticleProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        IletisimMesajManager im = new IletisimMesajManager(new EfiletisimMesajUyeRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        Context c = new Context();
        BlogManager bm = new BlogManager(new EfBlogRepository());
        AboutManager am = new AboutManager(new EfAboutRepository());
        UserManager usermanager = new UserManager(new EfUserRepository());
        public BlogController(IWebHostEnvironment webHost)
        {
            _webHost = webHost;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {

            //var values = bm.GetBlogListWithCategory();
            //return View(values);

            Context c = new Context();
            var bloglar = c.Blogs.Where(x=>x.BlogStatus==true).Include(x => x.Category).Include(y=>y.AppUser).ToList();
            return View(bloglar);


        }
        [AllowAnonymous]
        public IActionResult BlogReadAll(int id)
        {
            /*anasayfadan gönderilen devamını oku aracılıgla id yi alıp parametrede tututup
             bu id yi viewbag ile tutuyoruz.
            username degiskeninde otantıke olan kisinin kullanıcı adını tutuyoruz.
            ve viewbag ile tututp bu degerleri ekrana basıyoruz.
            getblogbyid ile id ye ait blogu ekranda döndürüyoruz.*/
            ViewBag.i = id;
            ViewBag.CommentId = id;
            var username = User.Identity.Name;
            ViewBag.name = username;

            var result = bm.GetBlogByID(id);
            return View(result);
        }
        [Authorize(Roles ="Writer,Admin")]
        public IActionResult BlogListByWriter()
        {
            
            var username = User.Identity.Name;
            //var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerid = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();

            var values = c.Blogs.Where(x => x.AppUserId == writerid).Include(x=>x.Category).ToList(); /*bm.GetListCategoryWithWriterbm(writerid);*/
            return View(values);
        }
        [Authorize(Roles ="Admin,Writer")]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();

            ViewBag.v = categoryvalues;
            return View();
        }
        [Authorize(Roles ="Admin,Writer")]
        [HttpPost]
        public async Task<IActionResult> BlogAdd(Blog p)
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var userid = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();

            BlogValidator bv = new BlogValidator();
            ValidationResult result = bv.Validate(p);
            if (result.IsValid)
            {
                string wwwRootPath = _webHost.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(p.BlogImg.FileName);
                string extension = Path.GetExtension(p.BlogImg.FileName);
                p.BlogImgurl = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/BlogImg/", filename); 
                using (var filestream = new FileStream(path, FileMode.Create))
                {
                    await p.BlogImg.CopyToAsync(filestream);  
                }
                p.BlogStatus = true;
                p.AppUserId = userid;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                bm.TAdd(p);
                
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [Authorize(Roles ="Admin,Writer")]
        public IActionResult DeleteBlog(int id)
        {
            var blogvalue = bm.TGetById(id);
            bm.TDelete(blogvalue);
            return RedirectToAction("BlogListByWriter");
        }
        [Authorize(Roles ="Admin,Writer")]
        public IActionResult EditBlog(int id)
        {


            var values = bm.TGetById(id);
            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();

            ViewBag.v = categoryvalues;

            
;            return View(values);
        }
        [Authorize(Roles ="Admin,Writer")]
        [HttpPost]
        public async Task<IActionResult> EditBlog(Blog p)
        {

            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerid = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();

            string wwwRootPath = _webHost.WebRootPath;
            string filename = Path.GetFileNameWithoutExtension(p.BlogImg.FileName);
            string extension = Path.GetExtension(p.BlogImg.FileName);
            p.BlogImgurl = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/BlogImg/", filename);
            using (var filestream = new FileStream(path, FileMode.Create))
            {
                await p.BlogImg.CopyToAsync(filestream);
            }


            p.BlogStatus = true;
            p.AppUserId = writerid;
            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.AppUserId = writerid;
            bm.TUpdate(p);
            return RedirectToAction("BlogListByWriter");
        }

        [AllowAnonymous]
        public IActionResult Hakkimizda()
        {
            Context c = new Context();
            var hakkimizda = c.abouts.FirstOrDefault();
            return View(hakkimizda);
        }
        [AllowAnonymous]
        public IActionResult Kategoriler()
        {
            var kategoriler = cm.GetList();
            return View(kategoriler);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult iletisimMesajGonder(IletisimMesajUye iletisim)
        {
            if(ModelState.IsValid)
            {
                im.TAdd(iletisim);
                return RedirectToAction("Hakkimizda", "Blog");

            }
            else
            {
                return View();
            }
        }
        [AllowAnonymous]
        public IActionResult YazarDetay(int id)
        {
            Context c = new Context();
            var yazar = c.Users.Find(id);
     
            return View(yazar);
        }


        [AllowAnonymous]
        public IActionResult BlogBegen(int id)
        {
            var user = User.Identity.IsAuthenticated;
            if (user==true)
            {
                Context context = new Context();
                var blog = context.Blogs.Find(id);

                Blog begeni = new Blog
                {
                    BlogID = blog.BlogID,
                    Begeni_Sayisi = blog.Begeni_Sayisi + 1,
                    BlogContent = blog.BlogContent,
                    BlogCreateDate = blog.BlogCreateDate,
                    BlogImg = blog.BlogImg,
                    BlogImgurl = blog.BlogImgurl,
                    BlogStatus = blog.BlogStatus,
                    BlogTitle = blog.BlogTitle,
                    BlogThumbnailImg = blog.BlogThumbnailImg,
                    AppUserId = blog.AppUserId,
                    CategoryID = blog.CategoryID,
                    Category = blog.Category,
                    AppUser = blog.AppUser

                };
                c.Blogs.Update(begeni);
                c.SaveChanges();
                return RedirectToAction("BlogReadAll", new { id = id });
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

      
    }

}
