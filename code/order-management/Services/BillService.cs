using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using order_management.DbModels;

namespace order_management
{
    public class BillService
    {

        public List<Bill> GetAll()
        {
            using (var context = new Context())
            {
                return context.Bills.ToList();
            }
        }

        public void Add(Bill bill)
        {
            using (var context = new Context())
            {
                context.Bills.Attach(bill);
                context.SaveChanges();
            }
        }

        public void Delete(Bill bill)
        {
            using (var context = new Context())
            {
                context.Bills.Remove(bill);
                context.SaveChanges();
            }
        }

        public List<Bill> Search(string searchString)
        {
            searchString = searchString.ToLower();
            return GetAll()
                .Where(bill =>
                    bill.CustomerId.ToString().Contains(searchString) ||
                    bill.FirstName.ToLower().Contains(searchString) ||
                    bill.LastName.ToLower().Contains(searchString) ||
                    bill.Street.ToLower().Contains(searchString) ||
                    bill.Zip.ToString().Contains(searchString) ||
                    bill.City.ToLower().Contains(searchString) ||
                    bill.OrderDate.ToString().Contains(searchString) ||
                    bill.Netto.ToString().Contains(searchString) ||
                    bill.Brutto.ToString().Contains(searchString) ||
                    bill.Country.ToLower().Contains(searchString)
                ).ToList();
        }

        public void GenerateBill(Order order)
        {
            var customerService = new CustomerService();
            var orderDetailService = new OrderDetailService();

            var customer = customerService.GetByOrder(order);
            var orderDetails = orderDetailService.GetByOrder(order);
            var customerId = customer.CustomerId;
            var firstName = customer.FirstName;
            var lastName = customer.LastName;
            var street = customer.Street;
            var streetNr = customer.StreetNr;
            var zip = customer.Zip;
            var city = customer.City;
            var country = customer.Country;
            var orderDate = order.OrderDate;
            var orderId = order.OrderId;


            double netto = 0;

            foreach (var orderDetail in orderDetails)
            {
                netto += orderDetail.Quantity * orderDetail.Product.Price;
            }

            var brutto = netto * (order.Tax / 100) + netto;

            Add(new Bill(customerId, firstName, lastName, street, streetNr, zip, city,
                                        country, orderDate, orderId, netto, brutto));

        }
    }
}
