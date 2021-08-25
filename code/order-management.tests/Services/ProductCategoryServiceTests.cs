using FakeItEasy;
using order_management.Services;
using System.Collections.Generic;
using Xunit;

namespace order_management.tests.Services
{
    public class ProductCategoryServiceTests
    {
        [Fact]
        public void Add_Invokes_RepoAdd()
        {
            var fakeRepo = A.Fake<RepoProductCategory>();
            var service = new ProductCategoryService(fakeRepo);
            var productCategory = new ProductCategory() { ProductCategoryName = "Fruits" };

            A.CallTo(() => fakeRepo.Add(productCategory)).Returns(productCategory);

            var retrieved = service.Add(productCategory);

            Assert.Equal(productCategory.ProductCategoryName, retrieved.ProductCategoryName);
        }

        [Fact]
        public void Delete_Invokes_RepoDelete()
        {
            var fakeRepo = A.Fake<RepoProductCategory>();
            var service = new ProductCategoryService(fakeRepo);
            var productCategory = new ProductCategory();

            service.Delete(productCategory);

            A.CallTo(() => fakeRepo.Delete(productCategory)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void DeleteById_Invokes_RepoDelete()
        {
            var fakeRepo = A.Fake<RepoProductCategory>();
            var service = new ProductCategoryService(fakeRepo);
            var productCategory = new ProductCategory();

            service.DeleteById(productCategory.ProductCategoryId);

            A.CallTo(() => fakeRepo.Delete(productCategory.ProductCategoryId)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetAll_Invokes_RepoGetAll()
        {
            var fakeRepo = A.Fake<RepoProductCategory>();
            var service = new ProductCategoryService(fakeRepo);
            var productCategory = new ProductCategory() { ProductCategoryName = "Fruits" };

            A.CallTo(() => fakeRepo.GetAll()).Returns(new List<ProductCategory>(){ productCategory });

            var retrieved = service.GetAll();

            Assert.Equal(productCategory.ProductCategoryName, retrieved[0].ProductCategoryName);
        }

        [Fact]
        public void GetById_Invokes_RepoGetById()
        {
            var fakeRepo = A.Fake<RepoProductCategory>();
            var service = new ProductCategoryService(fakeRepo);
            var productCategory = new ProductCategory() { ProductCategoryName = "Fruits" };

            A.CallTo(() => fakeRepo.GetById(productCategory.ProductCategoryId)).Returns(productCategory);

            var retrieved = service.GetById(productCategory.ProductCategoryId);

            Assert.Equal(productCategory.ProductCategoryName, retrieved.ProductCategoryName);
        }

        [Fact]
        public void Update_Invokes_RepoUpdate()
        {
            var fakeRepo = A.Fake<RepoProductCategory>();
            var service = new ProductCategoryService(fakeRepo);
            var productCategory = new ProductCategory() { ProductCategoryName = "Fruits" };

            A.CallTo(() => fakeRepo.Update(productCategory)).Returns(productCategory);

            var retrieved = service.Update(productCategory);

            Assert.Equal(productCategory.ProductCategoryName, retrieved.ProductCategoryName);
        }

        [Fact]
        public void Search_Invokes_RepoSearch()
        {
            var fakeRepo = A.Fake<RepoProductCategory>();
            var service = new ProductCategoryService(fakeRepo);
            var productCategory = new ProductCategory() { ProductCategoryName = "Fruits" };

            A.CallTo(() => fakeRepo.Search(productCategory.ProductCategoryName)).Returns(new List<ProductCategory>(){ productCategory });

            var retrieved = service.Search(productCategory.ProductCategoryName);

            Assert.Equal(productCategory.ProductCategoryName, retrieved[0].ProductCategoryName);
        }

        [Fact]
        public void GetByName_Invokes_RepoGetByName()
        {
            var fakeRepo = A.Fake<RepoProductCategory>();
            var service = new ProductCategoryService(fakeRepo);
            var productCategory = new ProductCategory() { ProductCategoryName = "Fruits" };

            A.CallTo(() => fakeRepo.GetByName(productCategory.ProductCategoryName)).Returns(productCategory);

            var retrieved = service.GetByName(productCategory.ProductCategoryName);

            Assert.Equal(productCategory.ProductCategoryName, retrieved.ProductCategoryName);
        }

        [Fact]
        public void IsUnique_Invokes_RepoIsUnique()
        {
            var fakeRepo = A.Fake<RepoProductCategory>();
            var service = new ProductCategoryService(fakeRepo);
            var productCategory = new ProductCategory();

            A.CallTo(() => fakeRepo.IsUnique(productCategory)).Returns(true);

            service.IsUnique(productCategory);

            A.CallTo(() => fakeRepo.IsUnique(productCategory)).MustHaveHappenedOnceExactly();
        }
    }
}
