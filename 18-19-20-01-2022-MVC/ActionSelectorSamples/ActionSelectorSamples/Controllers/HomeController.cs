using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionSelectorSamples.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [ActionName("Indexdemo")]//Aksiyon ismini değiştirir
        public ActionResult Index()
        {
            return View("Index");
        }

        [NonAction]//Metodun public olmak zorunda ama aksiyon olmasını istemiyorsam başına bunu koyarım
        public string GetConnectionstring()
        {
            return "db bağlantısı";
        }
       // [HttpGet]
        //[HttpPost]
        // [AcceptVerbs(HttpVerbs.Get)]
        // [AcceptVerbs(HttpVerbs.Post)]
       // [AcceptVerbs(HttpVerbs.Post|HttpVerbs.Get)]
       [AcceptVerbs("Post","Get","Put")]///gelen isteğin türüne göre filtreleme yapar
        public ActionResult something()
        {
            return Content("Aksiyondan mesaj");
        }
    }
}