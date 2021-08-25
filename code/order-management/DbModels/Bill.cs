using System;
using System.Collections.Generic;
using System.Text;

namespace order_management
{
    public class Bill
    {
        public int BillId { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string StreetNr { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderId { get; set; }
        public double Netto { get; set; }
        public double Brutto { get; set; }


        public Bill(int customerId, string firstName, string lastName, string street, string streetNr, int zip, string city, string country, DateTime orderDate, int orderId, double netto, double brutto)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Street = street;
            StreetNr = streetNr;
            Zip = zip;
            City = city;
            Country = country;
            OrderDate = orderDate;
            OrderId = orderId;
            Netto = netto;
            Brutto = brutto;
        }

        public Bill(int billId, int customerId, string firstName, string lastName, string street, string streetNr, int zip, string city, string country, DateTime orderDate, int orderId, double netto, double brutto)
        {
            BillId = billId;
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Street = street;
            StreetNr = streetNr;
            Zip = zip;
            City = city;
            Country = country;
            OrderDate = orderDate;
            OrderId = orderId;
            Netto = netto;
            Brutto = brutto;
        }

        public Bill()
        {
        }
    }
}
