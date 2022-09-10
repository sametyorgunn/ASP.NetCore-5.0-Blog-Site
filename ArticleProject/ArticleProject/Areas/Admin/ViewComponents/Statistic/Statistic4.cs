using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace ArticleProject.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.admins.Where(x => x.AdminId == 1).Select(y => y.name).FirstOrDefault();
            ViewBag.v2 = c.admins.Where(x => x.AdminId == 1).Select(y => y.imgurl).FirstOrDefault();
            ViewBag.v3 = c.admins.Where(x => x.AdminId == 1).Select(y => y.shortdescription).FirstOrDefault();

            
            return View();
        }
    }
}
