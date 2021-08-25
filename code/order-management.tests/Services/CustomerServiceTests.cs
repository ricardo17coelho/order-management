using FakeItEasy;
using order_management.Services;
using System.Collections.Generic;
using Xunit;

namespace order_management.tests.Services
{
    public class CustomerServiceTests
    {
        [Fact]
        public void Add_Invokes_RepoAdd()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);
            var customer = new Customer() { FirstName = "Hans" };

            A.CallTo(() => fakeRepo.Add(customer)).Returns(customer);

            var retrieved = service.Add(customer);

            Assert.Equal(customer.FirstName, retrieved.FirstName);
        }

        [Fact]
        public void Delete_Invokes_RepoDelete()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);
            var customer = new Customer();

            service.Delete(customer);

            A.CallTo(() => fakeRepo.Delete(customer)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void DeleteById_Invokes_RepoDelete()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);
            var customer = new Customer();

            service.DeleteById(customer.CustomerId);

            A.CallTo(() => fakeRepo.Delete(customer.CustomerId)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetAll_Invokes_RepoGetAll()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);
            var customer = new Customer() { FirstName = "Hans" };

            A.CallTo(() => fakeRepo.GetAll()).Returns(new List<Customer>(){ customer });

            var retrieved = service.GetAll();

            Assert.Equal(customer.FirstName, retrieved[0].FirstName);
        }

        [Fact]
        public void GetById_Invokes_RepoGetById()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);
            var customer = new Customer() { FirstName = "Hans" };

            A.CallTo(() => fakeRepo.GetById(customer.CustomerId)).Returns(customer);

            var retrieved = service.GetById(customer.CustomerId);

            Assert.Equal(customer.FirstName, retrieved.FirstName);
        }

        [Fact]
        public void Update_Invokes_RepoUpdate()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);
            var customer = new Customer() { FirstName = "Hans" };

            A.CallTo(() => fakeRepo.Update(customer)).Returns(customer);

            var retrieved = service.Update(customer);

            Assert.Equal(customer.FirstName, retrieved.FirstName);
        }

        [Fact]
        public void Search_Invokes_RepoSearch()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);
            var customer = new Customer() { FirstName = "Hans" };

            A.CallTo(() => fakeRepo.Search(customer.FirstName)).Returns(new List<Customer>(){ customer });

            var retrieved = service.Search(customer.FirstName);

            Assert.Equal(customer.FirstName, retrieved[0].FirstName);
        }

        [Fact]
        public void GetByName_Invokes_RepoGetByName()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);
            var customer = new Customer() { FirstName = "Hans", LastName = "Im Glück" };

            A.CallTo(() => fakeRepo.GetByName(customer.FirstName, customer.LastName)).Returns(customer);

            var retrieved = service.GetByName(customer.FirstName, customer.LastName);

            Assert.Equal(customer.FirstName, retrieved.FirstName);
        }

        [Fact]
        public void IsUnique_Invokes_RepoIsUnique()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);
            var customer = new Customer();

            A.CallTo(() => fakeRepo.IsUnique(customer)).Returns(true);

            service.IsUnique(customer);

            A.CallTo(() => fakeRepo.IsUnique(customer)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void RequiredFieldsAreNotBlank_ReturnsTrue()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);
            var customer = new Customer()
            {
                CustomerNr = "CU12345",
                FirstName = "Hans",
                LastName = "Ueli",
                Email = "hans@ueli.ch",
                Website = "hans.ueli.ch",
                Password = "Super@Save2000"
            };

            Assert.True(service.RequiredFieldsAreNotBlank(customer));
        }

        [Fact]
        public void IsValidEmailAddress_ReturnsTrue()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);

            Assert.True(service.IsValidEmailAddress("foo@demo.net"));
            Assert.True(service.IsValidEmailAddress("bar.ba@test.co.uk"));
            Assert.True(service.IsValidEmailAddress("email.subdoms@dosmmda.com"));
            Assert.True(service.IsValidEmailAddress("matteo@78.47.122.114"));
            Assert.True(service.IsValidEmailAddress("webmaster@müller.de"));
        }

        [Fact]
        public void IsValidEmailAddress_ReturnsFalse()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);

            Assert.False(service.IsValidEmailAddress("foo"));
            Assert.False(service.IsValidEmailAddress("bar@"));
            Assert.False(service.IsValidEmailAddress("@barfoo"));
            Assert.False(service.IsValidEmailAddress("foo@bar"));
            Assert.False(service.IsValidEmailAddress("text@asd@f.com"));
            Assert.False(service.IsValidEmailAddress("text @asdf.com"));
        }

        [Fact]
        public void IsValidCustomerNr_ReturnsTrue()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);

            Assert.True(service.IsValidCustomerNr("CU12345"));
            Assert.True(service.IsValidCustomerNr("CU67890"));
            Assert.True(service.IsValidCustomerNr("CU00000"));
            Assert.True(service.IsValidCustomerNr("CU54905"));
        }

        [Fact]
        public void IsValidCustomerNr_ReturnsFalse()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);

            Assert.False(service.IsValidCustomerNr("12345"));
            Assert.False(service.IsValidCustomerNr("67890CU"));
            Assert.False(service.IsValidCustomerNr("CU000000"));
            Assert.False(service.IsValidCustomerNr("CU0000"));
        }

        [Fact]
        public void IsValidWebsite_ReturnsTrue()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);

            Assert.True(service.IsValidWebsite("www.google.ch"));
            Assert.True(service.IsValidWebsite("http://www.google.com"));
            Assert.True(service.IsValidWebsite("https://www.google.com"));
            Assert.True(service.IsValidWebsite("https://policies.google.com"));
            Assert.True(service.IsValidWebsite("https://policies.google.com"));
            Assert.True(service.IsValidWebsite("https://policies.google.com/technologies/voice?hl=de&gl=ch"));
            Assert.True(service.IsValidWebsite("google.com"));
        }

        [Fact]
        public void IsValidWebsite_ReturnsFalse()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);

            Assert.False(service.IsValidWebsite("google."));
            Assert.False(service.IsValidWebsite(".google"));
            Assert.False(service.IsValidWebsite("g-.com"));
            Assert.False(service.IsValidWebsite(".com"));
            Assert.False(service.IsValidWebsite("0-0o_.comh"));
        }

        [Fact]
        public void IsValidPassword_ReturnsTrue()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);

            Assert.True(service.IsValidPassword("11111&aA"));
            Assert.True(service.IsValidPassword("aaaaa$A1"));
            Assert.True(service.IsValidPassword("@$!%*?&aA1s"));
            Assert.True(service.IsValidPassword("QWERasd&f123456"));
        }

        [Fact]
        public void IsValidPassword_ReturnsFalse()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);

            Assert.False(service.IsValidPassword("111111a&a"));
            Assert.False(service.IsValidPassword("Aa1D5!"));
            Assert.False(service.IsValidPassword(""));
            Assert.False(service.IsValidPassword("ASDFWERTFDSJ"));
            Assert.False(service.IsValidPassword("asdfuS?DgDfn"));
        }
    }
}
