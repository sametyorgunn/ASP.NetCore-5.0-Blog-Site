using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArticleProject.Models;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Authorization;

namespace ArticleProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }

      
       
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public IActionResult PartialAddComment(Comment comment)
        {
            var user = User.Identity.IsAuthenticated;
            var username = User.Identity.Name;
            if (user==true)
            {
                Context c = new Context();
                comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                comment.CommentStatus = true;
                comment.CommentUserName = username;
               
                c.Comments.Add(comment);
                c.SaveChanges();
                return RedirectToAction("BlogReadAll", "Blog", new { id = comment.BlogID });
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

      

        //public PartialViewResult CommentListByBlog(int id)
        //{
        //    var values = cm.GetList(id);
        //    return PartialView(values);
        //}

    }
}
