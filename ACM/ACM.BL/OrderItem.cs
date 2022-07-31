using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }
        public int OrderItemId { get; set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Retrieves a defined order item
        /// </summary>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            // code that Retrieves a defined Order item
            return new OrderItem();
        }
        /// <summary>
        /// code saves an order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code that saves an Order item
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (OrderQuantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
