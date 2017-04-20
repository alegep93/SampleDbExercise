using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SampleDbExercise.DAO
{
    public class BaseDAO
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection cn = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ShippingExample"].ConnectionString;
                cn = new SqlConnection(connectionString);
                cn.Open();
            }
            catch (Exception ex)
            {
                String msg = "Si è verificato un errore durante la creazione della connessione col DB";
                throw new Exception(msg, ex);
            }
            return cn;
        }
    }
}