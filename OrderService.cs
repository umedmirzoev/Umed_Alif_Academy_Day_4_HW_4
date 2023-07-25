using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umed_Alif_Academy_Day_4_HW_4
{
    public class OrderService
    {
        public Order CreateOrder(int orderId, string description, decimal price, DateTime orderDate, string deliveryType, string deliveryAddress)
        {
            Order order = new Order
            {
                OrderID = orderId,
                Description = description,
                Price = price,
                OrderDate = orderDate,
                DeliveryType = deliveryType,
                DeliveryAddress = deliveryAddress
            };

            return order;
        }
    }
}
