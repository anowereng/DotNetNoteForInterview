using System;

namespace FactorialWithRecursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindFactorial(5));
        }
        public static int FindFactorial(int number)
        {
            if (number == 1)
                return 1;

            var data =   FindFactorial(number - 1);
            return number * data;

        }
    }
}
