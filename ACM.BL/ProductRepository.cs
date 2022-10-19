using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retreive(int productId)
        {

            Product product = new Product(productId);

            if(productId == 2)
            {
                product.ProductName = "Sunflower";
                product.ProductDescription = "Bunch of 4 flowers";
                product.CurrentPrice= 13.33M;
            }

            return product;
        }

        public bool Save()
        {
            return true;
        }
    }
}
