using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ActionResultSample.Controllers
{
    public class HttpController : Controller
    {//htttp durum kodlarını report etmek için kullanılır
        // GET: Http
        public HttpStatusCodeResult Index()
        {
            // return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            // return new HttpStatusCodeResult(HttpStatusCode.BadRequest,"Bad Gateway hatası");
            return new HttpStatusCodeResult(404);
        }
        public HttpUnauthorizedResult Index2()
        {
            // return new HttpUnauthorizedResult();
            return new HttpUnauthorizedResult("Yetkili değilsiniz");
        }
        public HttpNotFoundResult Index3()
        {
            //   return HttpNotFound();
            return HttpNotFound("Sorry!This page not found");
        }
    }
}