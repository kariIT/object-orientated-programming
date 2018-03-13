using System;
using System.Collections.Generic;
using System.Text;

namespace rajapinta
{
    interface IProducts
    {
        void AddProducts(List<Product> product);

        void PrintProducts();
    }
}
