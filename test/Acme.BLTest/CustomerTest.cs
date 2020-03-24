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
                LastName = "Baggins"
            };
            var expected = "Baggins, Balbo";

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
                LastName = "Baggins"
            };
            var expected = "Baggins";

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
                LastName = "Baggins"
            };
            var expected = "Baggins";

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

        [Fact]
        public void FullNameWithNullAsBothNamesTest()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = null,
                LastName = null
            };
            var expected = string.Empty;

            //Act
            var actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameWithSpacesAsFirstNameTest()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "    ",
                LastName = "Baggins"
            };
            var expected = "Baggins";

            //Act
            var actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameWithSpacesAsLastNameTest()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "      "
            };
            var expected = "Bilbo";

            //Act
            var actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameWithSpacesBothNamesTest()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "   ",
                LastName = "      "
            };
            var expected = string.Empty;

            //Act
            var actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateIsValid()
        {
            //Given
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "@microsoft.com"
            };
            //When
            bool isValid = customer.Validate();
            //Then
            Assert.True(isValid);
        }

        [Fact]
        public void ValidateInvalidEmail()
        {
            //Given
            var customer = new Customer
            {
                EmailAddress = "",
                LastName = "Baggins"
            };
            //When
            bool isValid = customer.Validate();
            //Then
            Assert.False(isValid);
        }

        [Fact]
        public void ValidateInvalidLastName()
        {
            //Given
            var customer = new Customer
            {
                EmailAddress = "baggins@microsoft.com",
                LastName = "     "
            };
            //When
            bool isValid = customer.Validate();
            //Then
            Assert.False(isValid);
        }

        [Fact]
        public void ValidateInvalidEmailAndLastName()
        {
            //Given
            var customer = new Customer
            {
                EmailAddress = "   ",
                LastName = null
            };
            //When
            bool isValid = customer.Validate();
            //Then
            Assert.False(isValid);
        }
    }
}
