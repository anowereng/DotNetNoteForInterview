using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryExample
{
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(int id, string name) : base(id, name)
        {
        }

        public override double CalculateBonus(double salary)
        {
            return salary * 0.5;    
        }

        public override bool IsEligibleForInsurance()
        {
            return false;
        }
    }
}
