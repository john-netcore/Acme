namespace Acme.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productID)
        {
            if (productID != 1)
            {
                return null;
            }

            return new Product(productID)
            {
                Name = "Giant Fly Paper",
                CurrentPrice = 123.99M
            };
        }

        public bool Save(Product product)
        {
            return true;
        }
    }
}