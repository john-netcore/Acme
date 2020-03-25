using System.Collections.Generic;

namespace Acme.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressID)
        {
            if (addressID != 1)
            {
                return null;
            }
            return new Address(1)
            {
                StreetLine1 = "Fågelviksvägen 1",
                City = "Stockholm",
                PostalCode = "14553"
            };
        }

        public IEnumerable<Address> RetrieveByCustomerID(int customerID)
        {
            if (customerID != 1)
            {
                return null;
            }

            return new List<Address>()
            {
                new Address(1)
                {
                    StreetLine1 = "Fågelviksvägen 1",
                    City = "Stockholm",
                    PostalCode = "14553"
                },
                new Address(2)
                {
                    StreetLine1 = "Ankvägen",
                    City = "Ankeborg",
                    PostalCode = "14575"
                }
            };
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}