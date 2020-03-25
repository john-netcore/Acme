using System.Linq;

namespace Acme.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        // A collaborative relationship. The customer uses the AddressRepository to populate the customers addresses.
        private AddressRepository addressRepository { get; set; }
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
                EmailAddress = "baggins@hotmail.com",
                Addresses = addressRepository.RetrieveByCustomerID(customerID).ToList()
            };
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}