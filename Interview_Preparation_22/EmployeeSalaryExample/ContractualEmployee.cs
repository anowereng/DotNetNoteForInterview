using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryExample
{
    public class ContractualEmployee : Employee
    {
        public ContractualEmployee(int id , string name):base(id, name)
        {

        }
        public override double CalculateBonus(double salary)
        {
            throw new NotImplementedException();
        }

        public override bool IsEligibleForInsurance()
        {
            return false;
        }
    }
}
