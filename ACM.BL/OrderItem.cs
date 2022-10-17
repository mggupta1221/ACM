using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {

        public string Product { get; set; } 

        public int Quantity { get; set; }

        public int PurchasePrice { get; set; }

        public bool Validate()
        {
            return true;
        }

        public Product Retreive()
        {
            return new Product();
        }

        public bool Save()
        {
            return true;
        }
    }
}
