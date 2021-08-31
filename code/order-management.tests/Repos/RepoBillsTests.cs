using FakeItEasy;
using order_management;
using order_management.Services;
using order_management.tests.Repos;
using System.Collections.Generic;
using Xunit;

namespace bill_management.tests.Repos
{
    public class RepoBillTests
    {
        [Fact]
        public void GetAllReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var fakeCustomerService = A.Fake<CustomerService>();
            var fakeOrderDetailService = A.Fake<OrderDetailService>();

            var repo = new RepoBill(fakeContext, fakeCustomerService, fakeOrderDetailService);

            var retrieved = (List<Bill>)repo.GetAll();

            Assert.Equal(1000, retrieved[0].BillId);
        }

        [Fact]
        public void SearchReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var fakeCustomerService = A.Fake<CustomerService>();
            var fakeOrderDetailService = A.Fake<OrderDetailService>();

            var repo = new RepoBill(fakeContext, fakeCustomerService, fakeOrderDetailService);

            var retrieved = repo.Search("Hans");

            Assert.Equal(1000, retrieved[0].BillId);
        }

    }
}
