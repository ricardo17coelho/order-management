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

            Assert.Equal(1000, retrieved[0].CustomerId);
        }

        [Fact]
        public void GetByIdReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoCustomer(fakeContext);

            var retrieved = repo.GetById(1000);

            Assert.Equal(1000, retrieved.CustomerId);
        }

        [Fact]
        public void GetByNameReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoCustomer(fakeContext);

            var retrieved = repo.GetByName("Hans", "Müller");

            Assert.Equal(1000, retrieved.CustomerId);
        }

        [Fact]
        public void SearchReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoCustomer(fakeContext);

            var retrieved = repo.Search("Hans");

            Assert.Equal(1000, retrieved[0].CustomerId);
        }

        [Fact]
        public void IsUniqueReturnsFalse()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoCustomer(fakeContext);
            var Customer = new Customer() { FirstName = "Hans", LastName = "Müller" }; 
            Assert.False(repo.IsUnique(Customer));
        }

        [Fact]
        public void IsUniqueReturnsTrue()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoCustomer(fakeContext);
            var Customer = new Customer() { FirstName = "Harry", LastName = "Potter" };
            Assert.True(repo.IsUnique(Customer));
        }
    }
}
