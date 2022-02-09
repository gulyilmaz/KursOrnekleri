using Filters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Filtreler
{
    public class RestFilter : FilterAttribute, IResultFilter
    {//viewin oluşmadan öncesi ve sonrasında içerisinde yazan kodların çalışmasını sağlar
        DatabaseContext db = new DatabaseContext();
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            db.Logs.Add(new Log()
            {
                KullaniciAdi = (filterContext.HttpContext.Session["login"] as SiteUser).KullaniciAdi,
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                 Tarih=DateTime.Now,
                 Bilgi= "OnResultExecuted"

            })  ;
            db.SaveChanges();
            
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            db.Logs.Add(new Log()
            {
                KullaniciAdi = /*"System"*/
                 (filterContext.HttpContext.Session["login"] as SiteUser).KullaniciAdi,
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                Tarih = DateTime.Now,
                Bilgi = "OnResultExecuting"

            });
            db.SaveChanges();
        }
    }
}