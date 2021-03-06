﻿using System.Collections.Generic;
using Acme.Common;

namespace Acme.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer() : this(0)
        {

        }

        public Customer(int customerID)
        {
            CustomerID = customerID;
            Addresses = new List<Address>();
        }

        public int CustomerID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> Addresses { get; set; }
        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrWhiteSpace(LastName))
                {
                    return string.Empty;
                }
                else if (string.IsNullOrWhiteSpace(FirstName))
                {
                    return LastName;
                }
                else if (string.IsNullOrWhiteSpace(LastName))
                {
                    return FirstName;
                }
                else
                {
                    return LastName + ", " + FirstName;
                }
            }
        }

        public override bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(EmailAddress))
                isValid = false;
            if (string.IsNullOrWhiteSpace(LastName))
                isValid = false;

            return isValid;
        }

        public string Log() => $"{CustomerID}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

        public override string ToString() => $"{CustomerID} {FullName}";

    }
}
