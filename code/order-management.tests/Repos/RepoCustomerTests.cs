using System.Collections.Generic;
using Xunit;

namespace order_management.tests.Repos
{
    public class RepoCustomerTests
    {
        [Fact]
        public void GetAllReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoCustomer(fakeContext);

            var retrieved = (List<Customer>)repo.GetAll();

            Assert.Equal("Hans", retrieved[0].FirstName);
        }

        //[Fact]
        //public void GetByNameReturnsValidEntity()
        //{
        //    var fakeContext = new FakeContext();
        //    var repo = new RepoCustomer(fakeContext);

        //    var retrieved = repo.GetByName("Hans", "Müller");

        //    Assert.Equal(1000, retrieved.CustomerId);
        //}
    }
}
