using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminCommentController : Controller
    {
        CommentManager commentmanager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            var values = commentmanager.GetCommentWithBlog();  /*value degiskenimize bloglara göre yorum listesini atayıp ekrana bastım*/
            return View(values);
        }
    }
}
