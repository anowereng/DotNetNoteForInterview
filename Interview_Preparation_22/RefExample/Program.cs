using System;

namespace RefExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            GetIncementNumberWithoutRef(i);
            Console.WriteLine("\n" + i); // without ref value called 

            GetIncementNumberRefUse(ref j);
            Console.WriteLine("\n" + j); // ref value called 
        }
        public static void GetIncementNumberWithoutRef(int number)
        {
            Console.Write("Without Ref Method Called");
            ++number;
        }
        public static void GetIncementNumberRefUse(ref int number)
        {
            Console.Write("Ref Method Called");
            ++number;
        }
    }
}

