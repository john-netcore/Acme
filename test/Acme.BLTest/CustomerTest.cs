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

        [Fact]
        public void FullNameWithEmptyFirstNameTest()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = String.Empty,
                LastName = "Biggins"
            };
            var expected = "Biggins";

            //Act
            var actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameWithEmptyLastNameTest()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Balbo",
                LastName = string.Empty
            };
            var expected = "Balbo";

            //Act
            var actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameWithNullAsFirstNameTest()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = null,
                LastName = "Biggins"
            };
            var expected = "Biggins";

            //Act
            var actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameWithNullAsLastNameTest()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Balbo",
                LastName = null
            };
            var expected = "Balbo";

            //Act
            var actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
