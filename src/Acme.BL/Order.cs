using System;

namespace Acme.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderID)
        {
            OrderID = orderID;
        }

        public int OrderID { get; private set; }

        // DateTimeOFfset type is good for handling DateTimes for different Time zones (For comparing dates from different Time zones).
        public DateTimeOffset? OrderDate { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null)
                isValid = false;

            return isValid;
        }
    }
}