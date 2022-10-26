using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Giris()
        {
            return View();
        }
        public ActionResult UyeKayit()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
    }
}