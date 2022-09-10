using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ArticleProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class AdminUyeKayitOnayController : Controller
    {
        private readonly UserManager<AppUser> _usermanager;

        public AdminUyeKayitOnayController(UserManager<AppUser> usermanager)
        {
            _usermanager = usermanager;
        }

        public IActionResult Index()
        {  
            /*context ten c nesnesi olustrup nesnemiz ile kullanıcılar tablosuna erişip statu degeri 0 olanları listeleyip uyeonaylistesi isimli degiskene atıyoruz.
             ve ekranda gösteriyotuz.*/
            Context c = new Context();
            var uyeonaylistesi = c.Users.Where(x => x.Status == 0).ToList();
            return View(uyeonaylistesi);
        }

        public IActionResult AktifYap(int id)
        {
            /*aktif yap butonu ile gonderilen id degerini parametre olarak atanan id ile çekip
             user tablosunda find metodu ile bu id ye ait kişiyi bulup
            statusunu 1 yapıyoruz yani aktif yapmış oluyoruz.
            degerlerimizi kaydedip 
            yonlendirmemeizi yapıyoruz.*/
            using (Context c = new Context())
            {
                var kisi = c.Users.Find(id);
                kisi.Status = 1;
                c.SaveChanges();
                return RedirectToAction("Index", "AdminUyeKayitOnay");
            }
           
            
        }
    }
}
