using System;

namespace Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Power(2,4));
        }
        public static int Power(int baseNumber , int power)
        {
            var number = 1;
            for (int i = 1; i<=power; i++)
            {
                number*= baseNumber;
            }
            return number;
        }
    }
}
