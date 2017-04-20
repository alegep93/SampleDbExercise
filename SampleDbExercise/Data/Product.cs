using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleDbExercise.Data
{
    public class Product
    {
        int id, supplierId;
        string productName, package, supplierName;
        decimal unitPrice;
        bool isDiscontinued;

        public Product()
        {
            this.Id = this.SupplierId = -1;
            this.ProductName = this.Package = this.supplierName = "";
            this.UnitPrice = 0.00m;
            this.IsDiscontinued = false;
        }

        public Product(int id, int supplierId, string productName, string package, string supplierName, decimal unitPrice, bool isDiscontinued)
        {
            this.Id = id;
            this.SupplierId = supplierId;
            this.ProductName = productName;
            this.Package = package;
            this.supplierName = supplierName;
            this.UnitPrice = unitPrice;
            this.IsDiscontinued = isDiscontinued;
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

        public int SupplierId
        {
            get
            {
                return supplierId;
            }

            set
            {
                supplierId = value;
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

        public string Package
        {
            get
            {
                return package;
            }

            set
            {
                package = value;
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

        public bool IsDiscontinued
        {
            get
            {
                return isDiscontinued;
            }

            set
            {
                isDiscontinued = value;
            }
        }

        public string SupplierName
        {
            get
            {
                return supplierName;
            }

            set
            {
                supplierName = value;
            }
        }
    }
}