using System.Collections.Generic;
using Xunit;

namespace order_management.tests.Repos
{
    public class RepoProductCategoryTests
    {
        [Fact]
        public void GetAllReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoProductCategory(fakeContext);

            var retrieved = (List<ProductCategory>)repo.GetAll();

            Assert.Equal(1000, retrieved[0].ProductCategoryId);
        }

        [Fact]
        public void GetByIdReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoProductCategory(fakeContext);

            var retrieved = repo.GetById(1000);

            Assert.Equal(1000, retrieved.ProductCategoryId);
        }

        [Fact]
        public void GetByNameReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoProductCategory(fakeContext);

            var retrieved = repo.GetByName("Computer Equipment");

            Assert.Equal(1000, retrieved.ProductCategoryId);
        }

        [Fact]
        public void SearchReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoProductCategory(fakeContext);

            var retrieved = repo.Search("Computer Equipment");

            Assert.Equal(1000, retrieved[0].ProductCategoryId);
        }

        [Fact]
        public void IsUniqueReturnsFalse()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoProductCategory(fakeContext);
            var ProductCategory = new ProductCategory() { ProductCategoryName = "Computer Equipment" }; 
            Assert.False(repo.IsUnique(ProductCategory));
        }

        [Fact]
        public void IsUniqueReturnsTrue()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoProductCategory(fakeContext);
            var ProductCategory = new ProductCategory() { ProductCategoryName = "Awesome Stuff" };
            Assert.True(repo.IsUnique(ProductCategory));
        }

        [Fact]
        public void GetChildrenByParentIdReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoProductCategory(fakeContext);
            Assert.Equal("Monitors", repo.GetChildrenByParentId(1000)[0].ProductCategoryName);
        }

        [Fact]
        public void IsValidReturnsTrue()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoProductCategory(fakeContext);
            Assert.True(repo.IsValid(new ProductCategory() { ProductCategoryName = "Fruits" }));
        }

        [Fact]
        public void GetCteDataReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoProductCategory(fakeContext);

            var entities = repo.GetCteDataForTreeView();

            Assert.Equal("Computer Equipment", entities[0].ProductCategoryName);
        }
    }
}
