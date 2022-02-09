using MvcCategories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCategories.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Product
        public ActionResult Liste()
        {
            List<ProductsModel> plist = db.Products.Select(x => new ProductsModel
            {
                ProductId = x.ProductID,
                ProductName=x.ProductName,
                CategoryName=x.Categories.CategoryName,
                UnitPrice=(decimal)(x.UnitPrice)

            }).ToList();

            return View(plist);

        }
    }
}