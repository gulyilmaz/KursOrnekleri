using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultSample.Controllers
{
    public class JavascriptController : Controller
    {// Client tarafında direk çalışacak js kodları üretmek için kullanılır
        // GET: Javascript
        public ActionResult Index()
        {
            return View();
        }
        public JavaScriptResult Alert()
        {
            return JavaScript("alert('Deneme');");
        }
    }
}