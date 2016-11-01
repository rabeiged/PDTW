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
                SqlCommand comObjt = new SqlCommand("Login", conObj);
                comObjt.CommandType = CommandType.StoredProcedure;
                comObjt.Parameters.Add(new SqlParameter("@run_user", usuario.run));
                comObjt.Parameters.Add(new SqlParameter("@passw", usuario.password));
                conObj.Open();
                return Convert.ToInt32(comObjt.ExecuteScalar());
            }
        }

        public DataTable InfoUsuario(object run_user)
        {
            using (SqlConnection conObj = new SqlConnection(conStr))
            {
                try
                {
                    SqlDataAdapter adapter;
                    SqlCommand comObjt = new SqlCommand("InformacionUsuario", conObj);
                    comObjt.CommandType = CommandType.StoredProcedure;
                    comObjt.Parameters.Add(new SqlParameter("@run_user", run_user));
                    conObj.Open();

                    adapter = new SqlDataAdapter(comObjt);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    conObj.Close();
                    return dt;
                }
                catch(SqlException ex)
                {
                    return null;
                }
            }
        }
    }
}