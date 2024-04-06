using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROJECTO_TLP.App_Start.Controllers
{
    public class ContaController : Controller
    {
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // GET: Conta
        public ActionResult Registro()
        {
            return View();
        }
        public ActionResult Registro2()
        {
            return View();
        }

        public ActionResult ConfirmarRegistro()
        {
            return View();
        }
    }
}