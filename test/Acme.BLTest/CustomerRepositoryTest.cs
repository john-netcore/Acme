using Xunit;
using Acme.BL;
using System.Collections.Generic;

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
                EmailAddress = "baggins@hotmail.com",
                Addresses = new List<Address>()
                {
                    new Address(1)
                    {
                        StreetLine1 = "Fågelviksvägen 1",
                        City = "Stockholm",
                        PostalCode = "14553"
                    },
                    new Address(2)
                    {
                        StreetLine1 = "Ankvägen",
                        City = "Ankeborg",
                        PostalCode = "14575"
                    }
                }
            };
            //When
            var actual = repository.Retrieve(1);
            //Then
            Assert.Equal(expected.CustomerID, actual.CustomerID);
            Assert.Equal(expected.FullName, actual.FullName);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.Addresses[0].PostalCode, actual.Addresses[0].PostalCode);
            Assert.Equal(expected.Addresses[1].PostalCode, actual.Addresses[1].PostalCode);
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