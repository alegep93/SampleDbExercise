using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleDbExercise.Data
{
    public class Supplier
    {
        int id;
        string companyName, contactName, contactTitle, city, country, phone, fax;

        public Supplier()
        {
            this.id = -1;
            this.CompanyName = this.ContactName = this.ContactTitle = "";
            this.City = this.Country = this.Phone = this.Fax = "";
        }

        public Supplier(int id, string companyName, string contactName, string contactTitle, string city, string country, string phone, string fax)
        {
            this.Id = id;
            this.CompanyName = companyName;
            this.ContactName = contactName;
            this.ContactTitle = contactTitle;
            this.City = city;
            this.Country = country;
            this.Phone = phone;
            this.Fax = fax;
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

        public string CompanyName
        {
            get
            {
                return companyName;
            }

            set
            {
                companyName = value;
            }
        }

        public string ContactName
        {
            get
            {
                return contactName;
            }

            set
            {
                contactName = value;
            }
        }

        public string ContactTitle
        {
            get
            {
                return contactTitle;
            }

            set
            {
                contactTitle = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Fax
        {
            get
            {
                return fax;
            }

            set
            {
                fax = value;
            }
        }
    }
}