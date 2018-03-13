using System;
using System.Collections.Generic;
using System.Text;

namespace rajapinta
{
    interface ICustomers
    {
        void AddCustomers(List<Customer> customer);

        void PrintCustomers();
    }
}
