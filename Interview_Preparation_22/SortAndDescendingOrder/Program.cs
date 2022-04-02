using System;

namespace SortAndDescendingOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[] { 2, 10, };

             Array.Reverse(values);
            foreach (var item in values)
            {
                Console.WriteLine(item);   
            }

        }
    }
}
