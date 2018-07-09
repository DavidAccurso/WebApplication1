using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             name: "Default",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Persona", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Producto",
                url: "Buscar/{nombreProducto}",
                defaults: new { controller = "Producto", action = "Buscar", nombreProducto = "" }
            );

            routes.MapRoute(
                name: "Buscar",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Producto", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
