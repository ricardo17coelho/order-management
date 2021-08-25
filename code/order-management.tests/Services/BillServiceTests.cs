using FakeItEasy;
using System.Collections.Generic;
using Xunit;
using order_management;
using order_management.Services;

namespace bill_management.tests.Services
{
    public class BillServiceTests
    {
        [Fact]
        public void Add_Invokes_RepoAdd()
        {
            var fakeRepo = A.Fake<RepoBill>();
            var service = new BillService(fakeRepo);
            var bill = new Bill() { BillId = 43 };

            A.CallTo(() => fakeRepo.Add(bill)).Returns(bill);

            var retrieved = service.Add(bill);

            Assert.Equal(bill.BillId, retrieved.BillId);
        }

        [Fact]
        public void Delete_Invokes_RepoDelete()
        {
            var fakeRepo = A.Fake<RepoBill>();
            var service = new BillService(fakeRepo);
            var bill = new Bill();

            service.Delete(bill);

            A.CallTo(() => fakeRepo.Delete(bill)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void DeleteById_Invokes_RepoDelete()
        {
            var fakeRepo = A.Fake<RepoBill>();
            var service = new BillService(fakeRepo);
            var bill = new Bill();

            service.DeleteById(bill.BillId);

            A.CallTo(() => fakeRepo.Delete(bill.BillId)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetAll_Invokes_RepoGetAll()
        {
            var fakeRepo = A.Fake<RepoBill>();
            var service = new BillService(fakeRepo);
            var bill = new Bill() { BillId = 43 };

            A.CallTo(() => fakeRepo.GetAll()).Returns(new List<Bill>(){ bill });

            var retrieved = service.GetAll();

            Assert.Equal(bill.BillId, retrieved[0].BillId);
        }

        [Fact]
        public void GetById_Invokes_RepoGetById()
        {
            var fakeRepo = A.Fake<RepoBill>();
            var service = new BillService(fakeRepo);
            var bill = new Bill() { BillId = 43 };

            A.CallTo(() => fakeRepo.GetById(bill.BillId)).Returns(bill);

            var retrieved = service.GetById(bill.BillId);

            Assert.Equal(bill.BillId, retrieved.BillId);
        }

        [Fact]
        public void Update_Invokes_RepoUpdate()
        {
            var fakeRepo = A.Fake<RepoBill>();
            var service = new BillService(fakeRepo);
            var bill = new Bill() { BillId = 43 };

            A.CallTo(() => fakeRepo.Update(bill)).Returns(bill);

            var retrieved = service.Update(bill);

            Assert.Equal(bill.BillId, retrieved.BillId);
        }

        [Fact]
        public void Search_Invokes_RepoSearch()
        {
            var fakeRepo = A.Fake<RepoBill>();
            var service = new BillService(fakeRepo);
            var bill = new Bill() { BillId = 43 };

            A.CallTo(() => fakeRepo.Search(bill.BillId.ToString())).Returns(new List<Bill>(){ bill });

            var retrieved = service.Search(bill.BillId.ToString());

            Assert.Equal(bill.BillId, retrieved[0].BillId);
        }
    }
}
