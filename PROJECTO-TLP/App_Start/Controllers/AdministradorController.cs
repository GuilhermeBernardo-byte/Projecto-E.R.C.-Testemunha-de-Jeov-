using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROJECTO_TLP.App_Start.Controllers
{
    public class AdministradorController : Controller
    {
        // GET: Administrador
        public ActionResult PaginaInicial()
        {
            return View();
        }

        public ActionResult PaginaPublicadores()
        {
            return View();
        }
    }
}