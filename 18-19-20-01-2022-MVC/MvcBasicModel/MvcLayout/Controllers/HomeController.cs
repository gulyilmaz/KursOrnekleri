using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLayout.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            List<hakkimizda> hlist = new List<hakkimizda>();
            hakkimizda h = new hakkimizda();
            h.Ad = "gül";
            h.Soyad = "yılmaz";
            hlist.Add(h);
            hakkimizda h2 = new hakkimizda();
            h2.Ad = "Şeyda";
            h2.Soyad = "Ateş";
            hlist.Add(h2);
            return View(hlist);
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Ref()
        {
            return View();
        }
        public ActionResult Proje()
        {
            return View();
        }

    }
}