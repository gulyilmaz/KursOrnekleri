using sinav.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sinav.Controllers
{
    public class HomeController : Controller
    {
        sinavdbEntities db = new sinavdbEntities();
        // GET: Home
        public ActionResult Index()
        {
            ProductsModelView model = new ProductsModelView();
            model.Ulist = db.Urunler.ToList();
            model.Klist = db.Kategori.ToList();
            return View(model);
        }
    }
}