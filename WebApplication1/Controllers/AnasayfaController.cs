using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Sınıflar;

namespace WebApplication1.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        Context c = new Context();
        public ActionResult Anasayfa()
        {
            var degerler = c.Anasayfas.ToList();
            return View(degerler);
        }
        public ActionResult YemekDetay(int id)
        {
            var blogbul = c.Anasayfas.Where(x => x.ID == id).ToList();
            return View(blogbul);
        }
    }
}
