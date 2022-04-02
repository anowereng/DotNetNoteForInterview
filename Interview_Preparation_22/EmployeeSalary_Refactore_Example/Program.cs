using System;
using System.Collections.Generic;

namespace EmployeeSalary_Refactore_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emplist = new List<EmployeeBonusEligible>()
            {
                new PermanentEmployee(1, "anower"),
                new TemporaryEmployee(2, "Sazzad")// throw exception contractual employee no salary
            };

            foreach (var employee in emplist)
            {
                Console.WriteLine(employee.ToString());
            }

            Console.WriteLine("========== Salary =========");

            foreach (var employee in emplist)
            {
                Console.WriteLine(employee.CalculateBonus(10000));
            }

            var emplist2 = new List<IEmployee>()
            {
                new PermanentEmployee(1, "anower"),
                new TemporaryEmployee(2, "Sazzad"),// throw exception contractual employee no salary
                new ContractualEmployee(3, "kabir")// throw exception contractual employee no salary
            };

          

            foreach (var employee in emplist2)
            {
                Console.WriteLine(employee.ToString());
            }

            Console.WriteLine("========== Salary =========");

            foreach (var employee in emplist2)
            {
                Console.WriteLine(employee.IsEligibleForInsurance());
            }
        }
    }
}
