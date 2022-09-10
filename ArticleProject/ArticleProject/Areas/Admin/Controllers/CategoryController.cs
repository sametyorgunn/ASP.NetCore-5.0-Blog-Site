using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;


namespace ArticleProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        [AllowAnonymous]
        public IActionResult Index(int page = 1)
        { 
            /*kategorileri getlist metodu ile listeleyip values degiskenimize atıyoruz bundan önce indirgimiz xpagedlist kütüphanesi ile safyalama işlemi
             yapabilmek icin topagedlist fonksiyonunun kullanıyoruz.1 degerinden baslayıp fonksyionda tanımladıgımız sayı kadar yani 3 er tane ekranda basılmasını saglıyoruz
            */
            var values = cm.GetList().ToPagedList(page, 3);
            return View(values);
        }


        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category p)
        {

            CategoryValidator cv = new CategoryValidator();
            ValidationResult result = cv.Validate(p);
            if (result.IsValid)
            {

                p.CategoryStatus = true;
                cm.TAdd(p);
                

                return RedirectToAction("Index", "Category");
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

        public IActionResult CategoryDelete(int id)
        {
            var value = cm.TGetById(id);
            cm.TDelete(value);

            return RedirectToAction("Index");
        }

        public IActionResult KategoriPasifYap(int id)
        {
            Context c = new Context();
            var kategori = c.Categories.Find(id);
            kategori.CategoryStatus = false;
            c.SaveChanges();
            return RedirectToAction("Index", "Category", new {Areas="Admin"});
        }
        public IActionResult KategoriAktifYap(int id)
        {
            Context c = new Context();
            var kategori = c.Categories.Find(id);
            kategori.CategoryStatus = true;
            c.SaveChanges();
            return RedirectToAction("Index", "Category", new { Areas = "Admin" });
        }

        public IActionResult KategoriDuzenle(int id)
        {
            var kategori = cm.TGetById(id);
            return View(kategori);
        }
        [HttpPost]
        public IActionResult KategoriDuzenle(Category category)
        {
            CategoryValidator cv = new CategoryValidator();
            ValidationResult result = cv.Validate(category);
            if (result.IsValid)
            {

                category.CategoryStatus = true;
                cm.TUpdate(category);


                return RedirectToAction("Index", "Category");
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
    }

   
}
