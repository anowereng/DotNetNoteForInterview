using System;
using System.Collections.Generic;
using System.Text;

namespace BankExample_ISP_Refactore
{
    internal interface SavingsAccountRemitance
    {
        void CreditRemitanceAccount(double amount);
    }
}
