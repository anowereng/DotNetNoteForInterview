using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var converter = new ArrayConverter();
            var convertResult =  converter.ArrayTolist<int>(10,50);
            var convertResult2 =  converter.ArrayTolist<string>("anower","list");

            foreach (var item in convertResult2)
            {
               Console.WriteLine(item +"\n"); 
            }

        }
    }
}
