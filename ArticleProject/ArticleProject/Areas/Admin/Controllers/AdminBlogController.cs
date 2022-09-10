using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ArticleProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]   /*tüm controller a authorize işlemi tanımlayıp sadece admin rolündeki kişilerin erişmesini sağlıyoruz.*/
    public class AdminBlogController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        BlogManager blogmanager = new BlogManager(new EfBlogRepository());
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());

        public AdminBlogController(IWebHostEnvironment webHost)
        {
            _webHost = webHost;
        }

        public IActionResult Index()
        {
            var values = blogmanager.GetBlogListWithCategory(); /*kategoriye gore blogları getirebilmek için tanımladıgımız GetBlogListWithCategory fonksiyonumuz ile 
                                                                 verileri cekip values değişkenimize attık ve bu degerleri return view ile ekrana bastık */
            return View(values);
        }
        public IActionResult HakkimizdaEkle()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> HakkimizdaEkle(About about)
        {
            /*hakkımızda ekle sayfasında about classımızı tanımlayıp dosya yani resim eklemek icin fonksiyonlarımızı tanımladık
             Tadd metodumumuız ile degerlerimizi ekleyip redirettoaction ile yonlendirmemizizi yaptık*/
            if(ModelState.IsValid)
            {
                string wwwRootPath = _webHost.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(about.Hakkimizda_resim.FileName);
                string extension = Path.GetExtension(about.Hakkimizda_resim.FileName);
                about.Hakkimizda_resim_yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/HakkimizdaResim/", filename);
                using (var filestream = new FileStream(path, FileMode.Create))
                {
                    await about.Hakkimizda_resim.CopyToAsync(filestream);
                }
                aboutManager.TAdd(about);
                return RedirectToAction("HakkimizdaListele", "AdminBlog", new { Areas = "Admin" });
            }
            return View();
        }

        public IActionResult HakkimizdaListele()
        {
            var hakkimizda = aboutManager.GetList();
            return View(hakkimizda);
        }

        public IActionResult HakkimizdaDuzenle(int id )
        {
            /*id parametresini tanımlayıp gönderdigimiz id degerini çekiyoruz ve tgetbyid metodumuz ile id ye ait hakkımızzda degerini getiriyoruz*/
            var duzenlenecek = aboutManager.TGetById(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public async Task<IActionResult> HakkimizdaDuzenle(About about)
        {    /*ekleme işleminde yaptıgımız işlemlerin aynısını gerçeklestirip update metodu ile verilerimizi güncellestiriyoruz.
              verimizi guncellestirebilmek için viewimmizde model den mevcut veriler value degerlerimize yerleştirip guncellestirdik.*/
            if(ModelState.IsValid)
            {
                string wwwRootPath = _webHost.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(about.Hakkimizda_resim.FileName);
                string extension = Path.GetExtension(about.Hakkimizda_resim.FileName);
                about.Hakkimizda_resim_yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/HakkimizdaResim/", filename);
                using (var filestream = new FileStream(path, FileMode.Create))
                {
                    await about.Hakkimizda_resim.CopyToAsync(filestream);
                }
                aboutManager.TUpdate(about);
                return RedirectToAction("HakkimizdaListele", "AdminBlog", new { Areas = "Admin" });
            }
            return View();
        }
        public IActionResult HakkimizdaSil(int id)
        {
            /*listelemee sayfasında sil butonu ile gönderdigimiz id degerini atadıgımız id parametresine atadık silinecek degeri tgetbyid metodu ile bulup
             tdelete ile sildik*/
            var silinecek = aboutManager.TGetById(id);
            aboutManager.TDelete(silinecek);
            return RedirectToAction("HakkimizdaListele", "AdminBlog", new { Areas = "Admin" });
        }

        public IActionResult BlogPasifYap(int id)
        {
            /*gonderilen id degerini parametre olarak verilen id degerine alıp 
             blog tablosunda find metodu ile id ye ait blogu buluyoruz.
            ve bu blogun statu degerini false yapıp 
            savechanges ile kaydediyoruz.*/

            Context c = new Context();
            var blog = c.Blogs.Find(id);
            blog.BlogStatus = false;
            c.SaveChanges();
         
            return RedirectToAction("Index", "AdminBlog", new { Areas = "Admin" });
        }
        public IActionResult BlogAktifYap(int id)
        {
            /*gonderilen id degerini parametre olarak verilen id degerine alıp 
             blog tablosunda find metodu ile id ye ait blogu buluyoruz.
            ve bu blogun statu degerini true yapıp 
            savechanges ile kaydediyoruz.*/

            Context c = new Context();
            var blog = c.Blogs.Find(id);
            blog.BlogStatus = true;
            c.SaveChanges();

            return RedirectToAction("Index", "AdminBlog", new { Areas = "Admin" });
        }
    }
}
