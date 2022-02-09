using MvcCrud.Models;
using MvcCrud.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCrud.Controllers
{
    public class CategoriesController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        CategoriesModel model = new CategoriesModel();
        // GET: Categories
        public ActionResult Liste(string name)
        {
            if (name == null)
            {
                name = "";
            }
            model.clist = db.Categories.Where(x => x.CategoryName.Contains(name)).ToList();
            return View(model);
        }
        public ActionResult Detay(int id)
        {
            model.categories = db.Categories.Find(id);
            return View(model);
        }
        [HttpGet]
        public ActionResult Guncel(int id)
        {
            model.categories = db.Categories.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Guncel(int id,CategoriesModel cm)
        {
            if (ModelState.IsValid)
            {
                Categories seccategory = db.Categories.Find(id);
                seccategory.CategoryName = cm.categories.CategoryName;
                seccategory.Description = cm.categories.Description;
                db.SaveChanges();
                return RedirectToAction("Liste");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Sil(int id)
        {
            model.categories = db.Categories.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Sil(int id,bool deger=true)
        {
            Categories c = db.Categories.Find(id);
            db.Categories.Remove(c);
            db.SaveChanges();

            return RedirectToAction("Liste");
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(CategoriesModel cm)
        {
            db.Entry(cm.categories).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("Liste");
        }
    }
}