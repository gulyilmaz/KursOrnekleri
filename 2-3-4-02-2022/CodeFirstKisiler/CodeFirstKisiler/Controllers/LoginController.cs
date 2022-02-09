using CodeFirstKisiler.Models;
using CodeFirstKisiler.Models.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstKisiler.Controllers
{
    public class LoginController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        // GET: Login
        public ActionResult SıgnIn()
        {
            return View(new Kisiler());
        }
        [HttpPost]
        public ActionResult SıgnIn( Kisiler model)
        {
            Kisiler kisi = db.Kisiler.FirstOrDefault(x => x.Ad == model.Ad);
            if (kisi == null)
            {
                ModelState.AddModelError("", "Hatalı kullanıcı adı");
                return View(model);
            }
            else
            {
                Session["login"] = kisi;
                return RedirectToAction("Index", "Home");
            }
        }
    }
}