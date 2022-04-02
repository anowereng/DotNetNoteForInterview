using System;

namespace MIddleware.API
{
    public class Print : IPrint
    {
        public void ExecPrint()
        {
            Console.Write(" Printing ");
        }
    }
}
