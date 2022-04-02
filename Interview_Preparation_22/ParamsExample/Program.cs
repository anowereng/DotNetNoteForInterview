using System;

namespace ParamsExample
{
    internal class Program
    {
        public static int Sum(params int[] numbers)
        {
            var sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //var result  =  Sum(new int[] { 1, 2, 3, 4, 5, }); // without params
            var result  =  Sum(1,2,3); //params use method last param ;

            Console.WriteLine($"Sum Result:{result}");
        }
    }
}
