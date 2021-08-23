using FakeItEasy;
using NUnit.Framework;
using order_management.Services;
namespace order_management.tests.Services
{
    [TestFixture]
    class CustomerServiceTests
    {
        [Test]
        public void IsValidEmailAddress_ReturnsTrue()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);

            Assert.That(service.IsValidEmailAddress("foo@demo.net"), Is.EqualTo(true));
            Assert.That(service.IsValidEmailAddress("bar.ba@test.co.uk"), Is.EqualTo(true));
            Assert.That(service.IsValidEmailAddress("email.subdoms@dosmmda.com"), Is.EqualTo(true));
            Assert.That(service.IsValidEmailAddress("matteo@78.47.122.114"), Is.EqualTo(true));
            Assert.That(service.IsValidEmailAddress("webmaster@müller.de"), Is.EqualTo(true));
        }

        [Test]
        public void IsValidEmailAddress_ReturnsFalse()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);

            Assert.That(service.IsValidEmailAddress("foo"), Is.EqualTo(false));
            Assert.That(service.IsValidEmailAddress("bar@"), Is.EqualTo(false));
            Assert.That(service.IsValidEmailAddress("@barfoo"), Is.EqualTo(false));
            Assert.That(service.IsValidEmailAddress("foo@bar"), Is.EqualTo(false));
            Assert.That(service.IsValidEmailAddress("text@asd@f.com"), Is.EqualTo(false));
            Assert.That(service.IsValidEmailAddress("text @asdf.com"), Is.EqualTo(false));
        }

        [Test]
        public void IsValidCustomerNr_ReturnsTrue()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);

            Assert.That(service.IsValidCustomerNr("CU12345"), Is.EqualTo(true));
            Assert.That(service.IsValidCustomerNr("CU67890"), Is.EqualTo(true));
            Assert.That(service.IsValidCustomerNr("CU00000"), Is.EqualTo(true));
            Assert.That(service.IsValidCustomerNr("CU54905"), Is.EqualTo(true));
        }

        [Test]
        public void IsValidCustomerNr_ReturnsFalse()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);

            Assert.That(service.IsValidCustomerNr("12345"), Is.EqualTo(false));
            Assert.That(service.IsValidCustomerNr("67890CU"), Is.EqualTo(false));
            Assert.That(service.IsValidCustomerNr("CU000000"), Is.EqualTo(false));
            Assert.That(service.IsValidCustomerNr("CU0000"), Is.EqualTo(false));
        }

        [Test]
        public void IsValidWebsite_ReturnsTrue()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);

            Assert.That(service.IsValidWebsite("www.google.ch"), Is.EqualTo(true));
            Assert.That(service.IsValidWebsite("http://www.google.com"), Is.EqualTo(true));
            Assert.That(service.IsValidWebsite("https://www.google.com"), Is.EqualTo(true));
            Assert.That(service.IsValidWebsite("https://policies.google.com"), Is.EqualTo(true));
            Assert.That(service.IsValidWebsite("https://policies.google.com/technologies/voice?hl=de&gl=ch"), Is.EqualTo(true));
            Assert.That(service.IsValidWebsite("google.com"), Is.EqualTo(true));
        }

        [Test]
        public void IsValidWebsite_ReturnsFalse()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);

            Assert.That(service.IsValidWebsite("google."), Is.EqualTo(false));
            Assert.That(service.IsValidWebsite(".google"), Is.EqualTo(false));
            Assert.That(service.IsValidWebsite("g-.com"), Is.EqualTo(false));
            Assert.That(service.IsValidWebsite(".com"), Is.EqualTo(false));
            Assert.That(service.IsValidWebsite("0-0o_.com"), Is.EqualTo(false));
        }

        [Test]
        public void IsValidPassword_ReturnsTrue()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);

            Assert.That(service.IsValidPassword("11111&aA"), Is.EqualTo(true));
            Assert.That(service.IsValidPassword("aaaaa$A1"), Is.EqualTo(true));
            Assert.That(service.IsValidPassword("@$!%*?&aA1s"), Is.EqualTo(true));
            Assert.That(service.IsValidPassword("QWERasd&f123456"), Is.EqualTo(true));
        }

        [Test]
        public void IsValidPassword_ReturnsFalse()
        {
            var fakeRepo = A.Fake<RepoCustomer>();
            var service = new CustomerService(fakeRepo);

            Assert.That(service.IsValidPassword("111111a&a"), Is.EqualTo(false));
            Assert.That(service.IsValidPassword("Aa1D5!"), Is.EqualTo(false));
            Assert.That(service.IsValidPassword(""), Is.EqualTo(false));
            Assert.That(service.IsValidPassword("ASDFWERTFDSJ"), Is.EqualTo(false));
            Assert.That(service.IsValidPassword("asdfuS?DgDfn"), Is.EqualTo(false));
        }
    }
}
