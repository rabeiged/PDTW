using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.Mvc;
using WebVialisMVC.Models;
using System.Data.SqlClient;
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
                if(UserBL.InfoUsuario(Session["usuario"]) != null)
                {
                    DataTable dt = UserBL.InfoUsuario(Session["usuario"]);

                    // Validando existencia de campo nombre
                    if (dt.Rows[0].Field<string>(0) != null)
                    {
                        ViewData["nombre"] = dt.Rows[0].Field<string>(0);
                    }
                    else
                    {
                        ViewData["nombre"] = "Sin información";
                    }

                    // Validando existencia de campo sexo
                    if (dt.Rows[0].Field<string>(1) != null)
                    {
                        if (dt.Rows[0].Field<string>(1) == "M")
                        {
                            ViewData["sexo"] = "Masculino";
                        }
                        else
                        {
                            ViewData["sexo"] = "Femenino";
                        }
                    }
                    else
                    {
                        ViewData["sexo"] = "Sin información";
                    }

                    // Validando existencia de campo fecha de nacimiento
                    if (dt.Rows[0].Field<DateTime>(2) != null)
                    {
                        ViewData["fecnac"] = dt.Rows[0].Field<DateTime>(2).ToShortDateString();
                    }
                    else
                    {
                        ViewData["fecnac"] = "Sin información";
                    }

                    // Validando existencia de campo direccion
                    if (dt.Rows[0].Field<string>(3) != null)
                    {
                        ViewData["direccion"] = dt.Rows[0].Field<string>(3);
                    }
                    else
                    {
                        ViewData["direccion"] = "Sin información";
                    }

                    // Validando existencia de campo ecivil
                    if (dt.Rows[0].Field<string>(4) != null)
                    {
                        ViewData["ecivil"] = dt.Rows[0].Field<string>(4);
                    }
                    else
                    {
                        ViewData["ecivil"] = "Sin información";
                    }

                    // Validando existencia de campo id trabajador
                    if (dt.Rows[0].Field<decimal>(5) != 0)
                    {
                        ViewData["id"] = dt.Rows[0].Field<decimal>(5);
                    }
                    else
                    {
                        ViewData["id"] = "Sin información";
                    }

                    // Validando existencia de campo profesion
                    if (dt.Rows[0].Field<string>(6) != null)
                    {
                        ViewData["profesion"] = dt.Rows[0].Field<string>(6);
                    }
                    else
                    {
                        ViewData["profesion"] = "Sin información";
                    }

                    ViewData["usuario"] = Session["usuario"];
                    Session["nombre"] = ViewData["nombre"];
                }

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

        // Buscar proyecto
        [HttpPost]
        public ActionResult Buscar(string proyecto)
        {
            string message = "";

            if (string.IsNullOrEmpty(proyecto))
            {
                message = "Debe ingresar el código del proyecto.";
                return View();
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
            if(string.IsNullOrEmpty(usuario.run) || string.IsNullOrEmpty(usuario.password))
            {
                message = "Todos los campos requeridos.";
            }
            else
            {
                // Validación de usuario
                if(UserBL.ValidarUsuario(usuario) > 0)
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

        // Cerrar sesión de usuario
        [HttpPost]
        public ActionResult Logout()
        {
            Session["usuario"] = null;
            return RedirectToAction("Login", "Trabajador");
        }
    }
}