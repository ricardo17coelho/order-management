using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace order_management
{
    public class Customer
    {
		//[JsonIgnore()]
		//[XmlIgnore]
		public int CustomerId { get; set; }
		public string CustomerNr { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName => ToString();
		public string Email { get; set; }
		public string Website { get; set; }
		public string Password { get; set; }
		public string Street { get; set; }
		public string StreetNr { get; set; }
		public int Zip { get; set; }
		public string City { get; set; }
		public string Country { get; set; }

		public Customer(string customerNr, string firstName, string lastName, string email, string website, string password, string street, string streetNr, int zip, string city, string country)
        {
            CustomerNr = customerNr;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Website = website;
            Password = password;
            Street = street;
            StreetNr = streetNr;
            Zip = zip;
            City = city;
            Country = country;
        }

        public Customer(int id, string customerNr, string firstName, string lastName, string email, string website, string password, string street, string streetNr, int zip, string city, string country)
        {
            CustomerId = id;
            CustomerNr = customerNr;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Website = website;
            Password = password;
            Street = street;
            StreetNr = streetNr;
            Zip = zip;
            City = city;
            Country = country;
        }

        public Customer()
        {
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
