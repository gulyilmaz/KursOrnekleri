using Filters.Filtreler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {[ActFilter,RestFilter,AuthFilter]
        // GET: Home
        public ActionResult Index()
        {//loga insert
         //kodlar
         //loga insert
            return View();
          
        }
        [ActFilter, RestFilter, AuthFilter,ExcFilter]
        public ActionResult Index2()
        {
            object sayi = 0;
            int deger = 100/(int)sayi;
            return View();
        }
        [ActFilter, RestFilter, AuthFilter,ExcFilter]
        public ActionResult Index3()
        {
            return View();
        }
    }
}