using sinav.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sinav.Controllers
{
    public class AboutController : Controller
    {
        sinavdbEntities db = new sinavdbEntities();
        // GET: About
        public ActionResult Index()
        {
            ProductsModelView model = new ProductsModelView();
            model.Hlist = db.Hakkimizda.ToList();
            
           

            return View(model);
        }
        public ActionResult Tarihce()
        {
            ProductsModelView model = new ProductsModelView();
            model.Olist = db.ozellik.ToList();
            model.tarihce = db.tarihce.FirstOrDefault();


            return View(model);
        }


    }
}