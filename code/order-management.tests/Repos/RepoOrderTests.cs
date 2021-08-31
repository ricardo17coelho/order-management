using System.Collections.Generic;
using Xunit;

namespace order_management.tests.Repos
{
    public class RepoOrderTests
    {
        [Fact]
        public void GetAllReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoOrder(fakeContext);

            var retrieved = (List<Order>)repo.GetAll();

            Assert.Equal(1000, retrieved[0].OrderId);
        }

        [Fact]
        public void GetByIdReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoOrder(fakeContext);

            var retrieved = repo.GetById(1000);

            Assert.Equal(1000, retrieved.OrderId);
        }

        [Fact]
        public void SearchReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoOrder(fakeContext);

            var retrieved = repo.Search("Hans");

            Assert.Equal(1000, retrieved[0].OrderId);
        }

        [Fact]
        public void IsUniqueReturnsTrue()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoOrder(fakeContext);
            var Order = new Order() { Customer = new Customer() }; 
            Assert.True(repo.IsUnique(Order));
        }

        [Fact]
        public void IsValidReturnsFalse()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoOrder(fakeContext);
            Assert.False(repo.IsValid(new Order()));
        }

    }
}
