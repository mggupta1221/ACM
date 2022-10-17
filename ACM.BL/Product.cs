using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        
        public int CurrentPrice { get; set; }
        public int ProductId { get; private set; }


        public bool Validate()
        {
            bool isValid = string.IsNullOrWhiteSpace(ProductName) || CurrentPrice == null ? false : true;
            return isValid;
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
