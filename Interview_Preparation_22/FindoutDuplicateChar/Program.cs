using System;

namespace FindoutDuplicateChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input  = Console.ReadLine().Replace(" ","");
            char [] chars = input.ToCharArray();
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                var count = 0;
                for (int j = 0; j < chars.Length; j++)
                {
                    var char1 =  chars[i];
                    var char2 =  chars[j];
                    if (char1 == char2)
                    {
                        count ++;
                        if (count > 1)
                        {
                            if (result.IndexOf(chars[j]) == -1)
                            {
                                result += chars[j];
                            }
                            count = 0;
                        }
                    }
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
