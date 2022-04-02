using System;
using System.Collections.Generic;
using System.Text;

namespace BankExample_ISP_Refactore
{
    public abstract class BaseAccount
    {
        private string AccountId { get; set; }
        private string AccountName { get; set; }
        public double Amount { get; set; }

        public BaseAccount(string accountId,  string accountName)
        {
            this.AccountId = accountId;
            this.AccountName = accountName;
        }

        public override string ToString()
        {
            return $"Account Id:{this.AccountId}, Account Name: {this.AccountName}, Amount: {this.Amount}";
        }

        public  double GetAmount()
        {
            return Amount;
        }

        public  double SetAmount(double amount)
        {
            return Amount += amount;
        }
    }
}
