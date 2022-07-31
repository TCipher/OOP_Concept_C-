using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class OrderRepository
    {
        /// <summary>
        /// Retrieves a single order
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            //create an instance of he order class
            //pass on the Required id
            Order order = new Order(orderId);

            //Code that retrieves the defined order
            //Temporaty hard coded values to return 
            //a populated order
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now);
            }

            return order;
        }

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();
            //code that retrieves the defined order fields

            //Temporary Hard-coded data
            if(orderId == 10)
            {
                orderDisplay.FirstName = "Tochukwu";
                orderDisplay.LastName = "Ndefo";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7,0,0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AdressType = 1,
                    StreetLine1 = "Ajala",
                    StreetLine2 = "Alhaji",
                    City = "Lagos",
                    State = "Lagos",
                    Country = "Nigeria",
                    PostalCode = "10001"
                };
            }
            orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();
            //code that retrieves the order items

            //Temporary HArd-coded data
            if(orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    productName = "sunflowers",
                    PurchasePrice = 15.96M,
                    orderQuantity = 2
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
                orderDisplayItem = new OrderDisplayItem()
                {
                    productName = "Rake",
                    PurchasePrice = 6M,
                    orderQuantity = 1
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
            }
            return orderDisplay;
        }
        /// <summary>
        /// Saves the current order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code that saves the defined order
            return true;
        }

    }
}
