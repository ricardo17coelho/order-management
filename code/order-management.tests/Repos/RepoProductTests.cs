using System.Collections.Generic;
using Xunit;

namespace order_management.tests.Repos
{
    public class RepoProductTests
    {
        [Fact]
        public void GetAllReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoProduct(fakeContext);

            var retrieved = (List<Product>)repo.GetAll();

            Assert.Equal(1000, retrieved[0].ProductId);
        }

        [Fact]
        public void GetByIdReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoProduct(fakeContext);

            var retrieved = repo.GetById(1000);

            Assert.Equal(1000, retrieved.ProductId);
        }

        [Fact]
        public void GetByNameReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoProduct(fakeContext);

            var retrieved = repo.GetByName("HP Compaq 24 Inch");

            Assert.Equal(1000, retrieved.ProductId);
        }

        [Fact]
        public void SearchReturnsValidEntity()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoProduct(fakeContext);

            var retrieved = repo.Search("HP Compaq 24 Inch");

            Assert.Equal(1000, retrieved[0].ProductId);
        }

        [Fact]
        public void IsUniqueReturnsFalse()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoProduct(fakeContext);
            var Product = new Product() { ProductName = "HP Compaq 24 Inch" }; 
            Assert.False(repo.IsUnique(Product));
        }

        [Fact]
        public void IsUniqueReturnsTrue()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoProduct(fakeContext);
            var Product = new Product() { ProductName = "Awesome Product" };
            Assert.True(repo.IsUnique(Product));
        }

        [Fact]
        public void IsValidReturnsTrue()
        {
            var fakeContext = new FakeContext();
            var repo = new RepoProduct(fakeContext);
            Assert.True(repo.IsValid(new Product() { ProductName = "Fruits" }));
        }

    }
}
