using SampleDbExercise.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace SampleDbExercise.DAO
{
    public class OrderItemDAO
    {
        public static List<OrderItem> GetOrderItemList()
        {
            List<OrderItem> OrderItemList = new List<OrderItem>();
            SqlConnection cn = BaseDAO.GetConnection();
            SqlDataReader dr = null;
            StringBuilder sql = new StringBuilder();

            try
            {
                sql.Append("SELECT OI.Id,P.ProductName,O.OrderNumber,OI.UnitPrice,OI.Quantity ");
                sql.Append("FROM OrderItem AS OI ");
                sql.Append("JOIN[dbo].[Order] AS O ON(OI.OrderId = O.Id) ");
                sql.Append("JOIN Product AS P ON(OI.ProductId = P.Id) ");
                sql.Append("ORDER BY ProductName ASC ");

                SqlCommand cmd = new SqlCommand(sql.ToString(), cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    OrderItem o = new OrderItem();
                    o.Id = (dr.IsDBNull(0) ? -1 : dr.GetInt32(0));
                    o.ProductName = (dr.IsDBNull(1) ? null : dr.GetString(1));
                    o.OrderNumber = (dr.IsDBNull(2) ? null : dr.GetString(2));
                    o.UnitPrice = (dr.IsDBNull(3) ? 0.00m : dr.GetDecimal(3));
                    o.Quantity = (dr.IsDBNull(4) ? -1 : dr.GetInt32(4));

                    OrderItemList.Add(o);
                }
                return OrderItemList;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il recupero degli OrderItem", ex);
            }
        }
        public static List<OrderItem> SearchOrderItem(string prodName, string ordNum, string unitPrice, string qnt)
        {
            List<OrderItem> OrderItemList = new List<OrderItem>();
            SqlConnection cn = BaseDAO.GetConnection();
            SqlDataReader dr = null;
            StringBuilder sql = new StringBuilder();

            prodName = "%" + prodName + "%";
            ordNum = ordNum + "%";
            unitPrice = unitPrice + "%";
            qnt = qnt + "%";

            try
            {
                sql.Append("SELECT OI.Id,P.ProductName,O.OrderNumber,OI.UnitPrice,OI.Quantity ");
                sql.Append("FROM OrderItem AS OI ");
                sql.Append("JOIN[dbo].[Order] AS O ON(OI.OrderId = O.Id) ");
                sql.Append("JOIN Product AS P ON(OI.ProductId = P.Id) ");
                sql.Append("WHERE P.ProductName LIKE @pProdName AND O.OrderNumber LIKE @pOrdNum AND OI.UnitPrice LIKE @pUnitPrice AND OI.Quantity LIKE @pQnt ");
                sql.Append("ORDER BY ProductName ASC ");

                SqlCommand cmd = new SqlCommand(sql.ToString(), cn);
                cmd.Parameters.Add(new SqlParameter("pProdName", prodName));
                cmd.Parameters.Add(new SqlParameter("pOrdNum", ordNum));
                cmd.Parameters.Add(new SqlParameter("pUnitPrice", unitPrice));
                cmd.Parameters.Add(new SqlParameter("pQnt", qnt));
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    OrderItem o = new OrderItem();
                    o.Id = (dr.IsDBNull(0) ? -1 : dr.GetInt32(0));
                    o.ProductName = (dr.IsDBNull(1) ? null : dr.GetString(1));
                    o.OrderNumber = (dr.IsDBNull(2) ? null : dr.GetString(2));
                    o.UnitPrice = (dr.IsDBNull(3) ? 0.00m : dr.GetDecimal(3));
                    o.Quantity = (dr.IsDBNull(4) ? -1 : dr.GetInt32(4));

                    OrderItemList.Add(o);
                }
                return OrderItemList;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante la ricerca degli OrderItem", ex);
            }
        }
    }
}