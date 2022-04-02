using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalary_Refactore_Example
{
    public abstract class Employee
    {
        public int id;
        public string name;
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return $"Employee Id: {id}, Employee Name: {name}";
        }


    }
}
