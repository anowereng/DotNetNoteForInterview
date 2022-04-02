using System;

namespace RemoveDuplicateChar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please input string value : ");
            var input  = Console.ReadLine().Replace(" ", "");
            Console.WriteLine(RemoveDuplicateCharFunc(input));
        }

        public static string RemoveDuplicateCharFunc(string content)
        {
            var result = "";
            foreach (char item in content)
            {
                if (result.IndexOf(item) == -1){
                    result += item;
                }
            }
            return result;
        }
    }
}
