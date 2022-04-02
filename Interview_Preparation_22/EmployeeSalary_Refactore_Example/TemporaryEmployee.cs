using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalary_Refactore_Example
{
    public class TemporaryEmployee : Employee, EmployeeBonusEligible, IEmployee
    {
        public TemporaryEmployee(int id, string name) : base(id, name) { }

        public  double CalculateBonus(double salary)
        {
            return salary * 0.5;    
        }

        public  bool IsEligibleForInsurance()
        {
            return false;
        }
    }
}
