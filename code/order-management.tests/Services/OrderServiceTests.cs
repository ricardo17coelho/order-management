using FakeItEasy;
using order_management.Services;
using System.Collections.Generic;
using Xunit;

namespace order_management.tests.Services
{
    public class OrderServiceTests
    {
        [Fact]
        public void Add_Invokes_RepoAdd()
        {
            var fakeRepo = A.Fake<RepoOrder>();
            var service = new OrderService(fakeRepo);
            var order = new Order() { OrderId = 43 };

            A.CallTo(() => fakeRepo.Add(order)).Returns(order);

            var retrieved = service.Add(order);

            Assert.Equal(order.OrderId, retrieved.OrderId);
        }

        [Fact]
        public void Delete_Invokes_RepoDelete()
        {
            var fakeRepo = A.Fake<RepoOrder>();
            var service = new OrderService(fakeRepo);
            var order = new Order();

            service.Delete(order);

            A.CallTo(() => fakeRepo.Delete(order)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void DeleteById_Invokes_RepoDelete()
        {
            var fakeRepo = A.Fake<RepoOrder>();
            var service = new OrderService(fakeRepo);
            var order = new Order();

            service.DeleteById(order.OrderId);

            A.CallTo(() => fakeRepo.Delete(order.OrderId)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetAll_Invokes_RepoGetAll()
        {
            var fakeRepo = A.Fake<RepoOrder>();
            var service = new OrderService(fakeRepo);
            var order = new Order() { OrderId = 43 };

            A.CallTo(() => fakeRepo.GetAll()).Returns(new List<Order>(){ order });

            var retrieved = service.GetAll();

            Assert.Equal(order.OrderId, retrieved[0].OrderId);
        }

        [Fact]
        public void GetById_Invokes_RepoGetById()
        {
            var fakeRepo = A.Fake<RepoOrder>();
            var service = new OrderService(fakeRepo);
            var order = new Order() { OrderId = 43 };

            A.CallTo(() => fakeRepo.GetById(order.OrderId)).Returns(order);

            var retrieved = service.GetById(order.OrderId);

            Assert.Equal(order.OrderId, retrieved.OrderId);
        }

        [Fact]
        public void Update_Invokes_RepoUpdate()
        {
            var fakeRepo = A.Fake<RepoOrder>();
            var service = new OrderService(fakeRepo);
            var order = new Order() { OrderId = 43 };

            A.CallTo(() => fakeRepo.Update(order)).Returns(order);

            var retrieved = service.Update(order);

            Assert.Equal(order.OrderId, retrieved.OrderId);
        }

        [Fact]
        public void Search_Invokes_RepoSearch()
        {
            var fakeRepo = A.Fake<RepoOrder>();
            var service = new OrderService(fakeRepo);
            var order = new Order() { OrderId = 43 };

            A.CallTo(() => fakeRepo.Search(order.OrderId.ToString())).Returns(new List<Order>(){ order });

            var retrieved = service.Search(order.OrderId.ToString());

            Assert.Equal(order.OrderId, retrieved[0].OrderId);
        }

        [Fact]
        public void IsUnique_Invokes_RepoIsUnique()
        {
            var fakeRepo = A.Fake<RepoOrder>();
            var service = new OrderService(fakeRepo);
            var order = new Order();

            A.CallTo(() => fakeRepo.IsUnique(order)).Returns(true);

            service.IsUnique(order);

            A.CallTo(() => fakeRepo.IsUnique(order)).MustHaveHappenedOnceExactly();
        }
    }
}
