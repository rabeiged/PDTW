using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVialisMVC.Models;
using System.Web.Script.Serialization;

namespace WebVialisMVC.Controllers
{
    public class TrabajadorController : Controller
    {
        UserBusinessLogic UserBL = new UserBusinessLogic();

        // GET: Login
        public ActionResult Login()
        {
            if (Session["usuario"] != null)
            {
                return RedirectToAction("Informacion", "Trabajador");
            }
            else
            {
                return View();
            }
        }

        // GET: Informacion
        public ActionResult Informacion()
        {
            // Restricción a vistas (sesión iniciada)
            if (Session["usuario"] == null)
            {
                return RedirectToAction("Login", "Trabajador");
            }
            else
            {
                return View();
            }
        }

        //GET: Liquidaciones
        public ActionResult Liquidaciones()
        {
            // Restricción a vistas (sesión iniciada)
            if (Session["usuario"] == null)
            {
                return RedirectToAction("Login", "Trabajador");
            }
            else
            {
                return View();
            }
        }

        // Validación inicio de sesión
        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            string message = "";
            // Validación campos vacíos
            if (string.IsNullOrEmpty(usuario.run) || string.IsNullOrEmpty(usuario.password))
            {
                message = "Todos los campos requeridos.";
                
            }
            else
            {
                // Validación de usuario
                if (UserBL.ValidarUsuario(usuario) > 0)
                {
                    message = "Success";
                    Session["usuario"] = usuario.run;
                }
                else
                {
                    message = "Usuario o contraseña incorrectos.";
                }
            }
            // Envío de JSON
            if(Request.IsAjaxRequest())
            {
                return Json(message, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return RedirectToAction("Login", "Trabajador");
            }
        }

        [HttpPost]
        public ActionResult Logout()
        {
            Session["usuario"] = null;
            return RedirectToAction("Login", "Trabajador");
        }
    }
}