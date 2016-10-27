using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVialisMVC.Contexto;

namespace WebVialisMVC.Controllers
{
    public class TrabajadorController : Controller
    {
        UserBusinessLogic UserBL = new UserBusinessLogic();

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        // Validación inicio de sesión
        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            string message = "";
            if(ModelState.IsValid)
            {
                if(UserBL.ValidarUsuario(usuario) > 0)
                {
                    message = "Success";
                    return RedirectToAction("Informacion", "Trabajador");
                }
                else
                {
                    message = "Usuario o contraseña incorrectos.";
                }
            }
            else
            {
                message = "Todos los campos requeridos.";
            }
            if(Request.IsAjaxRequest())
            {
                return Json(message, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return RedirectToAction("Informacion", "Trabajador");
            }
        }
    }
}