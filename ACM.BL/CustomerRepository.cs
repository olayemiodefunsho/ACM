using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        
        private AddressRepository addressRepository { get; set; }
        
        public Customer Retrieve(int customerId)
        {
            // Create an instance of the customer class
            // Pass in the requested id
            Customer customer = new Customer(customerId);

            // Code that retrieves the defined customer

            // Temporary hard coded values to return a poplulated customer
            if(customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }
        public bool Save(Customer customer)
        {
            // Code that saves the passed in customer

            return true;
        }
        
    }
}
