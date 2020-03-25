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
            bool success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call an insert stored procedure
                    }
                    else
                    {
                        // Call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}