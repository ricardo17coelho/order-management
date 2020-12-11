using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace order_management
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Street { get; set; }

        public string StreetNr { get; set; }

        public int Zip { get; set; }
        
        public string City { get; set; }

        public string Country { get; set; }

        public Customer(string firstName, string lastName, string street, string streetNr, int zip, string city, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            Street = street;
            StreetNr = streetNr;
            Zip = zip;
            City = city;
            Country = country;
        }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   FirstName == customer.FirstName &&
                   LastName == customer.LastName &&
                   Street == customer.Street &&
                   StreetNr == customer.StreetNr &&
                   Zip == customer.Zip &&
                   City == customer.City &&
                   Country == customer.Country;
        }
    }
}
