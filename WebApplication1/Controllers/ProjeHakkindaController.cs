using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Sınıflar;

namespace WebApplication1.Controllers
{
    public class ProjeHakkindaController : Controller
    {
        // GET: ProjeHakkinda
        Context c = new Context();
        public ActionResult ProjeHakkinda()
        {
            var degerler = c.ProjeHakkindas.ToList();
            return View(degerler);
        }
    }
}