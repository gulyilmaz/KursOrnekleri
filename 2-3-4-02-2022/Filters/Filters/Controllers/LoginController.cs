using Filters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Controllers
{
    public class LoginController : Controller
    { DatabaseContext db = new DatabaseContext();
        // GET: Login
        public ActionResult SignIn()
        {
            return View(new SiteUser());
        }
        [HttpPost]
        public ActionResult SignIn(SiteUser model)
        {
            SiteUser user = db.SiteUsers.FirstOrDefault(x => x.KullaniciAdi == model.KullaniciAdi && x.sifre == model.sifre);
            if (user == null)
            {
                ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
                return View(model);
            }
            else
            {
                Session["login"] = user;
                return RedirectToAction("Index", "Home");
            }


          
        }


        public ActionResult Error()
        {
            if (TempData["error"] == null)
            {
                return RedirectToAction("Index", "Home");

            }
            Exception model = TempData["error"] as Exception;
            return View(model);


        }
    }
}