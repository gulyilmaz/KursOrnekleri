using Route_Yonlendirme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Route_Yonlendirme.Controllers
{
    public class AccountController : Controller
    {
        kullaniciEntities db = new kullaniciEntities();
        // GET: Account
        [Route("register")]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [Route("register")]
        public ActionResult Register(usertablo user)
        {
            db.usertablo.Add(user);
            db.SaveChanges();
            return RedirectToAction("Profile", new { username = user.firstname });
        }
         [Route("u/{username}")]
        public ActionResult Profile(string username)
        {
            var user = db.usertablo.FirstOrDefault(x => x.firstname == username);
            if (user == null) return new HttpNotFoundResult();
            return View(user);
        }
    }
}