using FakeItEasy;
using System.Collections.Generic;
using Xunit;
using order_management;
using order_management.Services;

namespace yoyComparison_management.tests.Services
{
    public class YoyComparisonServiceTests
    {
        [Fact]
        public void Add_Invokes_RepoAdd()
        {
            var fakeRepo = A.Fake<RepoYoyComparison>();
            var service = new YoyComparisonService(fakeRepo);
            var yoyComparison = new YoyComparison() { CountOrders = 43 };

            A.CallTo(() => fakeRepo.Add(yoyComparison)).Returns(yoyComparison);

            var retrieved = service.Add(yoyComparison);

            Assert.Equal(yoyComparison.CountOrders, retrieved.CountOrders);
        }

        [Fact]
        public void Delete_Invokes_RepoDelete()
        {
            var fakeRepo = A.Fake<RepoYoyComparison>();
            var service = new YoyComparisonService(fakeRepo);
            var yoyComparison = new YoyComparison();

            service.Delete(yoyComparison);

            A.CallTo(() => fakeRepo.Delete(yoyComparison)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void DeleteById_Invokes_RepoDelete()
        {
            var fakeRepo = A.Fake<RepoYoyComparison>();
            var service = new YoyComparisonService(fakeRepo);
            var yoyComparison = new YoyComparison();

            service.DeleteById(yoyComparison.CountOrders);

            A.CallTo(() => fakeRepo.Delete(yoyComparison.CountOrders)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetAll_Invokes_RepoGetAll()
        {
            var fakeRepo = A.Fake<RepoYoyComparison>();
            var service = new YoyComparisonService(fakeRepo);
            var yoyComparison = new YoyComparison() { CountOrders = 43 };

            A.CallTo(() => fakeRepo.GetAll()).Returns(new List<YoyComparison>(){ yoyComparison });

            var retrieved = service.GetAll();

            Assert.Equal(yoyComparison.CountOrders, retrieved[0].CountOrders);
        }

        [Fact]
        public void GetById_Invokes_RepoGetById()
        {
            var fakeRepo = A.Fake<RepoYoyComparison>();
            var service = new YoyComparisonService(fakeRepo);
            var yoyComparison = new YoyComparison() { CountOrders = 43 };

            A.CallTo(() => fakeRepo.GetById(yoyComparison.CountOrders)).Returns(yoyComparison);

            var retrieved = service.GetById(yoyComparison.CountOrders);

            Assert.Equal(yoyComparison.CountOrders, retrieved.CountOrders);
        }

        [Fact]
        public void Update_Invokes_RepoUpdate()
        {
            var fakeRepo = A.Fake<RepoYoyComparison>();
            var service = new YoyComparisonService(fakeRepo);
            var yoyComparison = new YoyComparison() { CountOrders = 43 };

            A.CallTo(() => fakeRepo.Update(yoyComparison)).Returns(yoyComparison);

            var retrieved = service.Update(yoyComparison);

            Assert.Equal(yoyComparison.CountOrders, retrieved.CountOrders);
        }
    }
}
