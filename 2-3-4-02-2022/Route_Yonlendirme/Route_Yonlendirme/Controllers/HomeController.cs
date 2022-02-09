using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Route_Yonlendirme.Controllers
{[RoutePrefix("Main")]//ön ek olarak yazar
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            return View();
        }
        [Route("~/about")]//main ifadesini başa eklemez
        public ActionResult About()
        {
            return View();
        }
        [Route("contact-us")]
        public ActionResult Contact()
        {

            return View();
        }
        [Route("~/demo/{number=1}/{id?}")]
        public ActionResult demo(int number,int? id)
        {
            return Content(string.Format("Number={0} <br/> Id={1}", number, id.HasValue ? id.ToString() : "null"));
        }
    }
}