using EntityLayer.Concrete;
using System;

namespace ArticleProject.Models
{
    public class CommentDto
    {
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }

        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
