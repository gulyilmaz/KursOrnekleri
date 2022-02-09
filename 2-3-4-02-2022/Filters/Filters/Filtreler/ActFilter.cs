using Filters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Filtreler
{
    public class ActFilter : FilterAttribute, IActionFilter
    {
        DatabaseContext db = new DatabaseContext();
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {//çalıştıktan sonra
            db.Logs.Add(new Log()
            {
                KullaniciAdi =  (filterContext.HttpContext.Session["login"] as SiteUser).KullaniciAdi,

                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Tarih = DateTime.Now,
                Bilgi = "OnActionExecuted"

            });
            db.SaveChanges();


        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {//çalışmadan önce yapılcaklar
            db.Logs.Add(new Log()
            {
                KullaniciAdi = (filterContext.HttpContext.Session["login"] as SiteUser).KullaniciAdi,
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Tarih = DateTime.Now,
                Bilgi = "OnActionExecuting"

            });
            db.SaveChanges();
        }
    }
}