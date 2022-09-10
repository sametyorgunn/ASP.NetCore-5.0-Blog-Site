using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ArticleProject.Areas.Admin.Models;
using System.Collections.Generic;
using System.Linq;

namespace ArticleProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class WriterController : Controller
    {
        UserManager userManager = new UserManager(new EfUserRepository());
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            var yazarlar = userManager.GetList();
            return View(yazarlar);
        }

        public IActionResult YazarPasifYap(int id)
        {
            Context c = new Context();
            var yazar = c.Users.Find(id);
            yazar.Status = 0;
            c.SaveChanges();
            return RedirectToAction("Index", "Writer", new { Areas = "Admin" });
        }
        public IActionResult YazarAktifYap(int id)
        {
            Context c = new Context();
            var yazar = c.Users.Find(id);
            yazar.Status = 1;
            c.SaveChanges();
            return RedirectToAction("Index", "Writer", new { Areas = "Admin" });
        }
        public IActionResult writerlist()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }
        public IActionResult writergetbyId(int writerid)
        {
            var findwriter = writers.FirstOrDefault(x => x.Id == writerid);
            var jsonWriters = JsonConvert.SerializeObject(findwriter);
            return Json(jsonWriters);
        }

        [HttpPost]
        public IActionResult AddWriter(WriterClass w)
        {
            writers.Add(w);
            var jsonwriters = JsonConvert.SerializeObject(w);
            return Json(jsonwriters);

        }

        public IActionResult DeleteWriter(int id)
        {
            var writer = writers.FirstOrDefault(x => x.Id == id);
            writers.Remove(writer);
            return Json(writer);
        }

        public IActionResult UpdateWriter(WriterClass w)
        {
            var writer = writers.FirstOrDefault(x => x.Id == w.Id);
            writer.name = w.name;
            var jsonWriter = JsonConvert.SerializeObject(w);
            return Json(jsonWriter);

        }


        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                Id = 1,
                name="Ayse"
            },
            new WriterClass
            {
                Id = 2,
                name="ahmet"
            },
            new WriterClass
            {
                Id = 3,
                name="ali"
            },
        };
    }
}
