using System;
using System.Linq;

namespace FuncExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In func last is result , other parameter is input
            int[] numbers = new[] { 10, 15, 20 };

            Func<int, bool> predicate1 = IsLargerThan10;
            Func<int, bool> predicate1Improved = x => x > 10;

            Console.WriteLine(IsAny(numbers, IsLargerThan10)); // Example 1 func 
            Console.WriteLine(IsAny(numbers, predicate1));// Example 2 func 
            Console.WriteLine(IsAny(numbers, predicate1Improved)); ;// Example 3 func 
            Console.WriteLine(IsAny(numbers, (x => x > 10))); ;// Example 4 func 


            Func<int, int, int> prrdicateAdd = Add;
            Func<int, int, int> prrdicateAdd2 = (x,y) => x+y;
            int result = prrdicateAdd(10,20);
            int result2 = prrdicateAdd2(10,20);
            Console.WriteLine(result);

        }

        public static bool IsAny(int[] numbers, Func<int,bool> predicate)
        {
            foreach (var item in numbers)
            {
                if(predicate(item))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsLargerThan10(int number)
        {
            return number > 10;
        }
        public static bool IsEven(int number)
        {
            var result =  number % 2;
            return result == 0 ? true : false;
        }

        public static int Add(int x, int y) => x + y;
    }
}
