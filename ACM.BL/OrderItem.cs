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
            OrderItemId = orderItemId;  
        }
        public string Product { get; set; } 

        public int Quantity { get; set; }

        public decimal? PurchasePrice { get; set; }
        public int OrderItemId { get; private set; }    
        public bool Validate()
        {
            bool isValid = (Quantity <= 0 || OrderItemId <= 0 || PurchasePrice == null) ? false : true;
            return isValid;
        }

        public OrderItem Retreive()
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }
    }
}
