using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {

        
        public Order Retreive(int orderId)
        {
            Order order = new Order(orderId);
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 10, 19, 10, 00, 00, new TimeSpan(5, 30, 0));
            }
            
            return order;
        }
        public bool Save()
        {
            return true;
        }
    }
}
