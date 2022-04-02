using System;

namespace AnagramWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input first string value : ");
            var input = Console.ReadLine().Replace(" ", "");
            Console.WriteLine("Please input second string value : ");
            var secondInput = Console.ReadLine().Replace(" ", "");
            Console.WriteLine(AnagramString(input, secondInput));
        }

        public static string AnagramString(string firstword, string secondword)
        {
            bool isAnagram = true;

            foreach (char item in firstword)
            {
                
                if(secondword.IndexOf(item) == -1)
                {
                    isAnagram = false;
                    break;
                }
            }
            if (isAnagram)
                return $"{firstword} and {secondword} are anagram";
            else
                return $"{firstword} and {secondword} are Not anagram";
        }
    }
}
