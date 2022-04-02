using System;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input  string value : ");
            var input = Console.ReadLine().Replace(" ", "");
            var stringOutput = "";
            for (int i = input.Length; i>0; i--)
            {
                stringOutput += input[i-1];
            }
            Console.WriteLine(stringOutput);    
        }
    }
}
