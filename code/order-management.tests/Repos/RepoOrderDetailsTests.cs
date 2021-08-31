using order_management;
using order_management.tests.Repos;
using System.Collections.Generic;
using Xunit;

namespace orderDetail_management.tests.Repos
{
    public class RepoOrderDetailTests
    {
        [Fact]
        public void GetAllReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoOrderDetail(fakeContext);

            var retrieved = (List<OrderDetail>)repo.GetAll();

            Assert.Equal(1000, retrieved[0].OrderDetailId);
        }

        [Fact]
        public void SearchReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoOrderDetail(fakeContext);

            var retrieved = repo.Search("Samsung");

            Assert.Equal(1000, retrieved[0].OrderDetailId);
        }

        [Fact]
        public void GetByOrderReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoOrderDetail(fakeContext);
            var order = new Order() { OrderId = 1000 };

            var retrieved = repo.GetByOrder(order);

            Assert.Equal(1000, retrieved[0].OrderDetailId);
        }

        [Fact]
        public void IsValidReturnsFalse()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoOrderDetail(fakeContext);
            Assert.False(repo.IsValid(new OrderDetail()));
        }

    }
}
