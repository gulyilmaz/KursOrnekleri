using sinav.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sinav.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        sinavdbEntities db = new sinavdbEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(iletisim i)
        {
            iletisim kisi = new iletisim();
            kisi = i;
            db.iletisim.Add(kisi);
            db.SaveChanges();
           
            return RedirectToAction("Index", "Home");
        }
    }
}