using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Workingwithmodel.Models;

namespace Workingwithmodel.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Product
        public ActionResult Index()
        {
            //List<ProductViewModel> plist = db.Products.Select(x => new ProductViewModel
            //{
            //    ProductId = x.ProductID,
            //    ProductName = x.ProductName,
            //    CategoryName = x.Categories.CategoryName,
            //    categoryId=x.Categories.CategoryID


            //}).ToList();

            var model = new ProductViewModel
            {
                Plist = db.Products.ToList(),
                Clist = db.Categories.ToList()
            };

            return View("Index2",model);
        }
        public ActionResult Demo()
        {
            return View(model: "gül yılmaz");
        }
    }
}