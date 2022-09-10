using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ArticleProject.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryManager km = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = km.GetList();
            return View(values);
        }
    }
}
