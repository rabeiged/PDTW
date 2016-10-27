using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WebVialisMVC.Contexto;

namespace WebVialisMVC.Models
{
    public class UserBusinessLogic
    {
        string conStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public int ValidarUsuario(Usuario usuario)
        {
            using (SqlConnection conObj = new SqlConnection(conStr))
            {
                SqlCommand comObjt = new SqlCommand("uspLogin", conObj);
                comObjt.CommandType = CommandType.StoredProcedure;
                comObjt.Parameters.Add(new SqlParameter("@run_user", usuario.run_user));
                comObjt.Parameters.Add(new SqlParameter("@passw", usuario.passw));
                conObj.Open();
                return Convert.ToInt32(comObjt.ExecuteScalar());
            }
        }
    }
}