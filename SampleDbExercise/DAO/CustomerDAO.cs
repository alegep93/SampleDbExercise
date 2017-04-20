using SampleDbExercise.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace SampleDbExercise.DAO
{
    public class CustomerDAO : BaseDAO
    {
        public static List<Customer> GetCustomerList()
        {
            List<Customer> customerList = new List<Customer>();
            SqlConnection cn = BaseDAO.GetConnection();
            SqlDataReader dr = null;
            StringBuilder sql = new StringBuilder();

            try
            {
                sql.Append("SELECT Id,LastName,FirstName,City,Country,Phone ");
                sql.Append("FROM Customer ");
                sql.Append("ORDER BY LastName ASC ");

                SqlCommand cmd = new SqlCommand(sql.ToString(), cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Customer c = new Customer();
                    c.Id = (dr.IsDBNull(0) ? -1 : dr.GetInt32(0));
                    c.Surname = (dr.IsDBNull(1) ? null : dr.GetString(1));
                    c.Name = (dr.IsDBNull(2) ? null : dr.GetString(2));
                    c.City = (dr.IsDBNull(3) ? null : dr.GetString(3));
                    c.Country = (dr.IsDBNull(4) ? null : dr.GetString(4));
                    c.Phone = (dr.IsDBNull(5) ? null : dr.GetString(5));

                    customerList.Add(c);
                }
                return customerList;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il recupero dei Customer", ex);
            }
        }
        public static List<Customer> SearchCustomer(string surname, string name, string city, string country, string phone)
        {
            List<Customer> customerList = new List<Customer>();
            SqlConnection cn = BaseDAO.GetConnection();
            SqlDataReader dr = null;
            StringBuilder sql = new StringBuilder();

            name    = "%" + name    + "%";
            surname = "%" + surname + "%";
            city    = "%" + city    + "%";
            country = "%" + country + "%";
            phone   = "%" + phone   + "%";

            try
            {
                sql.Append("SELECT Id,LastName,FirstName,City,Country,Phone ");
                sql.Append("FROM Customer ");
                sql.Append("WHERE LastName LIKE @pLastName AND FirstName LIKE @pFirstName ");
                sql.Append("AND City LIKE @pCity AND Country LIKE @pCountry AND Phone LIKE @pPhone ");
                sql.Append("ORDER BY LastName ASC ");

                SqlCommand cmd = new SqlCommand(sql.ToString(), cn);
                cmd.Parameters.Add(new SqlParameter("pLastName", surname));
                cmd.Parameters.Add(new SqlParameter("pFirstName", name));
                cmd.Parameters.Add(new SqlParameter("pCity", city));
                cmd.Parameters.Add(new SqlParameter("pCountry", country));
                cmd.Parameters.Add(new SqlParameter("pPhone", phone));
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Customer c = new Customer();
                    c.Id = (dr.IsDBNull(0) ? -1 : dr.GetInt32(0));
                    c.Surname = (dr.IsDBNull(1) ? null : dr.GetString(1));
                    c.Name = (dr.IsDBNull(2) ? null : dr.GetString(2));
                    c.City = (dr.IsDBNull(3) ? null : dr.GetString(3));
                    c.Country = (dr.IsDBNull(4) ? null : dr.GetString(4));
                    c.Phone = (dr.IsDBNull(5) ? null : dr.GetString(5));

                    customerList.Add(c);
                }
                return customerList;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante la ricerca dei Customer", ex);
            }
        }
    }
}