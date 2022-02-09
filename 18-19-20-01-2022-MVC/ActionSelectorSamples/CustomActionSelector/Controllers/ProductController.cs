using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CustomActionSelector.Controllers
{public class Product
    {
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
    }

    public class ProductController : Controller
    {
        public class AjaxMethodAttribute : ActionMethodSelectorAttribute
        {
            public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
            {
                return controllerContext.HttpContext.Request.IsAjaxRequest();
            }
        }
        public class ActionLengthAttribute : ActionNameSelectorAttribute
        {
            private int _length;
            public ActionLengthAttribute(int length)
            {
                _length = length;

            }
            public override bool IsValidName(ControllerContext controllerContext, string actionName, MethodInfo methodInfo)
            {
                return actionName.Length <= _length;
            }
        }

        public ActionResult Index()
        {
            return View();
        }
        // GET: Product
        [AjaxMethod]
        public JsonResult GetAll()
        {
            var products =new  List<Product>{
                new Product
                {
                     ProductName="laptop",
                      UnitPrice=7000
                },
                new Product
                {
                     ProductName="tablet",
                      UnitPrice=3000
                }
            };
            return Json(products, JsonRequestBehavior.AllowGet);
        }
        [ActionLength(3)]
        [ActionName("ab")]
        public ActionResult test()
        {
            return Content("test");
        }
    }
}