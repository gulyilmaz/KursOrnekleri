using Modeldb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Modeldb.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Product
        public ActionResult Liste()
        {
            MultiModel model = new MultiModel();
            model.clist = db.Categories.ToList();
            model.plist = db.Products.ToList();
            return View(model);
           
        }
    }
}