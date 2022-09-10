using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.ViewComponents.Category
{
    public class CategoryListDashboard:ViewComponent
    {
        CategoryManager km = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = km.GetList();
            return View(values);
        }
    }
}
