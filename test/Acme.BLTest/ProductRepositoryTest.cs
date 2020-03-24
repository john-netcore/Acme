using Acme.BL;
using Xunit;

namespace Acme.BLTest
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void RetrieveExistingProductTest()
        {
            //Given
            var repository = new ProductRepository();
            var expected = new Product(1)
            {
                Name = "Giant Fly Paper",
                CurrentPrice = 123.99M
            };
            //When
            var actual = repository.Retrieve(1);
            //Then
            Assert.Equal(expected.ProductID, actual.ProductID);
            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
            Assert.Equal(expected.Name, actual.Name);
        }

        [Fact]
        public void RetrieveNonExistingProductTest()
        {
            //Given
            var repository = new ProductRepository();
            //When
            var actual = repository.Retrieve(2);
            //Then
            Assert.Null(actual);
        }

        [Fact]
        public void SaveValidProductTest()
        {
            //Given
            var repository = new ProductRepository();
            var product = new Product(2)
            {
                Name = "Giant mouse trap",
                CurrentPrice = 1099.99M
            };
            //When
            bool isSaved = repository.Save(product);
            //Then
            Assert.True(isSaved);
        }
    }
}