using System.ComponentModel.DataAnnotations;

namespace ArticleProject.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="lütfen rol giriniz")]
        public string name { get; set; }
    }
}
