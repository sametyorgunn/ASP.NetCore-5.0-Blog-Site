using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string Hakkimizda_baslik { get; set; }
        public string Hakkimizda_icerik { get; set; }
        public string Hakkimizda_resim_yol { get; set; }
        [NotMapped]
        public IFormFile Hakkimizda_resim { get; set; }
    }
}
