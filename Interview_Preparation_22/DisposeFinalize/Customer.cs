using System;
using System.Collections.Generic;
using System.Text;

namespace DisposeFinalize
{
    internal class Customer
    {
        ~Customer()
        {
            Console.WriteLine("DESTRUCTOR CALLED");
        }
    }
}
