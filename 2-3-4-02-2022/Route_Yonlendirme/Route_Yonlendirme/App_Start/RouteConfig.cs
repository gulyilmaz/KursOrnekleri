using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Route_Yonlendirme
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

          /*  routes.IgnoreRoute("{controller}/Index");*///Controllerdan sonra Index aksiyonunu açmaz yok sayar

      //      routes.MapRoute(
      //        name: "About",
      //        url: "about",
      //        defaults: new { controller = "Home", action = "About" }
      //    );
      //      routes.MapRoute(
      //    name: "Contact",
      //    url: "contact-us",
      //    defaults: new { controller = "Home", action = "Contact" }
      //);
      //      routes.MapRoute(
      //    name: "Register",
      //    url: "register",
      //    defaults: new { controller = "Account", action = "Register" }
      //);
            //  routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}-{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
      //      routes.MapRoute(
      //    name: "Profile",
      //    url: "u/{username}",
      //    defaults: new { controller = "Account", action = "Profile" }
      //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
