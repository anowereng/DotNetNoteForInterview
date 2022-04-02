using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryExample
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee(int ids, string name) : base(ids, name)
        {
            
        }

        public override double CalculateBonus(double salary)
        {
            return salary * 0.1;
        }

        public override bool IsEligibleForInsurance()
        {
            return true;
        }
    }
}
