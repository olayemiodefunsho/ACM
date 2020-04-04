using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
            
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }



        public OrderItem Retrieve(int orderItemId)
        {
            //Code that retrieves the defined customer
            return new OrderItem();
        }

        public bool Save()
        {
            // Code that saves the defined product
            return true;
        }
        public bool Validate()
        {
            var isValid = true;

            if(Quantity <= 0) isValid = false;
            if(ProductId <= 0) isValid = false;
            if(PurchasePrice == null) isValid = false;

            return isValid;
        }
        
    }
}
