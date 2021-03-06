using System;
using System.Collections.Generic;
using Acme.Common;

namespace Acme.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order() : this(0)
        {

        }

        public Order(int orderID)
        {
            OrderID = orderID;
            OrderItems = new List<OrderItem>();
        }

        public int OrderID { get; private set; }

        // DateTimeOffset type is good for handling DateTimes for different Time zones (For comparing dates from different Time zones).
        public DateTimeOffset? OrderDate { get; set; }
        public int CustomerID { get; set; }
        public int ShippingAddressID { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public override bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null)
                isValid = false;

            return isValid;
        }

        public override string ToString() => $"{OrderID} {OrderDate}";

        public string Log() => $"{OrderID}: {OrderDate} Status: {EntityState.ToString()}";
    }
}