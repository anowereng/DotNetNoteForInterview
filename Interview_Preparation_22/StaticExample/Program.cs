using System;

namespace StaticExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee.GetEmployeeInfo();
            Employee.GetEmployeeInfo("anower");
        }
    }

    static class Employee
    {
        private static string Date { get; set; }

        //public static Employee() // static constructor ca not use access modified 
        //{
        //}
        static Employee() // static constructor
        {
            Date = DateTime.UtcNow.ToString();
            Console.WriteLine(Date);
        }
        public static void GetEmployeeInfo()
        {
            Console.WriteLine("called employee info");
        }
        public static void GetEmployeeInfo(string a)
        {
            Console.WriteLine(a);
        }
    }

}
