using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ArticleProject.Controllers
{
    [Authorize(Roles ="Writer,Admin")]
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        
        public IActionResult Index()
        {

            Context c = new Context();

            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var userimageurl = c.Users.Where(x => x.UserName == username).Select(y => y.imgUrl).FirstOrDefault();

            var userid = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();

            ViewBag.v1 = c.Blogs.Count().ToString();
            ViewBag.v2 = c.Blogs.Where(x => x.AppUserId == userid).Count();
            ViewBag.v3 = c.Categories.Count().ToString();
            ViewBag.v4 = userimageurl;
            return View();
        }
    }
}
