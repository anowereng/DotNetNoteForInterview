using System;
using System.Collections.Generic;
using System.Text;

namespace DisposeFinalize
{
    internal class Customer2: Customer
    {
        ~Customer2()
        {
            Console.WriteLine("DESTRUCTOR2 CALLED");
        }
    }
}
