using System;
using Acme.BL;
using Xunit;

namespace Acme.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Balbo",
                LastName = "Biggins"
            };
            var expected = "Biggins, Balbo";

            //Act
            var actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
