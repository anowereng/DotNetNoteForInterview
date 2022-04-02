using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalary_Refactore_Example
{
    public class ContractualEmployee : Employee, IEmployee
    {
        public ContractualEmployee(int id, string name) : base(id, name) { }
        public  bool IsEligibleForInsurance()
        {
            return false;
        }
    }
}
