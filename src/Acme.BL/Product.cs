using System;

namespace Acme.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productID)
        {
            ProductID = productID;
        }

        public int ProductID { get; private set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description { get; set; }

        public decimal? CurrentPrice { get; set; }

        public Product Retrieve()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(Name))
                isValid = false;
            if (CurrentPrice == null)
                isValid = false;

            return isValid;
        }

        private string name;

    }
}