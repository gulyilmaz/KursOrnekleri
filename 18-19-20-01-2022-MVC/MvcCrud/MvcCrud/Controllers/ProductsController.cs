using MvcCrud.Models;
using MvcCrud.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCrud.Controllers
{
    public class ProductsController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        ProductsModel pm = new ProductsModel();
        // GET: Products
        public ActionResult Liste(string name)
        {
            if (name == null)
            {
                name = "";
            }
            pm.plist = db.Products.Where(x => x.ProductName.Contains(name)).Select(x => new ProductsDto
            {
                CategoryName = x.Categories.CategoryName,
                CompanyName = x.Suppliers.CompanyName,
                ProductId = x.ProductID,
                ProductName = x.ProductName,
                Discontinued = x.Discontinued,
                UnitPrice = (decimal)x.UnitPrice
            }).ToList();
            return View(pm);
        }
        public ActionResult Detay(int id)
        {
            pm.Products = db.Products.Find(id);
            return View(pm);

        }
        [HttpGet]
        public ActionResult Guncel(int id)
        {
            pm.Products = db.Products.Find(id);
            pm.CategoriesForDropDown = DoldurCategory();
            pm.SupliersForDropDown = DoldurSup();
            return View(pm);
        }
        [HttpPost]
        public ActionResult Guncel(int id,ProductsModel pm)
        {
            if (ModelState.IsValid)
            {
                Products secproducts = db.Products.Find(id);
                secproducts.ProductName = pm.Products.ProductName;
                secproducts.SupplierID = pm.Products.SupplierID;
                secproducts.CategoryID = pm.Products.CategoryID;
                secproducts.UnitPrice = pm.Products.UnitPrice;
                db.SaveChanges();
                return RedirectToAction("Liste");
            }



            return View();

            //db.Entry(pm.Products).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();
            //return RedirectToAction("Liste");
        }
        [HttpGet]
        public ActionResult Ekle()
        {pm.SupliersForDropDown= DoldurSup();
            pm.CategoriesForDropDown = DoldurCategory();
            return View(pm);
        }







        private List<SelectListItem> DoldurSup()
        {
            return db.Suppliers.Select(x => new SelectListItem()
            {
                Text = x.CompanyName,
                Value = x.SupplierID.ToString()
            }).ToList();
        }

        private List<SelectListItem> DoldurCategory()
        {
            return db.Categories.Select(x => new SelectListItem()
            {
                Text = x.CategoryName,
                Value = x.CategoryID.ToString()
            }).ToList();
        }
    }
}