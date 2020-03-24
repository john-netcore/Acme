namespace Acme.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderID)
        {
            if (orderID != 1)
            {
                return null;
            }

            return new Order(1)
            {
                OrderDate = new System.DateTimeOffset(),
            };
        }

        public bool Save(Order order)
        {
            return true;
        }
    }
}