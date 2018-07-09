using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Buscar()
        {
            //Se recupera valores
            string nombreProducto = RouteData.Values["nombreProducto"].ToString();
            //Se transforma a texto plano
            nombreProducto = Server.HtmlEncode(nombreProducto);
            string resultado = string.Empty;
            switch (nombreProducto)
            {
                case "PC":
                    resultado = "Disponible 4 unidades";
                    break;
                case "RAM":
                    resultado = "Disponible 2 unidades";
                    break;
                default:
                    resultado = string.Format("El producto {0} no existe en stock", nombreProducto);
                    break;
            }
            return Content("<p>" + resultado + "</p>");
        }
    }
}