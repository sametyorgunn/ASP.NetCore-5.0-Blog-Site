using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ArticleProject.ViewComponents.YazarProfilBilgileri
{
    public class YazarProfilBilgileri:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c =new Context();
            var username = User.Identity.Name;
            var userimgurl = c.Users.Where(x => x.UserName == username).Select(y => y.imgUrl).FirstOrDefault();
            var namesurname = c.Users.Where(x => x.UserName == username).Select(y => y.namesurname).FirstOrDefault();


            ViewBag.namesurname = namesurname;
            ViewBag.imgurl = userimgurl;

            return View();


        }
    }
}
