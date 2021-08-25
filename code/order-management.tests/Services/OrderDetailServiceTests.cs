using FakeItEasy;
using order_management.Services;
using System.Collections.Generic;
using Xunit;

namespace order_management.tests.Services
{
    public class OrderDetailDetailServiceTests
    {
        [Fact]
        public void Add_Invokes_RepoAdd()
        {
            var fakeRepo = A.Fake<RepoOrderDetail>();
            var service = new OrderDetailService(fakeRepo);
            var orderDetail = new OrderDetail() { OrderDetailId = 43 };

            A.CallTo(() => fakeRepo.Add(orderDetail)).Returns(orderDetail);

            var retrieved = service.Add(orderDetail);

            Assert.Equal(orderDetail.OrderDetailId, retrieved.OrderDetailId);
        }

        [Fact]
        public void Delete_Invokes_RepoDelete()
        {
            var fakeRepo = A.Fake<RepoOrderDetail>();
            var service = new OrderDetailService(fakeRepo);
            var orderDetail = new OrderDetail();

            service.Delete(orderDetail);

            A.CallTo(() => fakeRepo.Delete(orderDetail)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void DeleteById_Invokes_RepoDelete()
        {
            var fakeRepo = A.Fake<RepoOrderDetail>();
            var service = new OrderDetailService(fakeRepo);
            var orderDetail = new OrderDetail();

            service.DeleteById(orderDetail.OrderDetailId);

            A.CallTo(() => fakeRepo.Delete(orderDetail.OrderDetailId)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetAll_Invokes_RepoGetAll()
        {
            var fakeRepo = A.Fake<RepoOrderDetail>();
            var service = new OrderDetailService(fakeRepo);
            var orderDetail = new OrderDetail() { OrderDetailId = 43 };

            A.CallTo(() => fakeRepo.GetAll()).Returns(new List<OrderDetail>(){ orderDetail });

            var retrieved = service.GetAll();

            Assert.Equal(orderDetail.OrderDetailId, retrieved[0].OrderDetailId);
        }

        [Fact]
        public void GetById_Invokes_RepoGetById()
        {
            var fakeRepo = A.Fake<RepoOrderDetail>();
            var service = new OrderDetailService(fakeRepo);
            var orderDetail = new OrderDetail() { OrderDetailId = 43 };

            A.CallTo(() => fakeRepo.GetById(orderDetail.OrderDetailId)).Returns(orderDetail);

            var retrieved = service.GetById(orderDetail.OrderDetailId);

            Assert.Equal(orderDetail.OrderDetailId, retrieved.OrderDetailId);
        }

        [Fact]
        public void Update_Invokes_RepoUpdate()
        {
            var fakeRepo = A.Fake<RepoOrderDetail>();
            var service = new OrderDetailService(fakeRepo);
            var orderDetail = new OrderDetail() { OrderDetailId = 43 };

            A.CallTo(() => fakeRepo.Update(orderDetail)).Returns(orderDetail);

            var retrieved = service.Update(orderDetail);

            Assert.Equal(orderDetail.OrderDetailId, retrieved.OrderDetailId);
        }
    }
}
