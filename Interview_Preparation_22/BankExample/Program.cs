using System;
using System.Collections.Generic;

namespace BankExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<StudentAccount>()
            {
                new StudentAccount("Acc01", "anower"),
                new StudentAccount("Acc02", "jahed"),
                new StudentAccount("Acc03", "sabbir"),
                new StudentAccount("Acc04", "Mangoo")
            };

            students[0].CreditLocalAmount(500);
            //students[0].CreditRemitanceAccount(5000); // get a exception 


            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
