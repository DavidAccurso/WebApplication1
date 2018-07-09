using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Persona()
        {
            Models.Persona p = new Models.Persona();
            p.apellido = Request.Form["apellido"];
            p.nombre = Request.Form["nombre"];
            p.edad = int.Parse(Request.Form["edad"]);
            return View(p);
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}