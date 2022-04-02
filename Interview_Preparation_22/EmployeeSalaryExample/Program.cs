using System;
using System.Collections.Generic;

namespace EmployeeSalaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Employee> emplist = new List<Employee>()
            {
                new PermanentEmployee(1, "anower"),
                new TemporaryEmployee(2, "Sazzad"),
                //new ContractualEmployee(3, "Kamal"), // throw exception contractual employee no salary
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
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
           
        }
    }
}
