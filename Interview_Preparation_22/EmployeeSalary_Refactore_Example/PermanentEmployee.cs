using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalary_Refactore_Example
{
    public class PermanentEmployee : Employee , EmployeeBonusEligible,  IEmployee
    {
        public PermanentEmployee(int id, string name) : base(id, name) { }
        public double CalculateBonus(double salary)
        {
            return salary * 0.1;
        }

        public bool IsEligibleForInsurance()
        {
            return true;
        }
    }
}
