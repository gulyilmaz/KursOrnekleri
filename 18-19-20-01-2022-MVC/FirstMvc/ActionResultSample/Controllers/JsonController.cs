using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ActionResultSample.Controllers
{
    public class Product
    {
        public string name { get; set; }
        public int UnitPrice { get; set; }
    }


    public class JsonController : Controller
    {//Kullanıcıya Json çıktısı üretmek için kullanılır.
        // GET: Json
        public JsonResult Index()
        {
            var products = new List<Product>
            {
                new Product
                {
                     name="laptop",
                      UnitPrice=5000
                },
                new Product
                {
                    name="Mouse",
                      UnitPrice=100
                }

            };
            return Json(products, "application/json", Encoding.UTF8,JsonRequestBehavior.AllowGet);




        }
    }
}