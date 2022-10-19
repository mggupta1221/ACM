using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {

        public Product(int productId)
        {
                this.ProductId = productId;
        }
        public string ? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public decimal CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public bool Validate()
        {
            bool isValid = string.IsNullOrWhiteSpace(ProductName) || CurrentPrice == 0 ? false : true;
            return isValid;
        }

       
    }
}
