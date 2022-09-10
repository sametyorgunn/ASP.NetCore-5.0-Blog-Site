using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ArticleProject.ViewComponents.Son10blogListele
{
    public class Son10blogListele:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var son10blog = c.Blogs.OrderByDescending(x => x.BlogID).Take(10).ToList();

            return View(son10blog);
        }
    }
}
