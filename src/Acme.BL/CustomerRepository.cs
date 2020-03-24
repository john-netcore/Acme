namespace Acme.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerID)
        {
            if (customerID != 1)
            {
                return null;
            }

            return new Customer(customerID)
            {
                FirstName = "Frodo",
                LastName = "Baggins",
                EmailAddress = "baggins@hotmail.com"
            };
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}