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
        public void FirstAndLastNameCorrectTest()
        {
            //Given
            var customer = new Customer
            {
                FirstName = "Balbo",
                LastName = "Baggins"
            };
            //When
            bool isValid = customer.Validate();
            //Then
            Assert.True(isValid);
        }

        [Fact]
        public void EmptyFirstNameTest()
        {
            //Given
            var customer = new Customer
            {
                FirstName = "",
                LastName = "Baggins"
            };
            //When
            bool isValid = customer.Validate();
            //Then
            Assert.False(isValid);
        }

        [Fact]
        public void EmptyLastNameTest()
        {
            //Given
            var customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = ""
            };
            //When
            bool isValid = customer.Validate();
            //Then
            Assert.False(isValid);
        }

        [Fact]
        public void FirstAndLastNameEmptyTest()
        {
            //Given
            var customer = new Customer
            {
                FirstName = "",
                LastName = ""
            };
            //When
            bool isValid = customer.Validate();
            //Then
            Assert.False(isValid);
        }

        [Fact]
        public void FirstNameNullTest()
        {
            //Given
            var customer = new Customer
            {
                FirstName = null,
                LastName = "Baggins"
            };
            //When
            bool isValid = customer.Validate();
            //Then
            Assert.False(isValid);
        }

        [Fact]
        public void LastNameNullTest()
        {
            //Given
            var customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = null
            };
            //When
            bool isValid = customer.Validate();
            //Then
            Assert.False(isValid);
        }

        [Fact]
        public void FirstAndLastNameNullTest()
        {
            //Given
            var customer = new Customer
            {
                FirstName = null,
                LastName = null
            };
            //When
            bool isValid = customer.Validate();
            //Then
            Assert.False(isValid);
        }

        [Fact]
        public void SpacesFirstNameTest()
        {
            //Given
            var customer = new Customer
            {
                FirstName = "         ",
                LastName = "Baggins"
            };
            //When
            bool isValid = customer.Validate();
            //Then
            Assert.False(isValid);
        }

        [Fact]
        public void SpacesLastNameTest()
        {
            //Given
            var customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "          "
            };
            //When
            bool isValid = customer.Validate();
            //Then
            Assert.False(isValid);
        }

        [Fact]
        public void FirstAndLastNameSpacesTest()
        {
            //Given
            var customer = new Customer
            {
                FirstName = "        ",
                LastName = "       "
            };
            //When
            bool isValid = customer.Validate();
            //Then
            Assert.False(isValid);
        }
    }
}
