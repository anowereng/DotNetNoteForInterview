using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryExample
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
        abstract public double CalculateBonus(double salary);
        abstract public bool IsEligibleForInsurance();

        public override string ToString()
        {
            return $"Employee Id: {id}, Employee Name: {name}";
        }


    }
}
