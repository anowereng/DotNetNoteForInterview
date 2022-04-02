using System;

namespace Dynamic_Example_Two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic d = 1;
            var testSum = d + 3;
            // Rest the mouse pointer over testSum in the following statement.
           

            // another example 
            dynamic d1 = 7;
            dynamic d2 = "a string";
            dynamic d3 = System.DateTime.Today;
            dynamic d4 = System.Diagnostics.Process.GetProcesses();
            // ( implicit conversion applied)
            int i = d1;
            string str = d2;
            DateTime dt = d3;
            System.Diagnostics.Process[] procs = d4;

            System.Console.WriteLine(i);
            System.Console.WriteLine(str);
            System.Console.WriteLine(dt);
            System.Console.WriteLine(procs[0]);
        }
    }
}
