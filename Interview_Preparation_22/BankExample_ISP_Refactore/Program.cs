using System;
using System.Collections.Generic;

namespace BankExample_ISP_Refactore
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
            var remitancers = new List<RemitanceAccount>()
            {
                new RemitanceAccount("Acc05", "jamal"),
                new RemitanceAccount("Acc06", "jamshed"),
                new RemitanceAccount("Acc07", "jahed2"),
                new RemitanceAccount("Acc08", "Jack")
            };


            students[0].CreditLocalAmount(500);
            //students[0].CreditRemitanceAccount(5000); //  remitance account seperate interface so compiler error 


            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("==================");
            remitancers[0].CreditLocalAmount(500);
            remitancers[0].CreditRemitanceAccount(5000); //  remitance account seperate interface so compiler error 


            foreach (var remitancer in remitancers)
            {
                Console.WriteLine(remitancer.ToString());
            }
        }
    }
}
