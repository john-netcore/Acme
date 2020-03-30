using Acme.Common;

namespace Acme.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product() : this(0)
        {

        }

        public Product(int productID)
        {
            ProductID = productID;
        }

        public int ProductID { get; private set; }

        public string Name
        {
            get
            {
                return name.InsertSpaces();
            }
            set { name = value; }
        }

        public string Description { get; set; }

        public decimal? CurrentPrice { get; set; }

        public override bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(Name))
                isValid = false;
            if (CurrentPrice == null)
                isValid = false;

            return isValid;
        }

        public string Log() => $"{ProductID}: {Name} Detail: {Description} Status: {EntityState.ToString()}";

        public override string ToString() => $"{ProductID} {Name}";

        private string name;

    }
}