using Xunit;
using Acme.BL;

namespace Acme.BLTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveExistingCustomerTest()
        {
            //Given
            var repository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "Frodo",
                LastName = "Baggins",
                EmailAddress = "baggins@hotmail.com"
            };
            //When
            var actual = repository.Retrieve(1);
            //Then
            Assert.Equal(expected.CustomerID, actual.CustomerID);
            Assert.Equal(expected.FullName, actual.FullName);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
        }

        [Fact]
        public void RetrieveNonExistingCustomerTest()
        {
            //Given
            var repository = new CustomerRepository();
            //When
            var actual = repository.Retrieve(2);
            //Then
            Assert.Null(actual);
        }

        [Fact]
        public void SaveValidCustomerTest()
        {
            //Given
            var repository = new CustomerRepository();
            var customer = new Customer(2)
            {
                LastName = "Lundgren",
                EmailAddress = "lundgren@gmail.com"
            };
            //When
            bool isSaved = repository.Save(customer);
            //Then
            Assert.True(isSaved);
        }
    }
}