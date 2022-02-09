using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultSample.Controllers
{
    public class ViewController : Controller
    {//view kullanarak html sayfaları render edeceğimiz durumda kullanılır.
        // GET: View
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Index2()
        {
            return View();
        }
        public ViewResult Index3()
        {
            return View("Index");
        }
    }
}