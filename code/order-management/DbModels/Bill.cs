using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.DbModels
{
    public class Bill
    {
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
    }
}
