using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Vic.SportsStore.WebApp.Infrastructure.Binders;
using Vic.SportStore.Domain.Entities;

namespace Vic.SportsStore.WebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            IocConfig.ConfigIoc();
            ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());
        }
    }
}
