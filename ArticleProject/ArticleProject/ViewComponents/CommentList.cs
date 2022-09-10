using Microsoft.AspNetCore.Mvc;
using ArticleProject.Models;
using System.Collections.Generic;

namespace ArticleProject.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    Username = "samet"
                },
                new UserComment
                {
                    Id = 2,
                    Username = "serkan"
                },
                new UserComment
                {
                    Id = 3,
                    Username = "aslan"
                }
            };
            return View(commentvalues);
        }
    }
}
