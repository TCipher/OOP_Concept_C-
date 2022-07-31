using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public  class ProductRepository
    {
        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            //create the instances of the product class
            //pass in the required id
            Product product = new Product(productId);
            //code thatretieves the defined product
            //Temporary hard coded values to return
            //a populated product
            if(productId == 2)
            {
                product.ProductName = "sunflowers";
                product.ProductDescription = "Assorted Size";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        /// <summary>
        /// saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;
            if(product.HasChanges && product.Isvalid)
            {
                if (product.IsNew)
                {
                    //call an insert Stored Procedure
                }
                else
                {
                    //call an update stored procedure
                }
            }
            //code that saves the defined product
            return success;
        }

    }
}
