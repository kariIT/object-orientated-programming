using System;
using System.Collections.Generic;
using System.Text;

namespace rajapinta
{
    interface IProduct
    {
        void GetProduct();

        void CountValue();

        void SearchProduct(List<Product> products, string search);
      
    }
}
