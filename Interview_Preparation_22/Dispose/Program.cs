using System;
using System.IO;

namespace Dispose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var stService = new StudentService();
            
        }
    }

    public class StudentService : IDisposable
    {
        public StudentService()
        {
            // constructor called
            Console.WriteLine("Constructor called");
        }
        public void Dispose()
        {
            // dispose code
            Console.WriteLine("Dispose called");
        }
        public void GetStudentsExampleOne()
        {
            string path = "{your path}";
            using (var c = new StreamReader(path)) // another way dispose .  
            {
                // Do some work with 'C'
                // Even if there is an exception, c.Dispose() will be called before
                // the 'using' block is exited.
            }
        }
        public void GetStudentsExampleTwo()
        {
            string path = "{your path}";

            try{

            }catch(Exception)
            {
                //if (c != null)
                //    ((IDisposable)c).Dispose();
            }
        }

    }

}
