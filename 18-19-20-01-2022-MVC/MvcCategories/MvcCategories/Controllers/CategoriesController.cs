using MvcCategories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCategories.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Liste()
        {
            List<Categories> clist = db.Categories.ToList();
            return View(clist);
        }
    }
}