using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string namesurname { get; set; }
        public string imgUrl { get; set; }
        public int Status { get; set; }
        [NotMapped]
        public IFormFile img { get; set; }
        public List<Blog> blogs { get; set; }
    }
}
