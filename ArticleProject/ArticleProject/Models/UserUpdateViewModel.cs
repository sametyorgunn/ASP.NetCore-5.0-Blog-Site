using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArticleProject.Models
{
    public class UserUpdateViewModel
    {
        public string namesurname { get; set; }
        public string username { get; set; }
        public string mail { get; set; }
        public string imgurl { get; set; }
        [NotMapped]
        public IFormFile img { get; set; }
        public string password { get; set;
        }

    }
}
