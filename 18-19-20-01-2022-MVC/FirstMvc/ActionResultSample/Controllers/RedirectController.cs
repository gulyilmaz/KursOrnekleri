using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultSample.Controllers
{
    public class RedirectController : Controller
    {//Bir url aracılığıyla hem uygulama içinde hem deuygulama dışında yönlendirme işlemi yapmak için kullanılır
        // GET: Redirect
        public ActionResult Index()
        {
            return View();
        }
        public RedirectResult Index2()
        {
            // return Redirect("~/view");
            return Redirect("http://microsoft.com");
        }
        // redirecttoAction metodu ile sadece uygulama içerisindeki sayfalara yönlendirme gerçekleştirilir
        public ActionResult Index3()
        {
            //  return RedirectToAction("Index");
            // return RedirectToAction("Index", "View");
           // return RedirectToAction("Index", new { controller = "View", id = 5 });
           return RedirectToRoute("Default",new {controller="View", action="Index2" });

        }
    }
}