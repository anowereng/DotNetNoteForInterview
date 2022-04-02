using System;

namespace SingleTonExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var singleTon1  = SingleTon.GetInStance();
            var singleTon2  = SingleTon.GetInStance();

            if(singleTon1 == singleTon2)    
                Console.WriteLine(true);
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
