using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ArticleProject.ViewComponents.WriterNavbar
{
    public class WriterNavbar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var userid = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var imgurl = c.Users.Where(x => x.UserName == username).Select(y => y.imgUrl).FirstOrDefault();
            ViewBag.imgurl = imgurl;
            return View();
        }
    }
}
