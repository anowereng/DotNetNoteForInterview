using System;
using System.Collections.Generic;
using System.Text;

namespace BankExample
{
    public interface SavingsAccount
    {
        void CreditLocalAmount(double amount);
        void CreditRemitanceAccount(double amount);

    }
}
