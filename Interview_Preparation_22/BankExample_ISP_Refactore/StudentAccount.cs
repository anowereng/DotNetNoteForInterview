using System;
using System.Collections.Generic;
using System.Text;

namespace BankExample_ISP_Refactore
{
    public class StudentAccount : BaseAccount, SavingsAccount
    {
        public StudentAccount(string accountId, string accountName) : base(accountId, accountName)
        {
        }

        public void CreditLocalAmount(double amount)
        {
            this.SetAmount(amount);
        }
    }
}
