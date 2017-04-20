using SampleDbExercise.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace SampleDbExercise.DAO
{
    public class SupplierDAO : BaseDAO
    {
        public static List<Supplier> GetSupplierList()
        {
            List<Supplier> supplierList = new List<Supplier>();
            SqlConnection cn = BaseDAO.GetConnection();
            SqlDataReader dr = null;
            StringBuilder sql = new StringBuilder();

            try
            {
                sql.Append("SELECT Id,ContactName,CompanyName,ContactTitle,City,Country,Phone,Fax ");
                sql.Append("FROM Supplier ");
                sql.Append("ORDER BY ContactName ASC ");

                SqlCommand cmd = new SqlCommand(sql.ToString(), cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Supplier s = new Supplier();
                    s.Id            = (dr.IsDBNull(0) ? -1   : dr.GetInt32(0));
                    s.ContactName   = (dr.IsDBNull(1) ? null : dr.GetString(1));
                    s.CompanyName   = (dr.IsDBNull(2) ? null : dr.GetString(2));
                    s.ContactTitle  = (dr.IsDBNull(3) ? null : dr.GetString(3));
                    s.City          = (dr.IsDBNull(4) ? null : dr.GetString(4));
                    s.Country       = (dr.IsDBNull(5) ? null : dr.GetString(5));
                    s.Phone         = (dr.IsDBNull(6) ? null : dr.GetString(6));
                    s.Fax           = (dr.IsDBNull(7) ? null : dr.GetString(7));

                    supplierList.Add(s);
                }
                return supplierList;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il recupero degli Supplier", ex);
            }
        }
        public static List<Supplier> SearchSupplier(string suppName, string compName, string title, string city, string country, string phone, string fax)
        {
            List<Supplier> supplierList = new List<Supplier>();
            SqlConnection cn = BaseDAO.GetConnection();
            SqlDataReader dr = null;
            StringBuilder sql = new StringBuilder();

            suppName    = "%" + suppName + "%";
            compName    = "%" + compName + "%";
            title       = "%" + title    + "%";
            city        = "%" + city     + "%";
            country     = "%" + country  + "%";
            phone       = "%" + phone    + "%";
            fax         = "%" + fax      + "%";

            try
            {
                sql.Append("SELECT Id,ContactName,CompanyName,ContactTitle,City,Country,Phone,Fax ");
                sql.Append("FROM Supplier ");
                sql.Append("WHERE ContactName LIKE @pSuppName AND CompanyName LIKE @pCompName ");
                sql.Append("AND ISNULL(ContactTitle,'') LIKE @pTitle ");
                sql.Append("AND City LIKE @pCity AND Country LIKE @pCountry AND Phone LIKE @pPhone ");
                sql.Append("AND ISNULL(Fax, '') LIKE @pFax ");
                sql.Append("ORDER BY ContactName ASC ");

                SqlCommand cmd = new SqlCommand(sql.ToString(), cn);
                cmd.Parameters.Add(new SqlParameter("pSuppName", suppName));
                cmd.Parameters.Add(new SqlParameter("pCompName", compName));
                cmd.Parameters.Add(new SqlParameter("pTitle", title));
                cmd.Parameters.Add(new SqlParameter("pCity", city));
                cmd.Parameters.Add(new SqlParameter("pCountry", country));
                cmd.Parameters.Add(new SqlParameter("pPhone", phone));
                cmd.Parameters.Add(new SqlParameter("pFax", fax));
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Supplier s = new Supplier();
                    s.Id            = (dr.IsDBNull(0) ? -1   : dr.GetInt32(0));
                    s.ContactName   = (dr.IsDBNull(1) ? null : dr.GetString(1));
                    s.CompanyName   = (dr.IsDBNull(2) ? null : dr.GetString(2));
                    s.ContactTitle  = (dr.IsDBNull(3) ? null : dr.GetString(3));
                    s.City          = (dr.IsDBNull(4) ? null : dr.GetString(4));
                    s.Country       = (dr.IsDBNull(5) ? null : dr.GetString(5));
                    s.Phone         = (dr.IsDBNull(6) ? null : dr.GetString(6));
                    s.Fax           = (dr.IsDBNull(7) ? null : dr.GetString(7));

                    supplierList.Add(s);
                }
                return supplierList;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante la ricerca degli Supplier", ex);
            }
        }
    }
}