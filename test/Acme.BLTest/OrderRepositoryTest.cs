using Acme.BL;
using Xunit;

namespace Acme.BLTest
{
    public class OrderRepositoryTest
    {
        [Fact]
        public void RetrieveExistingOrderTest()
        {
            //Given
            var repository = new OrderRepository();
            var expected = new Order(1)
            {
                OrderDate = new System.DateTimeOffset()
            };
            //When
            var actual = repository.Retrieve(1);
            //Then
            Assert.Equal(expected.OrderID, actual.OrderID);
            Assert.Equal(expected.OrderDate, actual.OrderDate);
        }

        [Fact]
        public void RetrieveNonExistingOrderTest()
        {
            //Given
            var repository = new OrderRepository();
            //When
            var actual = repository.Retrieve(2);
            //Then
            Assert.Null(actual);
        }

        [Fact]
        public void SaveValidOrderTest()
        {
            //Given
            var repository = new OrderRepository();
            var order = new Order(2)
            {
                OrderDate = new System.DateTimeOffset()
            };
            //When
            bool isSaved = repository.Save(order);
            //Then
            Assert.True(isSaved);
        }
    }
}