using SampleDbExercise.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace SampleDbExercise.DAO
{
    public class OrderDAO : BaseDAO
    {
        public static List<Order> GetOrderList()
        {
            List<Order> OrderList = new List<Order>();
            SqlConnection cn = BaseDAO.GetConnection();
            SqlDataReader dr = null;
            StringBuilder sql = new StringBuilder();

            try
            {
                sql.Append("SELECT O.Id,OrderNumber,OrderDate, ");
                sql.Append("C.FirstName + ' ' + C.LastName AS 'Customer Name',TotalAmount ");
                sql.Append("FROM[dbo].[Order] AS O ");
                sql.Append("JOIN Customer AS C ON(O.CustomerId = C.Id) ");
                sql.Append("ORDER BY OrderNumber ASC ");

                SqlCommand cmd = new SqlCommand(sql.ToString(), cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Order o = new Order();
                    o.Id = (dr.IsDBNull(0) ? -1 : dr.GetInt32(0));
                    o.OrderNumber = (dr.IsDBNull(1) ? null : dr.GetString(1));
                    o.OrderDate = (dr.IsDBNull(2) ? new DateTime() : dr.GetDateTime(2));
                    o.CustomerName = (dr.IsDBNull(3) ? null : dr.GetString(3));
                    o.TotalAmount = (dr.IsDBNull(4) ? 0.00m : dr.GetDecimal(4));

                    OrderList.Add(o);
                }
                return OrderList;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il recupero degli Order", ex);
            }
        }
        public static List<Order> SearchOrder(string ordNum, string ordDate, string custName, string amount)
        {
            List<Order> OrderList = new List<Order>();
            SqlConnection cn = BaseDAO.GetConnection();
            SqlDataReader dr = null;
            StringBuilder sql = new StringBuilder();

            ordNum = "%" + ordNum + "%";
            ordDate = "%" + ordDate + "%";
            custName = "%" + custName + "%";
            amount = amount + "%";

            try
            {
                sql.Append("SELECT O.Id,OrderNumber,OrderDate, ");
                sql.Append("C.FirstName + ' ' + C.LastName AS 'Customer Name',TotalAmount ");
                sql.Append("FROM[dbo].[Order] AS O ");
                sql.Append("JOIN Customer AS C ON(O.CustomerId = C.Id) ");
                sql.Append("WHERE OrderNumber LIKE @pOrdNum ");
                sql.Append("AND C.FirstName + ' ' + C.LastName LIKE @pCustName AND TotalAmount LIKE @pAmount ");
                sql.Append("AND OrderDate LIKE @pOrdDate ");
                sql.Append("ORDER BY LastName ASC ");

                SqlCommand cmd = new SqlCommand(sql.ToString(), cn);
                cmd.Parameters.Add(new SqlParameter("pOrdNum", ordNum));
                cmd.Parameters.Add(new SqlParameter("pOrdDate", ordDate));
                cmd.Parameters.Add(new SqlParameter("pCustName", custName));
                cmd.Parameters.Add(new SqlParameter("pAmount", amount));
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Order o = new Order();
                    o.Id = (dr.IsDBNull(0) ? -1 : dr.GetInt32(0));
                    o.OrderNumber = (dr.IsDBNull(1) ? null : dr.GetString(1));
                    o.OrderDate = (dr.IsDBNull(2) ? new DateTime() : dr.GetDateTime(2));
                    o.CustomerName = (dr.IsDBNull(3) ? null : dr.GetString(3));
                    o.TotalAmount = (dr.IsDBNull(4) ? 0.00m : dr.GetDecimal(4));

                    OrderList.Add(o);
                }
                return OrderList;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante la ricerca degli Order", ex);
            }
        }
    }
}