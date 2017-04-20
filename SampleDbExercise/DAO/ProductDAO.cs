using SampleDbExercise.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace SampleDbExercise.DAO
{
    public class ProductDAO : BaseDAO
    {
        public static List<Product> GetProductList()
        {
            List<Product> ProductList = new List<Product>();
            SqlConnection cn = BaseDAO.GetConnection();
            SqlDataReader dr = null;
            StringBuilder sql = new StringBuilder();

            try
            {
                sql.Append("SELECT P.Id,P.ProductName,S.ContactName,P.UnitPrice,P.Package,P.IsDiscontinued ");
                sql.Append("FROM Product AS P ");
                sql.Append("JOIN Supplier AS S ON(P.SupplierId = S.Id) ");
                sql.Append("ORDER BY P.ProductName ASC ");

                SqlCommand cmd = new SqlCommand(sql.ToString(), cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Product p = new Product();
                    p.Id = (dr.IsDBNull(0) ? -1 : dr.GetInt32(0));
                    p.ProductName = (dr.IsDBNull(1) ? null : dr.GetString(1));
                    p.SupplierName = (dr.IsDBNull(2) ? null : dr.GetString(2));
                    p.UnitPrice = (dr.IsDBNull(3) ? 0.00m : dr.GetDecimal(3));
                    p.Package = (dr.IsDBNull(4) ? null : dr.GetString(4));
                    p.IsDiscontinued = (dr.IsDBNull(5) ? false : dr.GetBoolean(5));

                    ProductList.Add(p);
                }
                return ProductList;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il recupero degli Product", ex);
            }
        }
        public static List<Product> SearchProduct(string prodName, string suppName, string unitPrice, string pack, string isDiscont)
        {
            List<Product> ProductList = new List<Product>();
            SqlConnection cn = BaseDAO.GetConnection();
            SqlDataReader dr = null;
            StringBuilder sql = new StringBuilder();

            prodName = "%" + prodName + "%";
            suppName = "%" + suppName + "%";
            unitPrice = unitPrice + "%";
            pack = "%" + pack + "%";
            isDiscont = "%" + isDiscont + "%";

            try
            {
                sql.Append("SELECT P.Id,P.ProductName,S.ContactName,P.UnitPrice,P.Package,P.IsDiscontinued ");
                sql.Append("FROM Product AS P ");
                sql.Append("JOIN Supplier AS S ON(P.SupplierId = S.Id) ");
                sql.Append("WHERE P.ProductName LIKE @pProdName AND S.ContactName LIKE @pContName AND P.UnitPrice LIKE @pUnitPrice ");
                sql.Append("AND P.Package LIKE @pPack AND P.IsDiscontinued LIKE @pIsDiscont ");
                sql.Append("ORDER BY P.ProductName ASC ");

                SqlCommand cmd = new SqlCommand(sql.ToString(), cn);
                cmd.Parameters.Add(new SqlParameter("pProdName", prodName));
                cmd.Parameters.Add(new SqlParameter("pContName", suppName));
                cmd.Parameters.Add(new SqlParameter("pUnitPrice", unitPrice));
                cmd.Parameters.Add(new SqlParameter("pPack", pack));
                cmd.Parameters.Add(new SqlParameter("pIsDiscont", isDiscont));
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Product p = new Product();
                    p.Id = (dr.IsDBNull(0) ? -1 : dr.GetInt32(0));
                    p.ProductName = (dr.IsDBNull(1) ? null : dr.GetString(1));
                    p.SupplierName = (dr.IsDBNull(2) ? null : dr.GetString(2));
                    p.UnitPrice = (dr.IsDBNull(3) ? 0.00m : dr.GetDecimal(3));
                    p.Package = (dr.IsDBNull(4) ? null : dr.GetString(4));
                    p.IsDiscontinued = (dr.IsDBNull(5) ? false : dr.GetBoolean(5));

                    ProductList.Add(p);
                }
                return ProductList;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante la ricerca degli Product", ex);
            }
        }
    }
}