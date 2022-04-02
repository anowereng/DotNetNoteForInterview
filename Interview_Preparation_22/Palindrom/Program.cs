using System;

namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input  string value : ");
            var input = Console.ReadLine().Replace(" ", "");

            var reverseString = ReverseString(input);

            if (reverseString == input)
                Console.WriteLine($"{input} are palindrome");
            else
                Console.WriteLine($"{input} are not palindrome");
        }
        public static string ReverseString(string input )
        {
            var stringOutput = "";
            for (int i = input.Length; i > 0; i--)
            {
                stringOutput += input[i - 1];
            }
            return stringOutput;
        }
    }
}
