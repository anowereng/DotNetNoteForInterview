using System;
using System.Configuration;

namespace AccessModifier
{
    class DemoClassThree // default internal class 
    {
        string name = "anower"; // default private class property
        class DemoClassThreeChildClass // default private nested child class
        {
            string childProperty = "anower";
        }
    }
    public class DemoClass
    {
        public string PublicString = "Public";
        private string PrivateString = "Private";
        protected string ProtectedString = "Protected";
        internal string InternalString = "Internal";
        protected internal string ProtectedInternalString = "ProtectedInternal";

        public DemoClass()
        {
            Console.WriteLine($"Protected: {ProtectedString}");// protected are access any assembly and same class , if it is derived (same class not need onherit) ; 
        }
    }
    public class DemoChildClassOne: DemoClass
    {
        public  DemoChildClassOne()
        {
            Console.WriteLine($"Protected: {base.ProtectedString}");// protected are access any assembly, if it is derived ; 
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var test = new DemoClass();

            Console.WriteLine($"Public: {test.PublicString}");
            //Console.WriteLine($"Private: {test.PrivateString}"); // private are not access from same assembly;
            //Console.WriteLine($"Protected: {test.ProtectedString}");// Protected are not access from any assembly, if it is not derived ;
            Console.WriteLine($"Internal: {test.InternalString}");// Internal are access same assembly, other assembly not;
            Console.WriteLine($"Internal: {test.ProtectedInternalString}");// Protected Internal are access same assembly, other assembly not;

            DemoClassThree three  =  new DemoClassThree();
            
        }
        public class hello
        {

        }
    }
}
