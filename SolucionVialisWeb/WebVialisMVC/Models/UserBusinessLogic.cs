using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WebVialisMVC.Models;

namespace WebVialisMVC.Models
{
    public class UserBusinessLogic
    {
        // String de conexión
        string conStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        // Función validación de usuario (Devuelve 1 si es correcto)
        public int ValidarUsuario(Usuario usuario)
        {
            using (SqlConnection conObj = new SqlConnection(conStr))
            {
                // LLamado a procedure que valida usuarios
                SqlCommand comObjt = new SqlCommand("uspLogin", conObj);
                comObjt.CommandType = CommandType.StoredProcedure;
                comObjt.Parameters.Add(new SqlParameter("@run_user", usuario.run));
                comObjt.Parameters.Add(new SqlParameter("@passw", usuario.password));
                conObj.Open();
                return Convert.ToInt32(comObjt.ExecuteScalar());
            }
        }
    }
}