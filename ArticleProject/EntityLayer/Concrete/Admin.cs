using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string usernma { get; set; }
        public string Password { get; set; }
        public string name { get; set; }
        public string shortdescription { get; set; }
        public string imgurl { get; set; }
        public string role { get; set; }
    }
}
