using System;
using System.Collections.Generic;

namespace NullExample
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            var name = GetName("anower");
            Console.WriteLine(name);
            

        }
        public static string GetName(string name)
        {
            return name ?? "Null Value ";
        }

        
    }
}
