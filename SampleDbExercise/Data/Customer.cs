using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleDbExercise.Data
{
    public class Customer
    {
        int id;
        string name, surname, city, country, phone;

        public Customer()
        {
            this.id = -1;
            this.name = this.surname = this.city = this.country = this.phone = "";
        }

        public Customer(int id, string name, string surname, string city, string country, string phone)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.city = city;
            this.country = country;
            this.phone = phone;
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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
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

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }
    }
}