using FakeItEasy;
using order_management.Services;
using System.Collections.Generic;
using Xunit;

namespace order_management.tests.Services
{
    public class ProductServiceTests
    {
        [Fact]
        public void Add_Invokes_RepoAdd()
        {
            var fakeRepo = A.Fake<RepoProduct>();
            var service = new ProductService(fakeRepo);
            var product = new Product() { ProductName = "Banana" };

            A.CallTo(() => fakeRepo.Add(product)).Returns(product);

            var retrieved = service.Add(product);

            Assert.Equal(product.ProductName, retrieved.ProductName);
        }

        [Fact]
        public void Delete_Invokes_RepoDelete()
        {
            var fakeRepo = A.Fake<RepoProduct>();
            var service = new ProductService(fakeRepo);
            var product = new Product();

            service.Delete(product);

            A.CallTo(() => fakeRepo.Delete(product)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void DeleteById_Invokes_RepoDelete()
        {
            var fakeRepo = A.Fake<RepoProduct>();
            var service = new ProductService(fakeRepo);
            var product = new Product();

            service.DeleteById(product.ProductId);

            A.CallTo(() => fakeRepo.Delete(product.ProductId)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetAll_Invokes_RepoGetAll()
        {
            var fakeRepo = A.Fake<RepoProduct>();
            var service = new ProductService(fakeRepo);
            var product = new Product() { ProductName = "Banana" };

            A.CallTo(() => fakeRepo.GetAll()).Returns(new List<Product>(){ product });

            var retrieved = service.GetAll();

            Assert.Equal(product.ProductName, retrieved[0].ProductName);
        }

        [Fact]
        public void GetById_Invokes_RepoGetById()
        {
            var fakeRepo = A.Fake<RepoProduct>();
            var service = new ProductService(fakeRepo);
            var product = new Product() { ProductName = "Banana" };

            A.CallTo(() => fakeRepo.GetById(product.ProductId)).Returns(product);

            var retrieved = service.GetById(product.ProductId);

            Assert.Equal(product.ProductName, retrieved.ProductName);
        }

        [Fact]
        public void Update_Invokes_RepoUpdate()
        {
            var fakeRepo = A.Fake<RepoProduct>();
            var service = new ProductService(fakeRepo);
            var product = new Product() { ProductName = "Banana" };

            A.CallTo(() => fakeRepo.Update(product)).Returns(product);

            var retrieved = service.Update(product);

            Assert.Equal(product.ProductName, retrieved.ProductName);
        }

        [Fact]
        public void Search_Invokes_RepoSearch()
        {
            var fakeRepo = A.Fake<RepoProduct>();
            var service = new ProductService(fakeRepo);
            var product = new Product() { ProductName = "Banana" };

            A.CallTo(() => fakeRepo.Search(product.ProductName)).Returns(new List<Product>(){ product });

            var retrieved = service.Search(product.ProductName);

            Assert.Equal(product.ProductName, retrieved[0].ProductName);
        }

        [Fact]
        public void GetByName_Invokes_RepoGetByName()
        {
            var fakeRepo = A.Fake<RepoProduct>();
            var service = new ProductService(fakeRepo);
            var product = new Product() { ProductName = "Banana" };

            A.CallTo(() => fakeRepo.GetByName(product.ProductName)).Returns(product);

            var retrieved = service.GetByName(product.ProductName);

            Assert.Equal(product.ProductName, retrieved.ProductName);
        }

        [Fact]
        public void IsUnique_Invokes_RepoIsUnique()
        {
            var fakeRepo = A.Fake<RepoProduct>();
            var service = new ProductService(fakeRepo);
            var product = new Product();

            A.CallTo(() => fakeRepo.IsUnique(product)).Returns(true);

            service.IsUnique(product);

            A.CallTo(() => fakeRepo.IsUnique(product)).MustHaveHappenedOnceExactly();
        }
    }
}
