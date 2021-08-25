using Microsoft.EntityFrameworkCore;
using order_management.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace order_management
{
    public class RepoBill : RepoBase<Bill>
    {
        private readonly ICustomerService _customerService;
        private readonly IOrderDetailService _orderDetailService;

        public RepoBill(OrderManagementDbContext orderManagementDbContext, ICustomerService customerService, IOrderDetailService orderDetailService) : base(orderManagementDbContext)
        {
            _customerService = customerService;
            _orderDetailService = orderDetailService;
        }

        public virtual List<Bill> Search(string searchString)
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

        public virtual Bill GenerateBill(Order order)
        {

            var customer = _customerService.GetById(order.CustomerId);
            var orderDetails = _orderDetailService.GetByOrder(order);
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

            return Add(new Bill(customerId, firstName, lastName, street, streetNr, zip, city,
                                        country, orderDate, orderId, netto, brutto));

        }
    }
}
