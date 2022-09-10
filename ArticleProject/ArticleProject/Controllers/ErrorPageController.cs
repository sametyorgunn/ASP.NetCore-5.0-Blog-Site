using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1()
        {
            return View();
        }
    }
}
