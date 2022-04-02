using AccessModifier;
using System;

namespace AccessModifierCheck
{
    public class DemoChildClassTwo : DemoClass
    {
        public DemoChildClassTwo()
        {
            Console.WriteLine($"Protected: {base.ProtectedString}");// protected are access any assembly, if it is derived ; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = new DemoClass();
            Console.WriteLine($"Public: {test.PublicString}");
            //Console.WriteLine($"Private: {test.PrivateString}"); // private are not access from same assembly;
            //Console.WriteLine($"Protected: {test.ProtectedString}");// Protected are not access from same assembly;
            //Console.WriteLine($"Internal: {test.InternalString}");// Internal are access same assembly, other assembly not;
        }
    }
}
