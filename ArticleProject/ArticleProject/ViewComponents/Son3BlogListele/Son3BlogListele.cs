using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ArticleProject.ViewComponents.Son3BlogListele
{
    public class Son3BlogListele:ViewComponent
    {
        [AllowAnonymous]
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var sonbloglarbaslik = c.Blogs.OrderByDescending(x=>x.BlogID).Take(3).ToList();
            
            return View(sonbloglarbaslik);
        }
    }
}
