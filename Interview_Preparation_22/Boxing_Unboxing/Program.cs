using System;

namespace Boxing_Unboxing
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "anower";
            object nameToUnbox =  name;
            string a = nameToUnbox.ToString();
            Console.WriteLine(a);
        }
    }
}
