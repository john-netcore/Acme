namespace Acme.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressID)
        {
            AddressID = addressID;
        }

        public int AddressID { get; private set; }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            if (PostalCode == null)
                isValid = false;

            return isValid;
        }
    }
}