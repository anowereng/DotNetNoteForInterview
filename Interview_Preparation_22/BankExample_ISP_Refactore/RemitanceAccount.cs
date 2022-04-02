using System;
using System.Collections.Generic;
using System.Text;

namespace BankExample_ISP_Refactore
{
    public class RemitanceAccount : BaseAccount, SavingsAccount, SavingsAccountRemitance
    {
        public RemitanceAccount(string accountId, string accountName) : base(accountId, accountName)
        {
        }

        public void CreditLocalAmount(double amount)
        {
            this.SetAmount(amount);
        }

        public void CreditRemitanceAccount(double amount)
        {
            var updateAmount = amount * 0.2;
            this.SetAmount(updateAmount);
        }
    }
}
