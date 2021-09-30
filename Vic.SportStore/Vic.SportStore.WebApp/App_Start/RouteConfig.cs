using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vic.SportsStore.WebApp
{
    public class RouteConfig
    {

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
            name: null,
            url: "",
            defaults: new { controller = "Products", action = "List", category = (string)null,page = 1 }
            );

            routes.MapRoute(
            name: null,
            url: "Page{page}",
            defaults: new { controller = "Products", action = "List", category = (string)null }
            );

            routes.MapRoute(
           name: null,
           url: "{category}",
           defaults: new { controller = "Products", action = "List", page=1 }
           );

            routes.MapRoute(
          name: null,
          url: "{category}/Page{page}",
          defaults: new { controller = "Products", action = "List"},
          new { page = @"\d+" }

          );

            routes.MapRoute(
            null,
            url: "{controller}/{action}"
            );

            //routes.MapRoute(
            //name: "Default",
            //url: "{controller}/{action}/{id}",
            //defaults: new { controller = "Products", action = "List", id = UrlParameter.Optional }
            //);


        }

    }
}
