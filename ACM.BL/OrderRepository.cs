using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            // Create an instance of the customer class
            // Pass in the requested id
            Order order = new Order(orderId);

            // Code that retrieves the defined customer

            // Temporary hard coded values to return a poplulated customer
            if(orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));

            }

            return order;
        }
        public bool Save(Order order)
        {
            // Code that saves the passed in customer

            return true;
        }
        
    }
}
