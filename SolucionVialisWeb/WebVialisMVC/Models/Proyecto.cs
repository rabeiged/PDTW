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
    public class Proyecto
    {
        // String de conexión
        string conStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public DataTable BuscarProyecto(string proyecto)
        {
            using (SqlConnection conObj = new SqlConnection(conStr))
            {
                try
                {
                    SqlDataAdapter adapter;
                    SqlCommand comObjt = new SqlCommand("BuscarProyecto", conObj);
                    comObjt.CommandType = CommandType.StoredProcedure;
                    comObjt.Parameters.Add(new SqlParameter("@proyecto", proyecto));
                    conObj.Open();

                    adapter = new SqlDataAdapter(comObjt);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    conObj.Close();
                    return dt;
                }
                catch (SqlException ex)
                {
                    return null;
                }
            }
        }

        public DataTable BuscarProyectosPorFecha(DateTime fecha1, DateTime fecha2)
        {
            using (SqlConnection conObj = new SqlConnection(conStr))
            {
                try
                {
                    SqlDataAdapter adapter;
                    SqlCommand comObjt = new SqlCommand("BuscarProyectosPorFecha", conObj);
                    comObjt.CommandType = CommandType.StoredProcedure;
                    comObjt.Parameters.Add(new SqlParameter("@fecha1", fecha1));
                    comObjt.Parameters.Add(new SqlParameter("@fecha2", fecha2));
                    conObj.Open();

                    adapter = new SqlDataAdapter(comObjt);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    conObj.Close();
                    return dt;
                }
                catch (SqlException ex)
                {
                    return null;
                }
            }
        }
    }
}