﻿using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }

        }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public static int InstanceCount {get; set;}

        public Customer Retrieve(int customerId)
        {
            //Code that retrieves the defined customer
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            //Code that retrives all of the customers
            return new List<Customer>();
        }
        public bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
        
    }
}
