using Acme.Common;
using Xunit;

namespace Acme.CommonTest
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpacesWithValidStringTest()
        {
            //Arrange
            string input = "GiantMouseTrap";
            string expected = "Giant Mouse Trap";
            //Act
            string actual = StringHandler.InsertSpaces(input);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertSpacesWithNullValueTest()
        {
            //Arrange
            string input = null;
            //Act
            string actual = StringHandler.InsertSpaces(input);
            //Assert
            Assert.Null(actual);
        }

        [Fact]
        public void InsertSpacesWithEmptyStringTest()
        {
            //Arrange
            string input = string.Empty;
            string expected = string.Empty;
            //Act
            string actual = StringHandler.InsertSpaces(input);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertSpacesWithAlreadyExistingSpacesTest()
        {
            //Arrange
            string input = "Giant Mouse Trap";
            string expected = "Giant Mouse Trap";
            //Act
            string actual = StringHandler.InsertSpaces(input);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertSpacesWithAlreadyExistingSpacesWithLowerCaseTest()
        {
            //Arrange
            string input = "Giant mouse trap";
            string expected = "Giant mouse trap";
            //Act
            string actual = StringHandler.InsertSpaces(input);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
