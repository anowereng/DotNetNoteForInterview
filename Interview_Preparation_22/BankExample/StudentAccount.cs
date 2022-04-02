using System;
using System.Collections.Generic;
using System.Text;

namespace BankExample
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

        public void CreditRemitanceAccount(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
