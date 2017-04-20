using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleDbExercise.Data
{
    public class OrderItem
    {
        int id, orderId, productId, quantity;
        decimal unitPrice;
        string orderNumber, productName;

        public OrderItem()
        {
            this.id = this.orderId = this.productId = this.quantity = -1;
            this.UnitPrice = 0.00m;
            this.orderNumber = ProductName = "";

        }

        public OrderItem(int id, int orderId, int productId, decimal unitPrice, int quantity, string orderNumber, string productName)
        {
            this.Id = id;
            this.OrderId = orderId;
            this.ProductId = productId;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
            this.orderNumber = orderNumber;
            this.ProductName = productName;
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

        public int OrderId
        {
            get
            {
                return orderId;
            }

            set
            {
                orderId = value;
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

        public int ProductId
        {
            get
            {
                return productId;
            }

            set
            {
                productId = value;
            }
        }

        public string ProductName
        {
            get
            {
                return productName;
            }

            set
            {
                productName = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }

            set
            {
                unitPrice = value;
            }
        }
    }
}