using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleDbExercise.Data
{
    public class Order
    {
        int id, customerId;
        DateTime orderDate;
        string orderNumber, customerName;
        decimal totalAmount;

        public Order()
        {
            this.id = this.customerId = -1;
            this.orderDate = new DateTime();
            this.orderNumber = this.customerName = "";
            this.totalAmount = 0.00m;
        }

        public Order(int id, int customerId, DateTime orderDate, string orderNumber, string customerName, decimal totalAmount)
        {
            this.Id = id;
            this.CustomerId = customerId;
            this.OrderDate = orderDate;
            this.OrderNumber = orderNumber;
            this.customerName = customerName;
            this.TotalAmount = totalAmount;
        }

        public int CustomerId
        {
            get
            {
                return customerId;
            }

            set
            {
                customerId = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return orderDate;
            }

            set
            {
                orderDate = value;
            }
        }

        public string OrderNumber
        {
            get
            {
                return orderNumber;
            }

            set
            {
                orderNumber = value;
            }
        }

        public decimal TotalAmount
        {
            get
            {
                return totalAmount;
            }

            set
            {
                totalAmount = value;
            }
        }
    }
}