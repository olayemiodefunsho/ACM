using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            // Create an instance of the customer class
            // Pass in the requested id
            Product product = new Product(productId);

            // Code that retrieves the defined customer

            // Temporary hard coded values to return a poplulated customer
            if(productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini SunFlowers";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }
        public bool Save(Product product)
        {
            // Code that saves the passed in customer

            return true;
        }
        
    }
}
