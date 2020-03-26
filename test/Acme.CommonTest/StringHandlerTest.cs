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
            string content = "GiantMouseTrap";
            string expected = "Giant Mouse Trap";
            //Act
            string actual = content.InsertSpaces();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertSpacesWithNullValueTest()
        {
            //Arrange
            string content = null;
            //Act
            string actual = content.InsertSpaces();
            //Assert
            Assert.Null(actual);
        }

        [Fact]
        public void InsertSpacesWithEmptyStringTest()
        {
            //Arrange
            string content = string.Empty;
            string expected = string.Empty;
            //Act
            string actual = content.InsertSpaces();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertSpacesWithAlreadyExistingSpacesTest()
        {
            //Arrange
            string content = "Giant Mouse Trap";
            string expected = "Giant Mouse Trap";
            //Act
            string actual = content.InsertSpaces();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertSpacesWithAlreadyExistingSpacesWithLowerCaseTest()
        {
            //Arrange
            string content = "Giant mouse trap";
            string expected = "Giant mouse trap";
            //Act
            string actual = content.InsertSpaces();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
